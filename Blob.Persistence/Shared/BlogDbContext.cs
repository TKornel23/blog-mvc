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
		base.OnModelCreating(builder);
    }

	public BlogDbContext(DbContextOptions<BlogDbContext> options)
		: base(options)
	{

	}
}
