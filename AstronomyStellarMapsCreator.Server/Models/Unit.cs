using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Unit
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? CiUnit { get; set; }

    public string? Dim { get; set; }

    public virtual ICollection<CatalogueField> CatalogueFields { get; set; } = new List<CatalogueField>();
}
