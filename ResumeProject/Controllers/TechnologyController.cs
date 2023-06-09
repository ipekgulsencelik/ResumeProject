﻿using ResumeProject.Models;
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

        [HttpGet]
        public ActionResult AddTechnology()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTechnology(TblTechnology technology)
        {
            db.TblTechnologies.Add(technology);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteTechnology(int id)
        {
            var value = db.TblTechnologies.Find(id);
            db.TblTechnologies.Remove(value);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTechnology(int id)
        {
            var value = db.TblTechnologies.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateTechnology(TblTechnology technology)
        {
            var value = db.TblTechnologies.Find(technology.TechnologyID);
            value.TechnologyTitle = technology.TechnologyTitle;
            value.TechnologyValue = technology.TechnologyValue;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}