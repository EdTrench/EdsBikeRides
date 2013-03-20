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
        DataContext _context = new DataContext();

        public BikeRepository(DataContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            _context = context;
        }

        public void Add(Bike bike)
        {
           _context.Bikes.Add(bike);
        }

        public void Update(Bike bike)
        {
            throw new NotImplementedException();
        }

        public void Remove(Bike bike)
        {
            _context.Bikes.Remove(bike);
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