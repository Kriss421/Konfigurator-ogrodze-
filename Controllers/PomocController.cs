using Microsoft.AspNetCore.Mvc;

namespace Konfigurator_ogrodzeń.Controllers
{
    public class PomocController : Controller
    {
        public ActionResult StronaPomoc()
        {
            return View("Pomoc");
        }
    }
}
