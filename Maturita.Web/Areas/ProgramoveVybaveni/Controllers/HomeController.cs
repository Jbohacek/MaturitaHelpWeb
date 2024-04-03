using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.ProgramoveVybaveni.Controllers
{
    [Area("ProgramoveVybaveni")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
