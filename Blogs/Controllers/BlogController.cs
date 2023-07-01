using Castle.Core.Logging;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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
    [HttpPut]
    public IActionResult UpdateBlog(Blog.Persistence.Blog blogToUpdate)
    {
        this._unitOfWork.BlogRepository.Update(blogToUpdate);

        this._unitOfWork.Save();

        return Ok();
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
