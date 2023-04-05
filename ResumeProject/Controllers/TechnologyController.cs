using ResumeProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class TechnologyController : Controller
    {
        ResumeDBEntities db = new ResumeDBEntities();

        // GET: Technology
        public ActionResult Index()
        {
            var values = db.TblTechnologies.ToList();
            return View(values);
        }
    }
}