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
                Id = 1,
                Title = "1963 Tempest",
                Description = "This is a simple project you know basic stuff",
                Images = new List<ImageDefinition>
                {
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img1.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img2.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img3.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img4.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img5.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img6.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img7.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img8.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img9.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img10.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img11.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img12.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img13.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img14.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img15.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img16.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img17.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img18.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img19.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img20.jpg",
                        Desc = "This is a short description for this car."
                    },
                    new ImageDefinition
                    {
                        AltText = "1963 Tempest",
                        URL = "/proj-1963-Tempest/img21.jpg",
                        Desc = "This is a short description for this car."
                    }
                },
                MainImage = new ImageDefinition
                {
                    AltText = "1963 Tempest",
                    URL = "/proj-1963-Tempest/main.jpg",
                    Desc = "This is a short description for this car."
                }
            };
        }

        public IEnumerable<Project> GetProjectsForCatagory(Catagory catagory)
        {
            return new List<Project>{GetProject(0), GetProject(0), GetProject(0), GetProject(0), GetProject(0), GetProject(0) };
        }
    }
}