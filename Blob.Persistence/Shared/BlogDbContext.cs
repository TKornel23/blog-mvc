namespace Blob.Persistence;

public class BlogDbContext : IdentityDbContext
{
	DbSet<SiteUser>? AppUsers { get; set; }
	DbSet<Blog>? Blogs { get; set; }
	DbSet<Comment>? Comments { get; set; }

	public BlogDbContext(DbContextOptions<BlogDbContext> options)
		:base(options)
	{

	}
}
