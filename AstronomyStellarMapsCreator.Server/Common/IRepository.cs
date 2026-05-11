using AstronomyStellarMapsCreator.Server.DTOs;
using AstronomyStellarMapsCreator.Server.Models;

namespace AstronomyStellarMapsCreator.Server.Common
{
    public interface IRepository
    {
        IEnumerable<StarDTO> GetStars();

        I40CatalogDat GetStar(int id);
    }
}
