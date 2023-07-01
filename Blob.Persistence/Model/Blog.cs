namespace Blob.Persistence;

public class Blog : Entity
{
    public string Title { get; set; } = null!;
    public SiteUser Owner { get; set; } = null!;
    public ICollection<Comment>? Comments { get; set; }
}
