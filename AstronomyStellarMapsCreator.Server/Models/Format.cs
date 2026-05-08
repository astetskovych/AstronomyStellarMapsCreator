using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Format
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string SqlType { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<CatalogueField> CatalogueFields { get; set; } = new List<CatalogueField>();
}
