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
    public class BikeController : Controller
    {
        private DataContext db = new DataContext();

        //
        // GET: /Bike/

        public ActionResult Index()
        {
            return View(db.Bikes.ToList());
        }

        //
        // GET: /Bike/Details/5

        public ActionResult Details(int id = 0)
        {
            Bike bike = db.Bikes.Find(id);
            if (bike == null)
            {
                return HttpNotFound();
            }
            return View(bike);
        }

        //
        // GET: /Bike/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Bike/Create

        [HttpPost]
        public ActionResult Create(Bike bike)
        {
            if (ModelState.IsValid)
            {
                db.Bikes.Add(bike);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bike);
        }

        //
        // GET: /Bike/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Bike bike = db.Bikes.Find(id);
            if (bike == null)
            {
                return HttpNotFound();
            }
            return View(bike);
        }

        //
        // POST: /Bike/Edit/5

        [HttpPost]
        public ActionResult Edit(Bike bike)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bike).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bike);
        }

        //
        // GET: /Bike/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Bike bike = db.Bikes.Find(id);
            if (bike == null)
            {
                return HttpNotFound();
            }
            return View(bike);
        }

        //
        // POST: /Bike/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Bike bike = db.Bikes.Find(id);
            db.Bikes.Remove(bike);
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