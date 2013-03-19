using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EdsBikeRides.Models
{
    public class Ride
    {
        public int Id { get; set; }
        public DateTime RideDate { get; set; }
        public String Name { get; set; }
        public virtual Bike Bike { get; set; }
    }
}