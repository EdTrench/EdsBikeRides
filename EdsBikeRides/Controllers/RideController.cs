using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EdsBikeRides.Models;

namespace EdsBikeRides.Controllers
{
    public class RideController : Controller
    {
        private DataContext db = new DataContext();

        //
        // GET: /Ride/

        public ActionResult Index()
        {
            return View(db.Rides.ToList());
        }

        //
        // GET: /Ride/Details/5

        public ActionResult Details(int id = 0)
        {
            Ride ride = db.Rides.Find(id);
            if (ride == null)
            {
                return HttpNotFound();
            }
            return View(ride);
        }

        //
        // GET: /Ride/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Ride/Create

        [HttpPost]
        public ActionResult Create(Ride ride)
        {
            if (ModelState.IsValid)
            {
                db.Rides.Add(ride);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ride);
        }

        //
        // GET: /Ride/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Ride ride = db.Rides.Find(id);
            if (ride == null)
            {
                return HttpNotFound();
            }
            return View(ride);
        }

        //
        // POST: /Ride/Edit/5

        [HttpPost]
        public ActionResult Edit(Ride ride)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ride).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ride);
        }

        //
        // GET: /Ride/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Ride ride = db.Rides.Find(id);
            if (ride == null)
            {
                return HttpNotFound();
            }
            return View(ride);
        }

        //
        // POST: /Ride/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Ride ride = db.Rides.Find(id);
            db.Rides.Remove(ride);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}