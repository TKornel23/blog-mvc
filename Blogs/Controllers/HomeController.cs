using Microsoft.AspNetCore.Mvc;

namespace Blogs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
