using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TECH497_Final_Group_Project.Database
{
    public class SillyDatabase : IDatabase
    {
        public Project GetImagesForProjects(Catagory catagory, int ID)
        {
            return new Project {
                Description = "This is a simple project you know basic stuff",
                images = new List<ImageDefinition>
                {
                    new ImageDefinition
                    {
                        AltText = "example",
                        URL = "example.jpg"
                    }
                },
                MainImage = new ImageDefinition
                {
                    AltText = "example2",
                    URL = "example2.jpg"
                }
            };
        }

        public IEnumerable<Project> GetProjectsForCatagory(Catagory catagory)
        {
            return new List<Project>{GetImagesForProjects(0, 0)};
        }
    }
}