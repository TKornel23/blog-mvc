namespace Blogs;

public class BlogController : Controller
{
    private readonly UserManager<SiteUser> _userManager;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IBlogService blogService;

    public BlogController(
        UserManager<SiteUser> userManager,
        IUnitOfWork unitOfWork,
        IBlogService blogService)
    {
        this._userManager = userManager;
        _unitOfWork = unitOfWork;
        this.blogService = blogService;
    }

    public IActionResult Index()
    {
        var blogs = this.blogService.GetBlogsForMainPage();

        return View(blogs);
    }

    [Authorize]
    [HttpDelete]
    public IActionResult DeleteBlog(string blogId)
    {
        try
        {
            var blog = this._unitOfWork.BlogRepository.GetByID(blogId);

            if (blog is null)
            {
                throw new ArgumentNullException();
            }

            this._unitOfWork.BlogRepository.Delete(blog!);

            return Ok();
        }
        catch
        {
            return BadRequest();
        }
    }

    [Authorize]
    [HttpPut]
    public IActionResult UpdateBlog(Blog.Persistence.Blog blogToUpdate)
    {
        this._unitOfWork.BlogRepository.Update(blogToUpdate);

        this._unitOfWork.Save();

        return Ok();
    }

    [Authorize]
    [HttpGet]
    public IActionResult GetOne(string blogId)
    {
        var blog = this._unitOfWork.BlogRepository.GetByID(blogId);

        if(blog is null)
        {
            return BadRequest();
        }

        return View(blog);
    }

    [HttpPost("Blog/CreateAsync")]
    public async Task<IActionResult> CreateAsync(Blog.Persistence.Blog blog)
    {
        var user = await this._userManager.GetUserAsync(this.User);

        blog.OwnerId = user.Id;
        blog.Owner = user;

        this._unitOfWork.BlogRepository.Insert(blog);

        this._unitOfWork.Save();

        return RedirectToAction("Index");
    }
}
