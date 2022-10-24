using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_mvc_boilerplate.WEB.Areas.Finance.Controllers
{
    [Area("Finance")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
