using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Keyword
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<AdcKeyword> AdcKeywords { get; set; } = new List<AdcKeyword>();

    public virtual ICollection<CatsKeyword> CatsKeywords { get; set; } = new List<CatsKeyword>();
}
