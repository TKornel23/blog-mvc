namespace Blob.Persistence;

public class SiteUser : IdentityUser
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? ContentType { get; set; }

    public byte[]? Data { get; set; }
}
