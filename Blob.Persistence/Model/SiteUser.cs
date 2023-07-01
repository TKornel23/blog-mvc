namespace Blog.Persistence;

public class SiteUser : IdentityUser
{
    [NotNull]
    [MaxLength(100)]
    public string FirstName { get; set; } = null!;

    [NotNull]
    [MaxLength(100)]
    public string LastName { get; set; } = null!;

    public string? ContentType { get; set; }

    public byte[]? Data { get; set; }

    public virtual ICollection<Blog>? Blogs { get; set; }
    public virtual ICollection<Tag>? Tags { get; set; }
    public virtual ICollection<Comment>? Comments { get; set; }
}
