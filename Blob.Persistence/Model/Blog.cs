namespace Blog.Persistence;

public class Blog : Entity
{
    [MaxLength(50)]
    [NotNull]
    public string Title { get; set; } = null!;
    public virtual SiteUser Owner { get; set; } = null!;
    public virtual ICollection<Comment>? Comments { get; set; }
    public virtual ICollection<Tag>? Tags { get; set; }
    [NotNull]
    public string OwnerId { get; set; } = null!;
    [MinLength(2)]
    public string BlogText { get; set; } = null!;
    public int Likes { get; set; }
}
