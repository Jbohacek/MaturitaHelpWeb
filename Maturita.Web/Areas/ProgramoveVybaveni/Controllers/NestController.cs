using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.ProgramoveVybaveni.Controllers
{
    [Area("ProgramoveVybaveni")]
    public class NestController : Controller
    {
        public IActionResult Instalace()
        {
            return View();
        }
    }
}
