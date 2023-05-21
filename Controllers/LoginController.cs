using Microsoft.AspNetCore.Mvc;

namespace Konfigurator_ogrodzeń.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Sprawdź, czy wprowadzone dane logowania są poprawne
            if (username == "admin" && password == "password")
            {
                // Użytkownik zalogowany poprawnie - przekieruj do panelu administracyjnego
                return RedirectToAction("AdminIndex", "Admin");
            }

            // Nieprawidłowe dane logowania - wyświetl błąd
            ModelState.AddModelError("", "Nieprawidłowe dane logowania");
            return View();
        }
    }
}
