using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EdsBikeRides.Models;
using EdsBikeRides.Repositories.Interfaces;

namespace EdsBikeRides.Repositories
{
    public class RideRepository : IRideRepository
    {
        
        public RideRepository()
        {

        }

        public void Add(Ride ride)
        {
            throw new NotImplementedException();
        }

        public void Update(Ride ride)
        {
            throw new NotImplementedException();
        }

        public void Remove(Ride ride)
        {
            throw new NotImplementedException();
        }

        public Ride GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ride> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}