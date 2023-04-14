using ResumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class ContactController : Controller
    {
        ResumeDBEntities db = new ResumeDBEntities();

        // GET: Contact
        public ActionResult Index()
        {
            var values = db.TblContacts.ToList();
            return View(values);
        }

        public ActionResult DeleteContact(int id)
        {
            var value = db.TblContacts.Find(id);
            db.TblContacts.Remove(value);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SendMessage()
        {
            List<SelectListItem> values = (from x in db.TblCategories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();

            ViewBag.categories = values;

            return View();
        }

        [HttpPost]
        public ActionResult SendMessage(TblContact contact)
        {
            contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());

            db.TblContacts.Add(contact);
            db.SaveChanges();

            return RedirectToAction("Index", "Default");
        }

        public PartialViewResult PartialMap()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
    }
}