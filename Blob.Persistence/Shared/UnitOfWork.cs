namespace Blog.Persistence;

public class UnitOfWork : IDisposable, IUnitOfWork
{
    private BlogDbContext context = new BlogDbContext();
    private GenericRepository<Blog>? blogRepository;
    private GenericRepository<Comment>? commentRepository;
    private GenericRepository<Tag>? tagRepository;

    public GenericRepository<Tag> TagRepository
    {
        get
        {
            if (this.tagRepository == null)
            {
                this.tagRepository = new GenericRepository<Tag>(context);
            }
            return tagRepository;
        }
    }

    public GenericRepository<Blog> BlogRepository
    {
        get
        {

            if (this.blogRepository == null)
            {
                this.blogRepository = new GenericRepository<Blog>(context);
            }
            return blogRepository;
        }
    }

    public GenericRepository<Comment> CommentRepository
    {
        get
        {

            if (this.commentRepository == null)
            {
                this.commentRepository = new GenericRepository<Comment>(context);
            }
            return commentRepository;
        }
    }

    public void Save()
    {
        context.SaveChanges();
    }

    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
