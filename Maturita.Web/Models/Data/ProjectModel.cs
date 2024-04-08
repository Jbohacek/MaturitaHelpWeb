using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Maturita.Web.Managers;

namespace Maturita.Web.Models.Data
{
    public class ProjectModel
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Difficulty { get; set; }
        public string Category { get; set; } = null!;
        public string FileExercise { get; set; } = null!;
        public string? FileSolution { get; set; }
        public bool IsUrl { get; set; } = false;
        [XmlIgnore] public ProjectManager.ProjectType ProjectType { get; set; }

        public string GetPathExercise() => Path.Combine(ProjectType.ToString(), "Exercises", FileExercise);
        public string GetPathSolution() => Path.Combine(ProjectType.ToString(), "Solutions", FileSolution);
        public bool HasSolution() => FileSolution != null;
    }
}
