namespace Blog.Persistence;

public class Comment : Entity
{
    [Required]
    [MaxLength(254)]
    [MinLength(2)]
    public string CommentSection { get; set; } = null!;
    public virtual Blog? Blog { get; set; }
    public virtual SiteUser? Owner { get; set; }
    public string BlogId { get; set; } = null!;
    public string OwnerId { get; set; } = null!;
}
