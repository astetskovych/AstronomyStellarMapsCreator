namespace AstronomyStellarMapsCreator.Server.Common
{
    public interface IRepository
    {
        Task<IEnumerable<StarDTO>> GetCelestialObjectsAsync();
        Task<V50Catalog> GetCelestialObjectAsync(int id);
        Task<IEnumerable<CatDTO>> GetCatsAsync();
        Task<IEnumerable<CategoryDTO>> GetCategoriesAsync();
        Task<IEnumerable<CatDTO>> GetCatsFilteredAsync(string? name, int? categoryId, string? key);
    }
}
