using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class ReadMe
{
    public int Id { get; set; }

    public int? CatalogueId { get; set; }

    public string? ReadMeFile { get; set; }

    public virtual Catalogue? Catalogue { get; set; }
}
