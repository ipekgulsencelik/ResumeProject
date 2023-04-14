using ResumeProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class ServiceController : Controller
    {
        ResumeDBEntities db = new ResumeDBEntities();

        // GET: Service
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }

        public PartialViewResult PartialServices()
        {
            var values = db.TblServices.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSolutions()
        {
            var values = db.TblSolutions.ToList();
            return PartialView(values);
        }
    }
}