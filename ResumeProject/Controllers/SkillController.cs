using ResumeProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class SkillController : Controller
    {
        ResumeDBEntities db = new ResumeDBEntities();

        // GET: Skill
        public ActionResult Index()
        {
            var values = db.TblSkills.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSkill(TblSkill skill)
        {
            db.TblSkills.Add(skill);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}