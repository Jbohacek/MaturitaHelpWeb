using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.Programovani.Controllers
{
    [Area("Programovani")]
    public class QuestionSeriesThirdController : Controller
    {
        //21
        public IActionResult Databaze()
        {
            return View();
        }


        //22
        public IActionResult TeorieTestovani()
        {
            return Json("pokus");
        }

        public IActionResult UnitTesty()
        {
            return View();
        }
    }
}
