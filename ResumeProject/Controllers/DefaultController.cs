using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PartialHead()
        {
            return PartialView();
        }

        public ActionResult PartialHeader()
        {
            return PartialView();
        }

        public ActionResult PartialAbout()
        {
            return PartialView();
        }

        public ActionResult PartialServices()
        {
            return PartialView();
        }

        public ActionResult PartialFeaturedSkills()
        {
            return PartialView();
        }

        public ActionResult PartialChoose()
        {
            return PartialView();
        }

        public ActionResult PartialStats()
        {
            return PartialView();
        }

        public ActionResult PartialBanner()
        {
            return PartialView();
        }

        public ActionResult PartialPortfolio()
        {
            return PartialView();
        }

        public ActionResult PartialBrands()
        {
            return PartialView();
        }

        public ActionResult PartialFooter()
        {
            return PartialView();
        }

        public ActionResult PartialScripts()
        {
            return PartialView();
        }
    }
}