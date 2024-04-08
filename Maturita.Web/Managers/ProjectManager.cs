using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Maturita.Web.Models.Data;

namespace Maturita.Web.Managers
{
    public class ProjectManager
    {
        public enum ProjectType
        {
            Prg,
            Dbs,
            Pvy
        }

        public const string Root = @"wwwroot\Projects";

        private const string PrgPath = @$"{Root}\PrgProjects.xml";
        private const string DbsPath = @$"{Root}\DbsProjects.xml";
        private const string PvyPath = @$"{Root}\PvyProjects.xml";

        public static void Save(List<ProjectModel> a, ProjectType type)
        {
            XmlSerializer serializer =
                new XmlSerializer(typeof(List<ProjectModel>));

            Directory.CreateDirectory("Projects");
            TextWriter writer = new StreamWriter(GetPathByType(type));

            serializer.Serialize(writer, a);

            writer.Close();
        }

        public static void Add(ProjectModel model)
        {
            var type = model.ProjectType;

            List<ProjectModel> list = Load(type);

            list.Add(model);

            Save(list, type);
        }

        private static List<ProjectModel> _prgProjects = new List<ProjectModel>();
        private static List<ProjectModel> _dbsProjects = new List<ProjectModel>();
        private static List<ProjectModel> _pvyProjects = new List<ProjectModel>();

        public static List<ProjectModel> Load(ProjectType type)
        {
            switch (type)
            {
                case ProjectType.Prg:
                    if (_prgProjects.Count > 0) return _prgProjects;
                    break;
                case ProjectType.Dbs:
                    if (_dbsProjects.Count > 0) return _dbsProjects;
                    break;
                case ProjectType.Pvy:
                    if (_pvyProjects.Count > 0) return _pvyProjects;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            string path = GetPathByType(type);

            XmlSerializer serializer = new XmlSerializer(typeof(List<ProjectModel>));

            if (!File.Exists(path))
            {
                return new List<ProjectModel>();
            }

            FileStream fs = new FileStream(path, FileMode.Open);

            List<ProjectModel>? ret = (List<ProjectModel>?)serializer.Deserialize(fs);

            if (ret == null)
            {
                return new List<ProjectModel>();
            }
            ret.ForEach(x => x.ProjectType = type);

            switch (type)
            {
                case ProjectType.Prg:
                    _prgProjects = ret;
                    break;
                case ProjectType.Dbs:
                    _dbsProjects = ret;
                    break;
                case ProjectType.Pvy:
                    _pvyProjects = ret;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            

            return ret;
        }

        private static string GetPathByType(ProjectType type)
        {
            switch (type)
            {
                case ProjectType.Prg:
                    return PrgPath;
                    break;
                case ProjectType.Dbs:
                    return DbsPath;
                    break;
                case ProjectType.Pvy:
                    return PvyPath;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public static void Inicialize()
        {
            var prgProjects = new List<ProjectModel>()
            {
                new ProjectModel()
                {
                    Category = "Forms",
                    Name = "Servisni formular",
                    Description = "Vytvořit servisni formulář",
                    FileExercise = "01-servisni-protokol.zip",
                    Difficulty = 3,
                    FileSolution = "ServisniProtokol.zip"
                },
                new ProjectModel()
                {
                    Category = "Forms",
                    Name = "Sbírka uloh",
                    Description = "Ulohy..",
                    FileExercise = "02-sbirka-uloh.zip",
                    Difficulty = 2
                },
                new ProjectModel()
                {
                    Category = "Asp",
                    Name = "e-shop",
                    Description = "vytvořit web e-shop",
                    FileExercise = "03-eshop.zip",
                    Difficulty = 4
                },
                new ProjectModel()
                {
                    Category = "Unit",
                    Name = "Unit testovani",
                    Description = "Vytvořit unit testy",
                    FileExercise = "04-unit-testy.zip",
                    Difficulty = 1
                },
                new ProjectModel()
                {
                    Category = "Forms",
                    Name = "Jízdní řád",
                    Description = "Vytvořit mhd jízdní řád",
                    FileExercise = "05-jizdni-rad.zip",
                    Difficulty = 4
                },
                new ProjectModel()
                {
                    Category = "Asp",
                    Name = "Online diskuze",
                    Description = "Vytvořit online diskuzi s uživately",
                    FileExercise = "06-online-diskuze.zip",
                    Difficulty = 2
                },
                new ProjectModel()
                {
                    Category = "Forms",
                    Name = "Graf",
                    Description = "Vytvořit posuvný graf",
                    FileExercise = "07-graf.zip",
                    Difficulty = 3
                },
                new ProjectModel()
                {
                    Category = "Asp",
                    Name = "Datatables",
                    Description = "Vytvořit asp tabulku CRUD",
                    FileExercise = "https://datatables.net/examples/api/select_row.html",
                    Difficulty = 2,
                    IsUrl = true
                },
                new ProjectModel()
                {
                    Category = "Forms",
                    Name = "Evidence známek",
                    Description = "Vytvořte program určený k práci s databází studentů",
                    FileExercise = "09-evidence-znamek.pdf",
                    Difficulty = 2
                },
                new ProjectModel()
                {
                    Category = "Asp",
                    Name = "Realitní web",
                    Description = "Vytvoř asp web na realitní makléře",
                    FileExercise = "10-realitni-server.pdf",
                    Difficulty = 5
                },
                new ProjectModel()
                {
                    Category = "Unit",
                    Name = "Regex ulohy 2",
                    Description = "Spln regexy",
                    FileExercise = "11-regex-ulohy.pdf",
                    Difficulty = 1
                },
                new ProjectModel()
                {
                    Category = "Forms",
                    Name = "Validace letenky",
                    Description = "Validuj letenku přes regex na formu",
                    FileExercise = "12-validace-letenky.pdf",
                    Difficulty = 2
                },
            };
            prgProjects.ForEach(x => x.ProjectType = ProjectType.Prg);


            var pvyProjects = new List<ProjectModel>()
            {

            };

            var dbsProjects = new List<ProjectModel>()
            {
                new ProjectModel()
                {
                    Category = "Mssql",
                    Name = "dbTrafika",
                    Description = "Tvorba databaze dbTrafika",
                    FileExercise = "dbTrafika.zip",
                    Difficulty = 2
                },
            };
            dbsProjects.ForEach(x => x.ProjectType = ProjectType.Dbs);

            Save(prgProjects, ProjectType.Prg);
            Save(pvyProjects, ProjectType.Pvy);
            Save(dbsProjects,ProjectType.Dbs);



        }
    }
}
