using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Areas.Programovani.Controllers
{
    [Area("Programovani")]
    public class AlgorithmsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BubbleSort()
        {
            return View();
        }

        public IActionResult SelectionSort()
        {
            return View();
        }

        public IActionResult InsertionSort()
        {
            return View();
        }

        public IActionResult QuickSort()
        {
            return View();
        }

        public IActionResult MergeSort()
        {
            return View();
        }

        public IActionResult HeapSort()
        {
            return View();
        }
    }
}
