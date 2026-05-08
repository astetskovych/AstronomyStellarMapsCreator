using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class CatsMedia
{
    public int Id { get; set; }

    public int CatId { get; set; }

    public int MediaId { get; set; }

    public virtual Cat Cat { get; set; } = null!;

    public virtual Media Media { get; set; } = null!;
}
