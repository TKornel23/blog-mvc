namespace Blog.Persistence;

public class Blog : Entity
{
    [MaxLength(50)]
    [MinLength(2)]
    [NotNull]
    [Required]
    public string Title { get; set; } = null!;
    public virtual SiteUser? Owner { get; set; }
    public virtual ICollection<Comment>? Comments { get; set; }
    public virtual ICollection<Tag>? Tags { get; set; }
    public string? OwnerId { get; set; }
    [MinLength(2)]
    [Required]
    public string BlogText { get; set; } = null!;
    public int Likes { get; set; }
}
