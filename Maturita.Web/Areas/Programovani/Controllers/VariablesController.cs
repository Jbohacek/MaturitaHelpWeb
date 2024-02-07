using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.Programovani.Controllers
{
    [Area("Programovani")]
    public class VariablesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DataTypes()
        {
            return View();
        }

        public IActionResult NegativeSave()
        {
            return View();
        }

        public IActionResult DecimalNumbers()
        {
            return View();
        }

        public IActionResult ValueAndRefTypes()
        {
            return View();
        }

        public IActionResult ValidVariables()
        {
            return View();
        }

        public IActionResult EnumAndOperators()
        {
            return View();
        }
    }
}
