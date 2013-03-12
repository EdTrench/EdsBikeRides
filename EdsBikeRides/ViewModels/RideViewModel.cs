using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EdsBikeRides.Models;

namespace EdsBikeRides.ViewModels
{
    public class RideViewModel
    {
        public Ride Ride { get; set; }
        public IEnumerable<Bike> Bikes {get; set;}
    }
}