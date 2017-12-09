using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TECH497_Final_Group_Project.Models;
using TECH497_Final_Group_Project.Database;

namespace TECH497_Final_Group_Project.Controllers
{
    public class HomeController : Controller
    {

        IDatabase database = DatabaseFactory.GetDatabase();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TermsOfService()
        {
            return View();
        }

        public ActionResult DragRacing()
        {
            ProjectsListModel projectsListModel = new ProjectsListModel();
            IEnumerable<Project> list = database.GetProjectsForCatagory(Catagory.DragRacing);
            projectsListModel.projectsList = list;
            return View(projectsListModel);
        }

        public ActionResult StreetRods()
        {
            ProjectsListModel projectsListModel = new ProjectsListModel();
            IEnumerable<Project> list = database.GetProjectsForCatagory(Catagory.StreatRods);
            projectsListModel.projectsList = list;
            return View(projectsListModel);
        }

        public ActionResult RoadRacing()
        {
            ProjectsListModel projectsListModel = new ProjectsListModel();
            IEnumerable<Project> list = database.GetProjectsForCatagory(Catagory.RoadRacing);
            projectsListModel.projectsList = list;
            return View(projectsListModel);
        }

        public ActionResult ProjectDetailPage(int projectId)
        {
            Project project = database.GetProject(projectId);
            ProjectModel model = new ProjectModel();
            model.project = project;
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}