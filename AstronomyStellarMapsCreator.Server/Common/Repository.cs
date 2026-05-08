using AstronomyStellarMapsCreator.Server.DTOs;
using AstronomyStellarMapsCreator.Server.Models;

namespace AstronomyStellarMapsCreator.Server.Common
{
    public class Repository : IRepository
    {
        public readonly Astro280326Context _context;
        public Repository(Astro280326Context context)
        {
            _context = context;
        }
        public IEnumerable<StarDTO> GetStars()
        {
            var stars = _context.I40CatalogDats.Select(s => new StarDTO
            {
                Id = s.Id,
                RA = (double)(s.RahH + s.RamMin / 60.0 + s.RasS / 3600.0),
                Dec = s.De.Trim() == "-" 
                    ? (-1)*(double)(s.DedDeg + s.DemArcmin / 60.0 + s.DesArcsec / 3600.0)
                    : (double)(s.DedDeg + s.DemArcmin / 60.0 + s.DesArcsec / 3600.0),
                Mag = s.VmagMag ?? 100,
            }).ToList();

            return stars;
        }
    }
}
