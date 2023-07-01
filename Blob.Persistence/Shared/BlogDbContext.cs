namespace Blog.Persistence;

public class BlogDbContext : IdentityDbContext
{
	DbSet<SiteUser>? AppUsers { get; set; }
	DbSet<Blog>? Blogs { get; set; }
	DbSet<Comment>? Comments { get; set; }
	DbSet<Tag>? Tags { get; set; }

	protected override void OnModelCreating(ModelBuilder builder)
	{
		base.OnModelCreating(builder);
	}
}
