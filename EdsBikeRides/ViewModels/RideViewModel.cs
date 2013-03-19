using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EdsBikeRides.Models;

namespace EdsBikeRides.ViewModels
{
    public class RideViewModel
    {
        public Ride Ride { get; set; }
        public IEnumerable<SelectListItem> Bikes { get; set; }
    }
}