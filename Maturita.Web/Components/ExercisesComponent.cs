using Maturita.Web.Managers;
using Maturita.Web.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace Maturita.Web.Components
{
    public class ExercisesComponent : ViewComponent
    {
        public IViewComponentResult Invoke(ProjectManager.ProjectType type)
        {
            var projects = ProjectManager.Load(type);

            List<IGrouping<string, ProjectModel>> retProj = projects.GroupBy(x => x.Category).ToList();

            return View(retProj);
        }
    }
}
