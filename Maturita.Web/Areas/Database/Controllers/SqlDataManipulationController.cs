using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.Database.Controllers
{
    [Area("Database")]
    public class SqlDataManipulationController : Controller
    {
        public IActionResult ImportExportTextElements()
        {
            return View();
        }
        public IActionResult ImportExportSsis()
        {
            return View();
        }
    }
}
