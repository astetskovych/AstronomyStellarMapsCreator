using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Adsid
{
    public int Id { get; set; }

    public int CatId { get; set; }

    public string? Adsid1 { get; set; }

    public virtual Cat Cat { get; set; } = null!;
}
