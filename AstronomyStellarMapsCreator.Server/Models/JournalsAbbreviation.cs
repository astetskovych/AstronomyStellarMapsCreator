using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class JournalsAbbreviation
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Title { get; set; }

    public virtual ICollection<Journal> Journals { get; set; } = new List<Journal>();
}
