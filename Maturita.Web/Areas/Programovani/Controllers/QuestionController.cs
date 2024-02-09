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
    }
}
