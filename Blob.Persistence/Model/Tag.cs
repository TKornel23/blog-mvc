namespace Blog.Persistence;

public class Tag : Entity
{
    [MaxLength(50)]
    public string Title { get; set; } = null!;
    public virtual Blog? Blog { get; set; }
    [NotNull]
    public string? BlogId { get; set; }
    public virtual SiteUser Owner { get; set; } = null!;
    [NotNull]
    public string OwnerId { get; set; } = null!;
}
