using AstronomyStellarMapsCreator.Server.DTOs;

namespace AstronomyStellarMapsCreator.Server.Common
{
    public interface IRepository
    {
        IEnumerable<StarDTO> GetStars();
    }
}
