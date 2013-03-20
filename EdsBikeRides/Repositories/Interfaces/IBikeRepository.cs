using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdsBikeRides.Models;

namespace EdsBikeRides.Repositories.Interfaces
{
    public interface IBikeRepository
    {
        void Add(Bike bike);
        void Update(Bike bike);
        void Remove(Bike bike);
        Bike GetById(int id);
        IEnumerable<Bike> GetAll();
    }
}
