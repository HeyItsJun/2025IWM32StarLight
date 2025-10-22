using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Starlight.Models;

namespace Starlight.Controllers
{
    [AllowAnonymous]
    public class ThemeParksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ThemeParks
        public ActionResult Index()
        {
            return View(db.ThemeParks.ToList());
        }

        // GET: ThemeParks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThemePark themePark = db.ThemeParks.Find(id);
            if (themePark == null)
            {
                return HttpNotFound();
            }
            return View(themePark);
        }

        // GET: ThemeParks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThemeParks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ThemeParkId,Name,TypeThemePark,City_Village,Province,AutonumusCommunity,Country,MinPrice,MaxPrice,Photo_Video")] ThemePark themePark)
        {
            if (ModelState.IsValid)
            {
                db.ThemeParks.Add(themePark);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(themePark);
        }

        // GET: ThemeParks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThemePark themePark = db.ThemeParks.Find(id);
            if (themePark == null)
            {
                return HttpNotFound();
            }
            return View(themePark);
        }

        // POST: ThemeParks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ThemeParkId,Name,TypeThemePark,City_Village,Province,AutonumusCommunity,Country,MinPrice,MaxPrice,Photo_Video")] ThemePark themePark)
        {
            if (ModelState.IsValid)
            {
                db.Entry(themePark).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(themePark);
        }

        // GET: ThemeParks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThemePark themePark = db.ThemeParks.Find(id);
            if (themePark == null)
            {
                return HttpNotFound();
            }
            return View(themePark);
        }

        // POST: ThemeParks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ThemePark themePark = db.ThemeParks.Find(id);
            db.ThemeParks.Remove(themePark);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
