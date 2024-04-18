using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.Database.Controllers
{
    [Area("Database")]
    public class SqlDataControlController : Controller
    {
        public IActionResult ImportTextElements()
        {
            return View();
        }
        public IActionResult ImportSSIS()
        {
            return View();
        }
        public IActionResult DataPartitioning()
        {
            return View();
        }
        public IActionResult LogShipping()
        {
            return View();
        }
        public IActionResult Restore()
        {
            return View();
        }
    }
}
