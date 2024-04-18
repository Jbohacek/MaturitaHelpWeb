using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.Database.Controllers
{
    [Area("Database")]
    public class DatabaseCreateController : Controller
    {

        public IActionResult Design()
        {
            return View();
        }

        public IActionResult Creation()
        {
            return View();
        }
    }
}
