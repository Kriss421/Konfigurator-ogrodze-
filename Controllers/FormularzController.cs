using Microsoft.AspNetCore.Mvc;

namespace Konfigurator_ogrodzeń.Controllers
{

    public class FormularzController : Controller
    {
        public IActionResult FormularzKontaktowy(string kolor, string opcjePionowe, string opcjePoziome)
        {
       
            ViewBag.Kolor = kolor;
            ViewBag.OpcjePionowe = opcjePionowe;
            ViewBag.OpcjePoziome = opcjePoziome;

            return View("Formularz");
        }
    }
}

