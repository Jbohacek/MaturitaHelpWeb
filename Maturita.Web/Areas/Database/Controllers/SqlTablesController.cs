using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.Database.Controllers
{
    [Area("Database")]
    public class SqlTablesController : Controller
    {
        public IActionResult Zakladnimodifikacedat()
        {
            return View();
        }

        public IActionResult Selects()
        {
            return View();
        }

        public IActionResult Views()
        {
            return View();
        }

        public IActionResult TemporaryTables()
        {
            return View();
        }

        public IActionResult ProcAndFunctions()
        {
            return View();
        }

        public IActionResult Triggers()
        {
            return View();
        }

        public IActionResult Cursors()
        {
            return View();
        }

        public IActionResult TokProgramu()
        {
            return View();
        }
    }
}
