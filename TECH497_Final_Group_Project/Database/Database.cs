using LiteDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace TECH497_Final_Group_Project.Database
{
    public class DBImage
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string AltText { get; set; }
        public string Url { get; set; }
        public bool IsTitle { get; set; }
    }
    public class DBProject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Catagory Category { get; set; }
    }
    public class Database : IDatabase,IDisposable
    {
        LiteDatabase _db;
        LiteCollection<DBImage> _images;
        LiteCollection<DBProject> _projects;
        public Database()
        {
            _db = new LiteDatabase(HostingEnvironment.ApplicationPhysicalPath +"database.db");
            _images = _db.GetCollection<DBImage>();
            _projects = _db.GetCollection<DBProject>();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Project GetProject(int ID)
        {
            DBProject project = _projects.FindOne(x => x.Id == ID);
            return new Project
            {
                Title = project.Title,
                Id = project.Id,
                Description = project.Description,
                Images = _images.Find(y=>y.ProjectId == project.Id && !y.IsTitle).Select(DBImageToImage),
                MainImage = DBImageToImage(_images.FindOne(y => y.ProjectId == project.Id && y.IsTitle)),
            };
        }

        private ImageDefinition DBImageToImage(DBImage image)
        {
            if (image == null) return null;
            return new ImageDefinition
            {
                Id = image.Id,
                AltText = image.AltText,
                URL = image.Url
            };
        }
        public IEnumerable<Project> GetProjectsForCatagory(Catagory catagory)
        {
            return _projects.Find(x=>x.Category==catagory).Select(x=> new Project
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Images = null,
                MainImage = DBImageToImage(_images.FindOne(y=>y.ProjectId==x.Id))
            });
        }

        public void AddProject(Catagory catagory, string Title, string Description)
        {
            _projects.Insert(new DBProject
            {
                Category = catagory,
                Title = Title,
                Description = Description
            });
        }

        public void AddImage(HttpPostedFileBase file, int projectId, string altText, bool isMain)
        {
            string path = Path.Combine("/Images/", Guid.NewGuid().ToString() + Path.GetExtension(file.FileName));
            file.SaveAs(HostingEnvironment.ApplicationPhysicalPath + path);
            _images.Insert(new DBImage
            {
                IsTitle = isMain,
                AltText = altText,
                ProjectId = projectId,
                Url = path
            });
        }
    }
}