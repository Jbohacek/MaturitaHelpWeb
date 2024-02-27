using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.Programovani.Controllers
{
    [Area("Programovani")]
    public class QuestionSeriesSecondController : Controller
    {
        public IActionResult ZakladyOOP()
        {
            return View();
        }

        public IActionResult DedicnostOOP()
        {
            return View();
        }

        public IActionResult PokrocilePrvkyOOP()
        {
            return View();
        }

        public IActionResult UML()
        {
            return View();
        }

        public IActionResult FormBasic()
        {
            return View();
        }

        public IActionResult FormAdvance()
        {
            return View();
        }
    }
}
