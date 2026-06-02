namespace AstronomyStellarMapsCreator.Server.Common
{
    public class Repository : IRepository
    {
        public readonly Astro280326Context _context;
        public Repository(Astro280326Context context)
        {
            _context = context;
        }
        public async Task<IEnumerable<StarDTO>> GetCelestialObjectsAsync()
        {
            var stars = await _context.I40CatalogDats.Select(s => new StarDTO
            {
                Id = s.Id,
                RA = (double)(s.RahH + s.RamMin / 60.0 + s.RasS / 3600.0),
                Dec = s.De.Trim() == "-" 
                    ? (-1)*(double)(s.DedDeg + s.DemArcmin / 60.0 + s.DesArcsec / 3600.0)
                    : (double)(s.DedDeg + s.DemArcmin / 60.0 + s.DesArcsec / 3600.0),
                Mag = s.VmagMag ?? 100,
            }).ToListAsync();

            return stars;
        }

        public async Task<I40CatalogDat> GetCelestialObjectAsync(int id)
        {
            return await _context.I40CatalogDats.Where(s => s.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<CatDTO>> GetCatsAsync()
        {
            return await _context.Cats.Select(c => new CatDTO
            {
                Id = c.Id,
                UniqueIdetifierId = c.UniqueIdetifierId,
                Name = c.Name,
                Records = c.Records
            }).ToListAsync();
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategoriesAsync()
        {
            return await _context.Categories.Select(c => new CategoryDTO
            {
                Id = c.Id,
                Name = c.Description
            }).ToListAsync();
        }
    }
}
