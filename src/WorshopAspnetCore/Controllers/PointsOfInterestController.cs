using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace WorshopAspnetCore.Controllers
{
    [Route("api/cities")]
    public class PointsOfInterestController : Controller
    {
        [HttpGet("{cityId}/pointsofinterest")]
        public IActionResult GetPointsOfInterest(string cityId)
        {
            var city = CityDataStore.Current.Cities.FirstOrDefault(p => p.Id == new Guid(cityId));

            if (city == null)
            {
                return NotFound();
            }

            return Ok(city.PointOfInterest);
        }

        [HttpGet("{cityId}/pointsofinterest/{id}")]
        public IActionResult GetPointOfInterest(string cityId, string id)
        {
            var city = CityDataStore.Current.Cities.FirstOrDefault(p => p.Id == new Guid(cityId));

            if (city == null)
            {
                return NotFound();
            }

            var pointOfInterest = city.PointOfInterest.FirstOrDefault(p => p.Id == new Guid(id));

            if (pointOfInterest == null)
            {
                return NotFound();
            }

            return Ok(pointOfInterest);
        }
    }
}