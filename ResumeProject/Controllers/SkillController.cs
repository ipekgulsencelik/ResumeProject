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
    }
}