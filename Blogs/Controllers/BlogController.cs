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

    [Authorize]
    public IActionResult Index()
    {
        var blogs = this.blogService.GetBlogsForMainPage();

        var model = new BlogIndexViewModel()
        {
            Blogs = blogs,
            Blog = new Blog.Persistence.Blog()
        };
        
        return View(model);
    }

    [HttpGet("tag")]
    public ActionResult<IEnumerable<Tag>> ReturnTagsForBlog([FromQuery] string blogId)
    {
        var tags = this._unitOfWork.TagRepository.Get(x => x.BlogId == blogId);

        return Ok(tags);
    }

    [Authorize]
    [HttpGet]
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

            this._unitOfWork.Save();

            return RedirectToAction("Index", "Admin");
        }
        catch
        {
            return BadRequest();
        }
    }

    [Authorize]
    [HttpGet]
    public IActionResult UpdateBlog([FromQuery] string blogId)
    {
        var blogToUpdate = this._unitOfWork.BlogRepository.GetByID(blogId);

        return View("Update", blogToUpdate);
    }

    [Authorize]
    [HttpPost]
    public IActionResult Update(Blog.Persistence.Blog blogToUpdate)
    {
        this._unitOfWork.BlogRepository.Update(blogToUpdate);

        this._unitOfWork.Save();

        return RedirectToAction("Index", "admin");
    }

    [Authorize]
    [HttpGet("GetOne/{blogId}")]
    public IActionResult GetOne(string blogId)
    {
        var blog = this._unitOfWork.BlogRepository.GetByID(blogId);

        if(blog is null)
        {
            return BadRequest();
        }

        return View("OneBlog", blog);
    }

    [Authorize]
    [HttpPost("Blog/CreateAsync")]
    public async Task<IActionResult> CreateAsync(Blog.Persistence.Blog blog)
    {
        var blogs = this.blogService.GetBlogsForMainPage();

        var model = new BlogIndexViewModel()
        {
            Blogs = blogs,
            Blog = blog
        };

        if (!ModelState.IsValid)
        {
            return View("Index", model);
        }

        var user = await this._userManager.GetUserAsync(this.User);

        blog.OwnerId = user.Id;
        blog.Owner = user;

        this._unitOfWork.BlogRepository.Insert(blog);

        this._unitOfWork.Save();

        return RedirectToAction("Index");
    }

    [Authorize]
    [HttpGet("Like/{blogId}")]
    public IActionResult Like(string blogId)
    {
        var blog = this._unitOfWork.BlogRepository.GetByID(blogId);

        blog.Likes = blog.Likes + 1;
        blog.Modified = DateTime.Now;
        _unitOfWork.BlogRepository.Update(blog);

        _unitOfWork.Save();

        return View("OneBlog", blog);
    }

    [Authorize]
    [HttpGet("Dislike/{blogId}")]
    public IActionResult Dislike(string blogId)
    {
        var blog = this._unitOfWork.BlogRepository.GetByID(blogId);

        if(blog.Likes > 0)
        {
            blog.Likes = blog.Likes - 1;
            blog.Modified = DateTime.Now;
            _unitOfWork.BlogRepository.Update(blog);

            _unitOfWork.Save();
        }

        return View("OneBlog", blog);
    }
}
