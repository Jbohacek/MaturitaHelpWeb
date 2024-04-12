using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.ProgramoveVybaveni.Controllers
{
    [Area("ProgramoveVybaveni")]
    public class AccessController : Controller
    {
        public IActionResult TabulkyARelace()
        {
            return View();
        }

        public IActionResult Dotazy()
        {
            return View();
        }

        public IActionResult FunkceVDotazech()
        {
            return View();
        }

        public IActionResult Formulare()
        {
            return View();
        }

        public IActionResult Sestavy()
        {
            return View();
        }

        public IActionResult ImportExport()
        {
            return View();
        }
    }
}
