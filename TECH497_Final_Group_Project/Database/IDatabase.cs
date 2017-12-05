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
        public string AltText { get; set; }
        public string URL { get; set; }
    }
    public class Project
    {
        public 
        public ImageDefinition MainImage { get; set; }
        public string Title { get; set; }
        public string Description { get;set; }
        public IEnumerable<ImageDefinition> Images { get; set; }
    }
    public interface IDatabase
    {
        Project GetProject(Catagory catagory, int ID);
        IEnumerable<Project> GetProjectsForCatagory(Catagory catagory);
        
    }
}
