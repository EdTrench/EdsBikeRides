using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EdsBikeRides.Models;
using EdsBikeRides.Repositories;
using EdsBikeRides.Repositories.Interfaces;

namespace EdsBikeRides.Controllers
{
    public class BikeController : Controller
    {
        IBikeRepository _bikeRepository = new BikeRepository(new DataContext());

        //
        // GET: /Bike/

        public ActionResult Index()
        {
            return View(_bikeRepository.GetAll());
        }

        //
        // GET: /Bike/Details/5

        public ActionResult Details(int id = 0)
        {
            var bike = _bikeRepository.GetById(id);
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
                _bikeRepository.Add(bike);
                return RedirectToAction("Index");
            }

            return View(bike);
        }

        //
        // GET: /Bike/Edit/5

        public ActionResult Edit(int id = 0)
        {
            var bike = _bikeRepository.GetById(id);
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
                _bikeRepository.Update(bike);
                return RedirectToAction("Index");
            }
            return View(bike);
        }

        //
        // GET: /Bike/Delete/5

        public ActionResult Delete(int id = 0)
        {
            var bike = _bikeRepository.GetById(id);
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
            var bike = _bikeRepository.GetById(id);
            _bikeRepository.Remove(bike);
            return RedirectToAction("Index");
        }
    }
}