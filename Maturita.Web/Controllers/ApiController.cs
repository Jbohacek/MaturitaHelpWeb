using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Maturita.Web.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        public IActionResult Data()
        {
            return new JsonResult(
                new { IsSucces = "Ahoj, tohle je testovaci api" }
                );
        }
    }
}
