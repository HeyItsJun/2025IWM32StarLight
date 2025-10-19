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
    public class AmusementParkController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AmusementPark
        public ActionResult Index()
        {
            return View(db.AmusementParks.ToList());
        }

        // GET: AmusementPark/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AmusementPark amusementPark = db.AmusementParks.Find(id);
            if (amusementPark == null)
            {
                return HttpNotFound();
            }
            return View(amusementPark);
        }

        // GET: AmusementPark/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AmusementPark/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AmusementParkId,Name,TypeAmusementPark,City_Village,Province,AutonumusCommunity,Country,MinPrice,MaxPrice,Photo_Video")] AmusementPark amusementPark)
        {
            if (ModelState.IsValid)
            {
                db.AmusementParks.Add(amusementPark);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(amusementPark);
        }

        // GET: AmusementPark/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AmusementPark amusementPark = db.AmusementParks.Find(id);
            if (amusementPark == null)
            {
                return HttpNotFound();
            }
            return View(amusementPark);
        }

        // POST: AmusementPark/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AmusementParkId,Name,TypeAmusementPark,City_Village,Province,AutonumusCommunity,Country,MinPrice,MaxPrice,Photo_Video")] AmusementPark amusementPark)
        {
            if (ModelState.IsValid)
            {
                db.Entry(amusementPark).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(amusementPark);
        }

        // GET: AmusementPark/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AmusementPark amusementPark = db.AmusementParks.Find(id);
            if (amusementPark == null)
            {
                return HttpNotFound();
            }
            return View(amusementPark);
        }

        // POST: AmusementPark/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AmusementPark amusementPark = db.AmusementParks.Find(id);
            db.AmusementParks.Remove(amusementPark);
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
