using Microsoft.AspNetCore.Mvc;

namespace Konfigurator_ogrodzeń.Controllers
{
    public class StatsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StronaStats()
        {
            return View("StronaStats");
        }
    }
}
