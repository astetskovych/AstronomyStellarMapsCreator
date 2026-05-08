using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class CatalogueField
{
    public int Id { get; set; }

    public int CatalogueId { get; set; }

    public int CatalogueFileId { get; set; }

    public int StartByte { get; set; }

    public int EndByte { get; set; }

    public int FormatId { get; set; }

    public double FormatPrecision { get; set; }

    public int UnitId { get; set; }

    public string Label { get; set; } = null!;

    public string? Explanations { get; set; }

    public string? Note { get; set; }

    public virtual Catalogue Catalogue { get; set; } = null!;

    public virtual CataloguesFile CatalogueFile { get; set; } = null!;

    public virtual Format Format { get; set; } = null!;

    public virtual Unit Unit { get; set; } = null!;
}
