using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EdsBikeRides.Models;
using EdsBikeRides.Repositories.Interfaces;

//test

namespace EdsBikeRides.Repositories
{
    public class RideRepository : IRideRepository
    {
        private DataContext _context;
        
        public RideRepository(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentException("unitOfWork");
            }

            _context = unitOfWork as DataContext;
        }

        public void Add(Ride ride)
        {
            _context.Rides.Add(ride);
            _context.Save();
        }

        public void Update(Ride ride)
        {
            _context.Entry(ride).State = System.Data.EntityState.Modified;
            _context.Save();
        }

        public void Remove(Ride ride)
        {
            _context.Rides.Remove(ride);
            _context.Save();
        }

        public Ride GetById(int id)
        {
            return _context.Rides.Where(c => c.Id == id).Single();
        }

        public IEnumerable<Ride> GetAll()
        {
            return _context.Rides;
        }
    }
}