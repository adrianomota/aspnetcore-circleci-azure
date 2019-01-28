using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorshopAspnetCore.Entities;
using WorshopAspnetCore.Repositories.Interfaces;

namespace WorshopAspnetCore.Repositories.CityRepository
{
    public class CityRepository : ICityRepository
    {
        private readonly CityInfoContext _context;

        public CityRepository(CityInfoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<City>> Get()
        {
            return await _context.City.ToListAsync();
        }

        public async Task<City> GetById(int id)
        {
            return await _context.City.FindAsync(id);
        }

        public async Task<IEnumerable<PointOfInterest>> GetPPointsOfInterestByCityId(int cityId)
        {
            var ret = await _context.City.FindAsync(cityId);

            return ret.PointsOfInterest;
        }

        public async Task<IEnumerable<PointOfInterest>> GetPointsOfInterestByCityId(int cityId, int pointOfInterestId)
        {
            return await _context.PointOfInterest.Where(po => po.Id == pointOfInterestId)
                                                 .Where(po => po.CityId == cityId)
                                                 .ToListAsync();
        }
    }
}