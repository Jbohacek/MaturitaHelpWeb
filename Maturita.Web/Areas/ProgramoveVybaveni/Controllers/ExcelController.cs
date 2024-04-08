using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.ProgramoveVybaveni.Controllers
{
    [Area("ProgramoveVybaveni")]
    public class ExcelController : Controller
    {
        public IActionResult Obecne()
        {
            return View();
        }
    }
}
