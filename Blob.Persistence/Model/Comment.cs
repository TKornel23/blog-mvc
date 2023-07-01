namespace Blog.Persistence;

public class Comment : Entity
{
    [MaxLength(254)]
    public string CommentSection { get; set; } = null!;
    public virtual Blog Blog { get; set; } = null!;
    public virtual SiteUser Owner { get; set; } = null!;
    [NotNull]
    public string BlogId { get; set; } = null!;
    [NotNull]
    public string OwnerId { get; set; } = null!;
}
