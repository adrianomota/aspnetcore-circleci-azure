using System.Collections.Generic;
using System.Threading.Tasks;
using WorshopAspnetCore.Entities;

namespace WorshopAspnetCore.Repositories.Interfaces
{
    public interface ICityRepository
    {
        Task<IEnumerable<City>> Get();

        Task<City> GetById(int id);

        Task<IEnumerable<PointOfInterest>> GetPPointsOfInterestByCityId(int cityId);

        Task<IEnumerable<PointOfInterest>> GetPointsOfInterestByCityId(int cityId, int pointOfInterestId);
    }
}