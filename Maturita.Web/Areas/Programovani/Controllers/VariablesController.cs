﻿using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.Programovani.Controllers
{
    [Area("Programovani")]
    public class VariablesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
