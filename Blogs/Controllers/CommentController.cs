using Blog.Persistence;
using System.Runtime.CompilerServices;

namespace Blogs;

[Route("Comment")]
public class CommentController : Controller
{
    private readonly UserManager<SiteUser> _userManager;
    private readonly IUnitOfWork _unitOfWork;

    public CommentController(UserManager<SiteUser> userManager, IUnitOfWork unitOfWork)
    {
        _userManager = userManager;
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("CreateAsync")]
    public async Task<IActionResult> CreateAsync(Comment comment)
    {
        comment.Owner = await _userManager.GetUserAsync(this.User);
        comment.OwnerId = comment.Owner.Id;
        comment.Blog = _unitOfWork.BlogRepository.GetByID(comment.BlogId)!;
        this._unitOfWork.CommentRepository.Insert(comment);

        this._unitOfWork.Save();

        return RedirectToAction($"GetOne", "Blog", new { blogId = comment.BlogId });
    }

    [HttpGet]
    public IActionResult DeleteComment(string commentId)
    {
        try
        {
            var comment = this._unitOfWork.CommentRepository.GetByID(commentId);

            if (comment is null)
            {
                throw new ArgumentNullException();
            }

            this._unitOfWork.CommentRepository.Delete(comment!);

            this._unitOfWork.Save();

            return RedirectToAction($"GetOne", "Blog", new { blogId = comment!.BlogId });
        }
        catch
        {
            return BadRequest();
        }
    }
}
