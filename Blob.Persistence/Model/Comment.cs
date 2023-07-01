namespace Blog.Persistence;

public class Comment : Entity
{
    public string CommentSection { get; set; } = null!;
    public Blog Blog { get; set; } = null!;
    public SiteUser Owner { get; set; } = null!;
    public ICollection<Comment>? Answers { get; set; }
    public Guid BlogId { get; set; }
}
