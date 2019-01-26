using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace WorshopAspnetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var ret = CityDataStore.Current.Cities;
            return Ok(ret);
        }

        [HttpGet("{id}")]
        public IActionResult GeCity(string id)
        {
            var ret = CityDataStore.Current.Cities.FirstOrDefault(p => p.Id == new Guid(id));

            if (ret == null)
            {
                return NotFound();
            }

            return Ok(ret);
        }
    }
}