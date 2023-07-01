namespace Blogs;

public class SuperAdminController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly UserManager<SiteUser> _userManager;

    public SuperAdminController(IUnitOfWork unitOfWork, UserManager<SiteUser> userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }

    [Authorize(Roles = "Admin")]
    public IActionResult Index()
    {
        var blogs = this._unitOfWork.BlogRepository
            .Get(orderBy: o => o.OrderBy(x => x.Created));

        var tags = this._unitOfWork.TagRepository
            .Get(orderBy: o => o.OrderBy(x => x.Created));

        var comments = this._unitOfWork.CommentRepository
            .Get(orderBy: o => o.OrderBy(x => x.Created));

        var users = this._userManager.Users;

        var superAdminViewModel = new SuperAdminViewModel()
        {
            Comments = comments,
            Blogs = blogs,
            Tags = tags,
            Users = users
        };

        return View(superAdminViewModel);
    }
}
