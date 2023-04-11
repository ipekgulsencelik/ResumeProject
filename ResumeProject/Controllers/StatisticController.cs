using ResumeProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class StatisticController : Controller
    {
        ResumeDBEntities db = new ResumeDBEntities();
        
        // GET: Statistic
        public ActionResult Index()
        {
            // ViewBag.skillCount = db.TblSkills.Count();
            ViewBag.requestCount = db.CountRequest().FirstOrDefault();
            ViewBag.technologyCount = db.TblTechnologies.Count();
            ViewBag.csharpValue = db.TblTechnologies.Where(x => x.TechnologyTitle == "C#").Select(y => y.TechnologyValue).FirstOrDefault();
            ViewBag.contactCount = db.TblContacts.Count();
            ViewBag.countThankSubject = db.TblContacts.Where(x => x.Subject == 1).Count();
            ViewBag.sumTechnologyValue = db.TblTechnologies.Sum(x => x.TechnologyValue);
            ViewBag.averageTechnologyValue = db.TblTechnologies.Average(x => x.TechnologyValue);
            ViewBag.GetByThirdID = db.TblSkills.Where(x => x.SkillID == 3).Select(y => y.SkillTitle).FirstOrDefault();
            ViewBag.maxTechnologyValue = db.TblTechnologies.Max(x => x.TechnologyValue);

            return View();
        }
    }
}