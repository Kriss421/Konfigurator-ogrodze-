using Microsoft.AspNetCore.Mvc;

namespace Konfigurator_ogrodzeń.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminIndex()
        {
            return View("AdminIndex");
        }
    }
}
