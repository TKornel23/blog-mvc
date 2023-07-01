namespace Blog.Persistence;

public class Tag : Entity
{
    public string Title { get; set; } = null!;
    public Blog Blog { get; set; } = null!;
    public Guid BlogId { get; set; }
    public SiteUser Owner { get; set; } = null!;
}
