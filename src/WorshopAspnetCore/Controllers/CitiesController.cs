using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WorshopAspnetCore.Repositories.Interfaces;

namespace WorshopAspnetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : Controller
    {
        private readonly ICityRepository _cityRepository;

        public CitiesController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var ret = await _cityRepository.Get();

            return Ok(ret);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GeCity(int id)
        {
            //var ret = CityDataStore.Current.Cities.FirstOrDefault(p => p.Id == new Guid(id));
            var ret = await _cityRepository.GetById(id);

            if (ret == null)
            {
                return NotFound();
            }

            return Ok(ret);
        }
    }
}