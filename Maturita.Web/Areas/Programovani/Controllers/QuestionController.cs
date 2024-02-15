using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.Programovani.Controllers
{
    [Area("Programovani")]

    public class QuestionController : Controller
    {
        public IActionResult ProceduryFunkce()
        {
            return View();
        }

        public IActionResult GarbageCollector()
        {
            return View();
        }

        public IActionResult RidiciStruktury()
        {
            return View();
        }

        public IActionResult Rekurze()
        {
            return View();
        }

        public IActionResult PoleAKolekce()
        {
            return View();
        }

        public IActionResult Retezce()
        {
            return View();
        }

        public IActionResult DatoveStruktury()
        {
            return View();
        }

        public IActionResult SouboryASouborovySystem()
        {
            return View();
        }
    }
}
