using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
namespace TECH497_Final_Group_Project.Database
{
    public class SillyDatabase : IDatabase
    {
        public void AddImage(HttpPostedFileBase file, int projectId, string altText, bool isMain)
        {
            throw new NotImplementedException();
        }

        public void AddProject(Catagory catagory, string Title, string Description)
        {
            throw new NotImplementedException();
        }

        public Project GetProject( int ID)
        {
            return new Project {
                Description = "This is a simple project you know basic stuff",
                Images = new List<ImageDefinition>
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
            return new List<Project>{GetProject( 0)};
        }
    }
}