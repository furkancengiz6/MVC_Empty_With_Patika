using Microsoft.AspNetCore.Mvc;

namespace MVC_Empty_With_Patika.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
