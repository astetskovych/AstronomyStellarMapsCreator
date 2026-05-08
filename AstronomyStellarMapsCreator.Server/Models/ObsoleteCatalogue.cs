using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class ObsoleteCatalogue
{
    public int Id { get; set; }

    public int? UniqueIdetifierId { get; set; }

    public int? NewUniqueIdetifierId { get; set; }

    public DateOnly? RemovedDate { get; set; }

    public virtual UniqueIdetifier? UniqueIdetifier { get; set; }
}
