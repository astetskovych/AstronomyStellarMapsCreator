using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class CatalogueInsertionLog
{
    public int Id { get; set; }

    public int CatalogueId { get; set; }

    public bool? ResultOfInsertion { get; set; }

    public DateTime? Date { get; set; }

    public int? ProccessingTimeS { get; set; }

    public virtual Catalogue Catalogue { get; set; } = null!;
}
