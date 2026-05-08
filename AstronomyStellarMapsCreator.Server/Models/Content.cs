using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Content
{
    public int ContentId { get; set; }

    public int? CatId { get; set; }

    public string? Name { get; set; }

    public virtual Cat? Cat { get; set; }
}
