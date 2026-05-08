using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Footge
{
    public int Id { get; set; }

    public int CatalogueId { get; set; }

    public byte[]? Footg5 { get; set; }

    public byte[]? Footg8 { get; set; }

    public virtual Catalogue Catalogue { get; set; } = null!;
}
