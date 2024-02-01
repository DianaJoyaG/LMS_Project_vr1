using Microsoft.AspNetCore.Mvc;

namespace LMS_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
