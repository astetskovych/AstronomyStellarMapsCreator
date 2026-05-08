using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Acronym
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<CatsAcronym> CatsAcronyms { get; set; } = new List<CatsAcronym>();
}
