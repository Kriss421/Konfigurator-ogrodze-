using Microsoft.AspNetCore.Mvc;

namespace Konfigurator_ogrodzeń.Controllers
{
    public class KontaktController : Controller
    {
        public ActionResult StronaKontakt()
        {
            return View("Kontakt");
        }
    }
}
