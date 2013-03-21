using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EdsBikeRides.Models
{
    public class Bike
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime BoughtDate { get; set; }
        public float Weight { get; set; }
        public virtual ICollection<Ride> Rides { get; set; }
    }
}