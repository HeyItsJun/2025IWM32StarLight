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
    public class ExcursionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Excursions
        public ActionResult Index()
        {
            return View(db.Excursions.ToList());
        }

        // GET: Excursions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Excursion excursion = db.Excursions.Find(id);
            if (excursion == null)
            {
                return HttpNotFound();
            }
            return View(excursion);
        }

        // GET: Excursions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Excursions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ExcursionId,City_Village,Province,AutonumusCommunity,Country,Route,Payment,Agency,Type,Duration,Price,PhotoVideo,DateRange")] Excursion excursion)
        {
            if (ModelState.IsValid)
            {
                db.Excursions.Add(excursion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(excursion);
        }

        // GET: Excursions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Excursion excursion = db.Excursions.Find(id);
            if (excursion == null)
            {
                return HttpNotFound();
            }
            return View(excursion);
        }

        // POST: Excursions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ExcursionId,City_Village,Province,AutonumusCommunity,Country,Route,Payment,Agency,Type,Duration,Price,PhotoVideo,DateRange")] Excursion excursion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(excursion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(excursion);
        }

        // GET: Excursions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Excursion excursion = db.Excursions.Find(id);
            if (excursion == null)
            {
                return HttpNotFound();
            }
            return View(excursion);
        }

        // POST: Excursions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Excursion excursion = db.Excursions.Find(id);
            db.Excursions.Remove(excursion);
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
