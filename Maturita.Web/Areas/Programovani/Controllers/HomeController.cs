using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.Programovani.Controllers
{
    [Area("Programovani")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
