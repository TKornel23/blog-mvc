namespace Blog.Persistence;

public interface IUnitOfWork
{
    GenericRepository<Blog> BlogRepository { get; }
    GenericRepository<Comment> CommentRepository { get; }
    GenericRepository<Tag> TagRepository { get; }

    void Dispose();
    void Save();
}