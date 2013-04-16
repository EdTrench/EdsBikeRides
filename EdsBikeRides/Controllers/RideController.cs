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
using EdsBikeRides.ViewModels;

namespace EdsBikeRides.Controllers
{
    public class RideController : Controller
    {
        private DataContext context = new DataContext();
        RideRepository _rideRepository;
        BikeRepository _bikeRepository;

        public RideController()
        {
            _rideRepository = new RideRepository(context as IUnitOfWork);
            _bikeRepository = new BikeRepository(context as IUnitOfWork);
        }

        //
        // GET: /Ride/

        public ActionResult Index()
        {
            return View(_rideRepository.GetAll());
        }

        //
        // GET: /Ride/Details/5

        public ActionResult Details(int id = 0)
        {
            Ride ride = _rideRepository.GetById(id);
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
                _rideRepository.Add(ride);
                return RedirectToAction("Index");
            }

            return View(ride);
        }

        //
        // GET: /Ride/Edit/5

        public ActionResult Edit(int id = 0)
        {
            RideViewModel rideViewModel = new RideViewModel();
            rideViewModel.Ride = _rideRepository.GetById(id);

            IEnumerable<SelectListItem> selectList =
                from bikes in _bikeRepository.GetAll()
                select new SelectListItem
                {
                    Selected = (bikes.Id == rideViewModel.Ride.Bike.Id),
                    Text = bikes.Name,
                    Value = bikes.Id.ToString()
                };
            rideViewModel.Bikes = selectList;

            if (rideViewModel == null)
            {
                return HttpNotFound();
            }
            return View(rideViewModel);
        }

       //  POST: /Ride/Edit/5

        [HttpPost]
        public ActionResult Edit(Ride ride)
        {
            if (ModelState.IsValid)
            {
                ride.Bike = _bikeRepository.GetById(ride.Bike.Id);
                _rideRepository.Update(ride);
                return RedirectToAction("Index");
            }
            return View(ride);
        }

        
        // GET: /Ride/Delete/5

        public ActionResult Delete(int id = 0)
        {
            var ride =_rideRepository.GetById(id);
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
            var ride = _rideRepository.GetById(id);
            _rideRepository.Remove(ride);
            return RedirectToAction("Index");
        }
    }
}