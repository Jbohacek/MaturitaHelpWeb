using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.ProgramoveVybaveni.Controllers
{
    [Area("ProgramoveVybaveni")]
    public class MicrosoftAppsController : Controller
    {
        public IActionResult Word()
        {
            return View();
        }
    }
}
