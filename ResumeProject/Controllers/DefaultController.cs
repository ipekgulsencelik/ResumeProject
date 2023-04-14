using System.Linq;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class DefaultController : Controller
    {
        ResumeDBEntities db = new ResumeDBEntities();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.TblProfiles.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialServices()
        {
            var values = db.TblServices.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialFeaturedSkills()
        {
            var values = db.TblTechnologies.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialChoose()
        {
            return PartialView();
        }

        public PartialViewResult PartialStats()
        {
            ViewBag.skillCount = db.TblSkills.Count();
            ViewBag.serviceCount = db.TblServices.Count();
            ViewBag.averageTechnologyValue = db.TblTechnologies.Average(x => x.TechnologyValue);
            ViewBag.happyCustomer = 38;

            return PartialView();
        }

        public PartialViewResult PartialBanner()
        {
            return PartialView();
        }

        public PartialViewResult PartialPortfolio()
        {
            var values = db.TblProjects.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialBrands()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
    }
}