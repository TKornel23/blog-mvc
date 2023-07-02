namespace Blogs;

public class BlogIndexViewModel
{
    public IEnumerable<Blog.Persistence.Blog> Blogs { get; set; }
    public Blog.Persistence.Blog Blog { get; set; }
}
