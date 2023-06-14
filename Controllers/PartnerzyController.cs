using Microsoft.AspNetCore.Mvc;

namespace Konfigurator_ogrodzeń.Controllers
{
    public class PartnerzyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StronaPartnerzy()
        {
            return View("StronaPartnerzy");
        }
    }
}
