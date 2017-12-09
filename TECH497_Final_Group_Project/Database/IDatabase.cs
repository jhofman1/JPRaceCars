using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TECH497_Final_Group_Project.Database
{
    public enum Catagory
    {
        DragRacing,
        RoadRacing,
        StreatRods, 
        Offroad,
        OtherProjects
    }
    public class ImageDefinition
    {
        public int Id { get; set; }
        public string AltText { get; set; }
        public string URL { get; set; }
        public string Desc { get; set; }
    }
    public class Project
    {
        public int Id { get; set; }
        public ImageDefinition MainImage { get; set; }
        public string Title { get; set; }
        public string Description { get;set; }
        public IEnumerable<ImageDefinition> Images { get; set; }
        public Catagory Category { get; set; }
    }
    public interface IDatabase
    {
        Project GetProject( int ID);
        IEnumerable<Project> GetProjectsForCatagory(Catagory catagory);
        void AddProject(Catagory catagory, string Title, string Description);
        void AddImage(HttpPostedFileBase file, int projectId, string altText, bool isMain);
        
    }
}
