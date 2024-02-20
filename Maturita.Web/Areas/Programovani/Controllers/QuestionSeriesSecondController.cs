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
    }
}
