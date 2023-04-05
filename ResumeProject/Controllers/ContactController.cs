using ResumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}