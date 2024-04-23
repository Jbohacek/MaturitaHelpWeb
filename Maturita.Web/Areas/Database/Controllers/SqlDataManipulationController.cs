using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.Database.Controllers
{
    [Area("Database")]
    public class SqlDataManipulationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
