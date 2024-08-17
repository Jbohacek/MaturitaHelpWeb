using Maturita.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Controllers
{
    public class Video : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CarClips()
        {

            var pat = Path.GetFullPath("wwwroot") + @"\Videos\CarClips";
            
            var folderInfo = new DirectoryInfo(pat);

            List<VideoModel> videoModels = new List<VideoModel>();

            foreach (var video in folderInfo.GetFiles())
            {
                videoModels.Add(new VideoModel(@"CarClips\" + video.Name, @"\Videos\CarClips\" + video.Name, video.Name.Replace(".mp4","")));

            }
            
            return View(videoModels);
        }
    }
}
