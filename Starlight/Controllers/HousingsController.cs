using Microsoft.AspNet.Identity;
using Starlight.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Starlight.Controllers
{
    [Authorize]
    public class HousingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Housings
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();
            var userHousing = db.Housings.Where(p => p.UserId == currentUserId).ToList();
            return View(userHousing);
        }

        // GET: Housings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Housing housing = db.Housings.Find(id);
            string currentUserId = User.Identity?.GetUserId();
            if ((housing.UserId != currentUserId) || (housing == null))
            {
                return HttpNotFound();
            }
            return View(housing);
        }

        // GET: Housings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Housings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HousingId,Name,City_Village,Province,AutonumusCommunity,Country,Type,Description,Parking,Pool,SportsFacility,ChildrenFacility,Photo_Video")] Housing housing)
        {
            string currentUserId = User.Identity.GetUserId();
            housing.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.Housings.Add(housing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(housing);
        }

        // GET: Housings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Housing housing = db.Housings.Find(id);
            string currentUserId = User.Identity?.GetUserId();
            if ((housing.UserId != currentUserId) || (housing == null))
            {
                return HttpNotFound();
            }
            return View(housing);
        }

        // POST: Housings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HousingId,Name,City_Village,Province,AutonumusCommunity,Country,Type,Description,Parking,Pool,SportsFacility,ChildrenFacility,Photo_Video")] Housing housing)
        {
            string currentUserId = User.Identity.GetUserId();
            housing.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.Entry(housing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(housing);
        }

        // GET: Housings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Housing housing = db.Housings.Find(id);
            string currentUserId = User.Identity?.GetUserId();
            if ((housing.UserId != currentUserId) || (housing == null))
            {
                return HttpNotFound();
            }
            return View(housing);
        }

        // POST: Housings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Housing housing = db.Housings.Find(id);
            db.Housings.Remove(housing);
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
