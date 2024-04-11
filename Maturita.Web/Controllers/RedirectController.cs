using Maturita.Web.Models.Functional;
using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Controllers
{
    public class RedirectController : Controller
    {
        public IActionResult Index(string url, string desc, string backUrl)
        {
            RedirectModel redirectModel = new RedirectModel()
            {
                Url = url,
                Description = desc,
                BackUrl = backUrl
            };

            return View("_RedirectSite", redirectModel);
        }
    }
}
