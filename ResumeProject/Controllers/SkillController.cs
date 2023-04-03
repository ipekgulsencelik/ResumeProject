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

        public ActionResult DeleteSkill(int id)
        {
            var value = db.TblSkills.Find(id);
            db.TblSkills.Remove(value);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = db.TblSkills.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSkill(TblSkill skill)
        {
            var value = db.TblSkills.Find(skill.SkillID);
            value.SkillTitle = skill.SkillTitle;
            value.SkillIcon = skill.SkillIcon;
            value.SkillDescription = skill.SkillDescription;
            db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}