using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class CatsAcronym
{
    public int Id { get; set; }

    public int CatId { get; set; }

    public int AcronymId { get; set; }

    public virtual Acronym Acronym { get; set; } = null!;

    public virtual Cat Cat { get; set; } = null!;
}
