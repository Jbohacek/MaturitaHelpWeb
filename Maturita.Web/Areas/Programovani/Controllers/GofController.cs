using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.Programovani.Controllers
{
    [Area("Programovani")]
    public class GofController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Factory()
        {
            return View();
        }

        public IActionResult Singleton()
        {
            return View();
        }

        public IActionResult Command()
        {
            return View();
        }

        public IActionResult Observer()
        {
            return View();
        }

        public IActionResult Iterator()
        {
            return View();
        }

        public IActionResult State()
        {
            return View();
        }

        public IActionResult Decorator()
        {
            return View();
        }

        public IActionResult Memento()
        {
            return View();
        }

        public IActionResult Adapter()
        {
            return View();
        }
    }
}
