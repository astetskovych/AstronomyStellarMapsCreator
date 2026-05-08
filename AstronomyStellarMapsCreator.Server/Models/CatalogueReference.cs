using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class CatalogueReference
{
    public int Id { get; set; }

    public int UniqueIdetifierMainId { get; set; }

    public int? UniqueIdetifierRefId { get; set; }

    public virtual UniqueIdetifier UniqueIdetifierMain { get; set; } = null!;

    public virtual UniqueIdetifier? UniqueIdetifierRef { get; set; }
}
