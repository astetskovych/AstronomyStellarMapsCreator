namespace AstronomyStellarMapsCreator.Server.Common
{
    public interface IRepository
    {
        Task<IEnumerable<StarDTO>> GetCelestialObjectsAsync();
        Task<I40CatalogDat> GetCelestialObjectAsync(int id);
        Task<IEnumerable<CatDTO>> GetCatsAsync();

        Task<IEnumerable<CategoryDTO>> GetCategoriesAsync();
    }
}
