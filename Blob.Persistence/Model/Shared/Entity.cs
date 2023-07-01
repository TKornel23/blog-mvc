namespace Blog.Persistence;

public class Entity
{
    public string Id { get; set; }
    public DateTime Created { get; set; }

    public Entity()
    {
        this.Created = DateTime.Now;
        this.Id = Guid.NewGuid().ToString();
    }
}
