using ResumeProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class ProjectController : Controller
    {
        ResumeDBEntities db = new ResumeDBEntities();

        // GET: Project
        public ActionResult Index()
        {
            var values = db.TblProjects.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProject(TblProject project)
        {
            db.TblProjects.Add(project);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteProject(int id)
        {
            var value = db.TblProjects.Find(id);
            db.TblProjects.Remove(value);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var value = db.TblProjects.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateProject(TblProject project)
        {
            var value = db.TblProjects.Find(project.ProjectID);
            value.ProjectTitle = project.ProjectTitle;
            value.ProjectDescription = project.ProjectDescription;
            value.ProjectImageUrl = project.ProjectImageUrl;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}