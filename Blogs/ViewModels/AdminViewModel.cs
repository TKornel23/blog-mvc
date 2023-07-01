namespace Blogs;

internal class AdminViewModel
{
    public IEnumerable<Tag>? Tags;
    public IEnumerable<Blog.Persistence.Blog>? Blogs;
    public IEnumerable<Comment>? Comments;
}
