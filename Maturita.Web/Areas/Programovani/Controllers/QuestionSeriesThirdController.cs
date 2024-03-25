using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.Programovani.Controllers
{
    [Area("Programovani")]
    public class QuestionSeriesThirdController : Controller
    {
        
        public IActionResult Databaze()
        {
            return View();
        }
    }
}
