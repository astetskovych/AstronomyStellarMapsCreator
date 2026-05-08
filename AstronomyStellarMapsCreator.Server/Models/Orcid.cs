using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Orcid
{
    public int Id { get; set; }

    public int CatId { get; set; }

    public string? Orcid1 { get; set; }

    public virtual Cat Cat { get; set; } = null!;
}
