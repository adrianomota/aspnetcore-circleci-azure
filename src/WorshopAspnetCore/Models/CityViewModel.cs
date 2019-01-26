using System;
using System.Collections.Generic;

namespace WorshopAspnetCore.Models
{
    public sealed class CityViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int NumberOfPointsOfInterest { get { return PointOfInterest.Count; } }
        public ICollection<PointOfInterestViewModel> PointOfInterest { get; set; }
    }
}