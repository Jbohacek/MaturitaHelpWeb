using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.Cestina.Controllers
{
    [Area("Cestina")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
