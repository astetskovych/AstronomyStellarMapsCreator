using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class CataloguesFile
{
    public int Id { get; set; }

    public int CatalogueId { get; set; }

    public string Name { get; set; } = null!;

    public int? Lrecl { get; set; }

    public int? Records { get; set; }

    public string? Explanations { get; set; }

    public int? ExtentionId { get; set; }

    public virtual Catalogue Catalogue { get; set; } = null!;

    public virtual ICollection<CatalogueField> CatalogueFields { get; set; } = new List<CatalogueField>();

    public virtual Extention? Extention { get; set; }
}
