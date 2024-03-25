using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Controllers
{
    public class Video : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
