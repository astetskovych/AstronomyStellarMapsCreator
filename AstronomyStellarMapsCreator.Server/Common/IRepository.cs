namespace AstronomyStellarMapsCreator.Server.Common
{
    public interface IRepository
    {
        IEnumerable<StarDTO> GetStars();
        I40CatalogDat GetStar(int id);
    }
}
