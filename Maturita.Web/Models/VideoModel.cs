namespace Maturita.Web.Models
{
    public class VideoModel
    {
        public string Path { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">~/Videos/... </param>
        /// <param name="link">Odkaz na video, kde se si to sebral</param>
        /// <param name="title">Nazev video (neni potreba)</param>
        public VideoModel(string path, string link, string title = "")
        {
            Path = path;
            Link = link;
            Title = title;
        }

        
    }
}
