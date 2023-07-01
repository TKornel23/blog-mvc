namespace Blogs;

public interface IBlogService
{
    IEnumerable<Blog.Persistence.Blog> GetBlogsForMainPage();
}