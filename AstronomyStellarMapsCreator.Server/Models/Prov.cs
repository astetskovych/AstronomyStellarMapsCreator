using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Prov
{
    public int Id { get; set; }

    public int? CatalogueId { get; set; }

    public string? ProvenanceJson { get; set; }

    public string? ProvenanceRdf { get; set; }

    public string? ProvenanceTxt { get; set; }

    public byte[]? ProvenancePng { get; set; }

    public virtual Catalogue? Catalogue { get; set; }
}
