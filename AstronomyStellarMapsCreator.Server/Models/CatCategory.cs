namespace AstronomyStellarMapsCreator.Server.Models;

public partial class CatCategory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Cat> Cats { get; set; } = new List<Cat>();
}
