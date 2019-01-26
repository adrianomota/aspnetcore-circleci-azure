using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WorshopAspnetCore.Models;

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

        [HttpGet("{cityId}/pointsofinterest/{id}", Name = "GetPointOfInterest")]
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

        [HttpPost("{cityId}/pointsofinterest")]
        public IActionResult CreatePointOfInterest(string cityId, [FromBody] PointOfInterestCreation pointOfInterest)
        {
            if (pointOfInterest == null)
            {
                return BadRequest();
            }

            var city = CityDataStore.Current.Cities.FirstOrDefault(p => p.Id == new Guid(cityId));

            if (city == null)
            {
                return NotFound();
            }

            var newPointOfInterest = new PointOfInterestViewModel()
            {
                Id = Guid.NewGuid(),
                Name = pointOfInterest.Name,
                Description = pointOfInterest.Description
            };

            city.PointOfInterest.Add(newPointOfInterest);

            return CreatedAtRoute("GetPointOfInterest",
                new
                {
                    cityId = city.Id.ToString(),
                    id = newPointOfInterest.Id.ToString()
                }, newPointOfInterest);
        }
    }
}