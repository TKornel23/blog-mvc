namespace Blogs;

public class BlogController : Controller
{
    private readonly UserManager<SiteUser> _userManager;
    private readonly IUnitOfWork _unitOfWork;

    public BlogController(
        UserManager<SiteUser> userManager,
        IUnitOfWork unitOfWork)
    {
        this._userManager = userManager;
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        return View();
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
    public IActionResult UpdateBlog(string blogToUpdate)
    {
        var blog = this._unitOfWork.BlogRepository.GetByID(blogToUpdate);

        this._unitOfWork.BlogRepository.Update(blog);

        this._unitOfWork.Save();

        return Ok();
    }

    public IActionResult GetOne(string blogId)
    {
        var blog = this._unitOfWork.BlogRepository.GetByID(blogId);

        if(blog is null)
        {
            return BadRequest();
        }

        return Ok(blog);
    }
}
