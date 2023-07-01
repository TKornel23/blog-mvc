namespace Blogs;

internal class SuperAdminViewModel
{
    public IEnumerable<Tag>? Tags;
    public IEnumerable<Blog.Persistence.Blog>? Blogs;
    public IEnumerable<Comment>? Comments;
    public IEnumerable<SiteUser>? Users;
}