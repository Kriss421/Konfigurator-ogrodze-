using Microsoft.AspNetCore.Mvc;

namespace Konfigurator_ogrodzeń.Controllers
{

    public class FormularzController : Controller
    {
        public ActionResult FormularzKontaktowy()
        {
            return View("Formularz");
        }
    }
}

