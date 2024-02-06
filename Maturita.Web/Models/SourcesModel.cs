namespace Maturita.Web.Models
{
    public class SourcesModel
    {
        private List<string> SourcesLink { get; set; }


        public SourcesModel(params string[] links)
        {
            SourcesLink = new List<string>();
            SourcesLink.InsertRange(0, links);
        }

        public void Add(string link) => SourcesLink.Add(link);

        public List<string> GetLinks()
        {
            foreach (var link in SourcesLink.Where(link => !link.Contains("https")))
            {
                throw new Exception(
                    $"Link {link} neobsahuje https, tudiž je považovaný jako nebezpečný. SSL certifikát vyžaduje přitomnost jen https linků");
            }

            return SourcesLink;
        }


    }
}
