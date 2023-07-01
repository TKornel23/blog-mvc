namespace Blog.Persistence;

public class BlogDbContext : IdentityDbContext
{
	DbSet<SiteUser>? ApplicationUsers { get; set; }
	DbSet<Blog>? Blogs { get; set; }
	DbSet<Comment>? Comments { get; set; }
	DbSet<Tag>? Tags { get; set; }

	protected override void OnModelCreating(ModelBuilder builder)
	{
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        builder.Entity<IdentityRole>().HasData(
			new { Id = "1", Name = "User", NormalizedName = "USER" },
            new { Id = "2", Name = "Admin", NormalizedName = "ADMIN" }
            );

		PasswordHasher<SiteUser> ph = new PasswordHasher<SiteUser>();
		SiteUser tkor = new SiteUser()
		{
			Id = Guid.NewGuid().ToString(),
			Email = "tkornel23@gmail.com",
			EmailConfirmed = true,
			UserName = "tkornel23@gmail.com",
			NormalizedUserName = "TKORNEL23@GMAIL.COM",
            FirstName = "Toth",
            LastName = "Kornel"
        };
		tkor.PasswordHash = ph.HashPassword(tkor, "Asdasd123456.");

        SiteUser ttor = new SiteUser()
        {
            Id = Guid.NewGuid().ToString(),
            Email = "ttoraxon@gmail.com",
            EmailConfirmed = true,
            UserName = "ttoraxon@gmail.com",
            NormalizedUserName = "TTORAXON@GMAIL.COM",
			FirstName = "Toth",
			LastName = "Kornel"
        };
        tkor.PasswordHash = ph.HashPassword(tkor, "Asdasd123456.");
        ttor.PasswordHash = ph.HashPassword(ttor, "Asdasd123456.");

		builder.Entity<SiteUser>().HasData(tkor, ttor);

		var admin = new IdentityUserRole<string>
		{
			RoleId = "2",
			UserId = tkor.Id
		};

        var user = new IdentityUserRole<string>
        {
            RoleId = "1",
            UserId = ttor.Id
        };

		builder.Entity<IdentityUserRole<string>>().HasData(admin, user);
		base.OnModelCreating(builder);
    }

	public BlogDbContext(DbContextOptions<BlogDbContext> options)
		: base(options)
	{

	}
}
