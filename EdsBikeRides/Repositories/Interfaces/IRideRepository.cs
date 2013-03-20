using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdsBikeRides.Models;

namespace EdsBikeRides.Repositories.Interfaces
{
    public interface IRideRepository
    {
        void Add(Ride ride);
        void Update(Ride ride);
        void Remove(Ride ride);
        Ride GetById(int id);
        IEnumerable<Ride> GetAll();
    }
}
