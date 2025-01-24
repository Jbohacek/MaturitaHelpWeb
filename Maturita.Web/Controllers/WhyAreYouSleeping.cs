using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Controllers
{
    public class WhyAreYouSleeping : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;


        public WhyAreYouSleeping(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Score()
        {
            int jakub = 0;
            int kamila = 0;

            string filePath = GetWwwRootPath();

            try
            {
                List<string> lines = System.IO.File.ReadAllLines(filePath).ToList();

                foreach (var line in lines)
                {
                    string[] split = line.Split(';');
                    int score = Convert.ToInt32(split[1]);

                    if (split[0] == "Jakub")
                    {
                        jakub = score;
                    }
                    else
                    {
                        kamila = score;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            ViewBag.Jakub = jakub;
            ViewBag.Kamila = kamila;
            

            return View();
        }

        // 0 - +
        // 1 - -

        // 0 - Jakub
        // 1 - Kamila


        public IActionResult ChangeScore(bool addMinus, bool who)
        {
            int jakub = 0;
            int kamila = 0;

            string filePath = GetWwwRootPath();

            try
            {
                List<string> lines = System.IO.File.ReadAllLines(filePath).ToList();

                foreach (var line in lines)
                {
                    string[] split = line.Split(';');
                    int score = Convert.ToInt32(split[1]);

                    if (split[0] == "Jakub")
                    {
                        jakub = score;
                    }
                    else
                    {
                        kamila = score;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            if (!addMinus)
            {
                if (who)
                {
                    jakub++;
                }
                else
                {
                    kamila++;
                }
            }
            else
            {
                if (who)
                {
                    jakub--;
                }
                else
                {
                    kamila--;
                }
            }


            try
            {
                string output = $"Jakub;{jakub}\nKamila;{kamila}";
                System.IO.File.WriteAllText(filePath,output);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return RedirectToAction("Score");
        }

        private string GetWwwRootPath()
        {
            // Get the wwwroot path
            string wwwRootPath = _webHostEnvironment.WebRootPath;

            // Example: Combine wwwroot with a specific file path
            string filePath = Path.Combine(wwwRootPath, "SleepScore.txt");

            return filePath;
        }

    }
}
