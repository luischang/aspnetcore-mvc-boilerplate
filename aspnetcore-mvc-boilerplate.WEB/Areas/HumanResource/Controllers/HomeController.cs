using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_mvc_boilerplate.WEB.Areas.HumanResource.Controllers
{
    [Area("HumanResource")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
