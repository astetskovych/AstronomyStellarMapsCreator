using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Journal
{
    public int Id { get; set; }

    public int JournalAbbrId { get; set; }

    public int? Volume { get; set; }

    public string? VolumeSuffix { get; set; }

    public string? SpecialVolume { get; set; }

    public string? FirstPagePrefix { get; set; }

    public int? FirstPageNo { get; set; }

    public virtual JournalsAbbreviation JournalAbbr { get; set; } = null!;

    public virtual ICollection<UniqueIdetifier> UniqueIdetifiers { get; set; } = new List<UniqueIdetifier>();
}
