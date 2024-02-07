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
            foreach (var link in SourcesLink.Where(link => !link.Contains("https",StringComparison.CurrentCulture) && link != String.Empty))
            {
                if (link.Substring(0, 1) == "-")
                {
                    continue;
                } 
                throw new Exception(
                    $"Link {link} neobsahuje https, tudiž je považovaný jako nebezpečný. SSL certifikát vyžaduje přitomnost jen https linků");
            }

            return SourcesLink.Select(x =>
            {
                if (x.Length > 0)
                {
                    if (x.Substring(0, 1) == "-")
                    {
                        return x.Substring(1);
                    }
                }
                return x;
            }).ToList();

            
        }


    }
}
