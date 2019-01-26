using System;
using System.Collections.Generic;

namespace WorshopAspnetCore.Models
{
    public class CityViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int NumberOfPointsOfInterest { get { return PointOfInterest.Count; } }
        public ICollection<PointOfInterestViewModel> PointOfInterest { get; set; }
    }
}