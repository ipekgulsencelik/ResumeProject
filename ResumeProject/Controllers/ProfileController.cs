using ResumeProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class ProfileController : Controller
    {
        ResumeDBEntities db = new ResumeDBEntities();

        // GET: Profile
        public ActionResult Index()
        {
            var values = db.TblProfiles.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddProfile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProfile(TblProfile profile)
        {
            db.TblProfiles.Add(profile);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteProfile(int id)
        {
            var value = db.TblProfiles.Find(id);
            db.TblProfiles.Remove(value);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProfile(int id)
        {
            var value = db.TblProfiles.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateProfile(TblProfile profile)
        {
            var value = db.TblProfiles.Find(profile.ProfileID);
            value.ProfileTitle = profile.ProfileTitle;
            value.Name = profile.Name;
            value.ProfileDescription = profile.ProfileDescription;
            value.Mail = profile.Mail;
            value.Phone = profile.Phone;
            value.Address = profile.Address;
            value.SocialMedia1 = profile.SocialMedia1;
            value.SocialMedia2 = profile.SocialMedia2;
            value.SocialMedia3 = profile.SocialMedia3;
            value.SocialMedia4 = profile.SocialMedia4;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}