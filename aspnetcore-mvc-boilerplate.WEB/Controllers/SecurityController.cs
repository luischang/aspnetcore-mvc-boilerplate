using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_mvc_boilerplate.WEB.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Validate(string email, string password)
        {
            if (email == "admin@peru.com" && password == "admin123")
                return RedirectToAction("Index", "Home", new { Area = "Finance"});

            return RedirectToAction("Login", "Security");
        }
    }
}
