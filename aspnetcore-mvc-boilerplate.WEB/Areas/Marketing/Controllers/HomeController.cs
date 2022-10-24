using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_mvc_boilerplate.WEB.Areas.Marketing.Controllers
{
    [Area("Marketing")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
