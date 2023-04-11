using ResumeProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class CategoryController : Controller
    {
        ResumeDBEntities db = new ResumeDBEntities();

        // GET: Category
        public ActionResult Index()
        {
            var values = db.TblCategories.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(TblCategory category)
        {
            db.TblCategories.Add(category);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int id)
        {
            var value = db.TblCategories.Find(id);
            db.TblCategories.Remove(value);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var value = db.TblCategories.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateCategory(TblCategory category)
        {
            var value = db.TblCategories.Find(category.CategoryID);
            value.CategoryName = category.CategoryName;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult GetMessageBySubject(int id)
        {
            var values = db.TblContacts.Where(x => x.Subject == id).ToList();
            return View(values);
        }
    }
}