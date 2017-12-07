using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TECH497_Final_Group_Project.Database;

namespace TECH497_Final_Group_Project.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            IDatabase db = DatabaseFactory.GetDatabase();
            var model =Enum.GetValues(typeof(Catagory)).Cast<Catagory>().ToDictionary(x => x,
                x => db.GetProjectsForCatagory(x));
            return View(model);
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult newproject()
        {
            ViewBag.hiddenId = "new";
            return View("EditProject", new Project
            {
                Category = Catagory.DragRacing,
                Description = "",
                Title = ""
            });
        }
        [HttpPost]
        public ActionResult editproject(Project p)
        {
            IDatabase db = DatabaseFactory.GetDatabase();
            string id = Request["hiddenId"];
            if(id == "new")
            {
                db.AddProject(p.Category, p.Title, p.Description);
            }
            return Redirect("~/Admin/Index");
        }
        [HttpGet]
        public ActionResult editimages(int id)
        {
            IDatabase db = DatabaseFactory.GetDatabase();
            return View("ViewImages", db.GetProject(id));
        }
        [HttpGet]
        public ActionResult addimage(int id)
        {
            return View("AddImage");
        }
        [HttpPost]
        [ActionName("addimage")]
        public ActionResult AddImagePost(int id)
        {
            var file = Request.Files[0];
            var description = Request["text"];
            DatabaseFactory.GetDatabase().AddImage(file, id, description, false);
            return Redirect("~/Admin/editimages/" + id);
        }
    }
}
