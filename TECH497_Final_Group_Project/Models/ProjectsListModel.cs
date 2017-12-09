using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TECH497_Final_Group_Project.Database;

namespace TECH497_Final_Group_Project.Models
{
    public class ProjectsListModel
    {
        public IEnumerable<Project> projectsList;

        public Project projectSelected { get; set; }
    }
}