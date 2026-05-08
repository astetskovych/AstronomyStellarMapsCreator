using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class CatFile
{
    public int Id { get; set; }

    public int? CatId { get; set; }

    public string Name { get; set; } = null!;

    public int? ExtentionId { get; set; }

    public virtual Cat? Cat { get; set; }

    public virtual Extention? Extention { get; set; }
}
