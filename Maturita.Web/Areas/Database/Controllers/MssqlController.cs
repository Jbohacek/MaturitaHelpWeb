using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.Database.Controllers
{
    [Area("Database")]
    public class MssqlController : Controller
    {
        public IActionResult Replication()
        {
            return View();
        }

        public IActionResult Mirroring()
        {
            return View();
        }
    }
}
