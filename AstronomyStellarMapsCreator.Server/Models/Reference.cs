using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Reference
{
    public int Id { get; set; }

    public int? CatalogueId { get; set; }

    public string? Reference1 { get; set; }

    public virtual Catalogue? Catalogue { get; set; }
}
