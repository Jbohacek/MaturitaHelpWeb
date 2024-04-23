using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.Database.Controllers
{
    [Area("Database")]
    public class MsSqlSecurityController : Controller
    {
        public IActionResult LoginAndUser()
        {
            return View();
        }

        public IActionResult Audit()
        {
            return View();
        }

        public IActionResult Backup()
        {
            return View();
        }

        public IActionResult Encryption()
        {
            return View();
        }
    }
}
