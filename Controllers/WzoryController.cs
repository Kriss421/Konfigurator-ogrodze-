using Microsoft.AspNetCore.Mvc;

namespace Konfigurator_ogrodzeń.Controllers
{
    public class WzoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StronaWzory()
        {
            return View("StronaWzory");
        }
    }
}
