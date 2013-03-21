using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EdsBikeRides.Models;
using EdsBikeRides.Repositories.Interfaces;

namespace EdsBikeRides.Repositories
{
    public class BikeRepository : IBikeRepository
    {
        private DataContext _context;

        public BikeRepository(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException("unitOfOwrk");

            _context = unitOfWork as DataContext;
        }

        public void Add(Bike bike)
        {
           _context.Bikes.Add(bike);
           _context.Save();
        }

        public void Update(Bike bike)
        {
            _context.Entry(bike).State = System.Data.EntityState.Modified;
            _context.Save();
        }

        public void Remove(Bike bike)
        {
            _context.Bikes.Remove(bike);
            _context.Save();
        }

        public Bike GetById(int id)
        {
            return _context.Bikes.Where(c => c.Id == id).Single();
        }

        public IEnumerable<Bike> GetAll()
        {
            return _context.Bikes;
        }
    }
}