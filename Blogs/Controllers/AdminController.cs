using Blog.Persistence;

namespace Blogs;

[Route("admin")]
public class AdminController : Controller
{
    private readonly UserManager<SiteUser> _userManager;
    private readonly IUnitOfWork _unitOfWork;

    public AdminController(
        UserManager<SiteUser> userManager,
        IUnitOfWork unitOfWork)
    {
        this._userManager = userManager;
        _unitOfWork = unitOfWork;
    }

    [Authorize]
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var user = await this._userManager.GetUserAsync(this.User);

        var blogs = this._unitOfWork.BlogRepository
            .Get(filter: x => x.OwnerId == user.Id, orderBy: o => o.OrderBy(x => x.Created));

        var tags = this._unitOfWork.TagRepository
            .Get(filter: x => x.OwnerId == user.Id, orderBy: o => o.OrderBy(x => x.Created));

        var comments = this._unitOfWork.CommentRepository
            .Get(filter: x => x.OwnerId == user.Id, orderBy: o => o.OrderBy(x => x.Created));

        var adminViewModel = new AdminViewModel()
        {
            Comments = comments,
            Blogs = blogs,
            Tags = tags
        };

        return View(adminViewModel);
    }
}
