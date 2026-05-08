using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class I42CatalogDat
{
    public int Id { get; set; }

    public int? Pfksz { get; set; }

    public string? Bd { get; set; }

    public int? Vmag01mag { get; set; }

    public string? SpType { get; set; }

    public int? RahH { get; set; }

    public int? RamMin { get; set; }

    public int? RamsMs { get; set; }

    public int? PmRa01msYr { get; set; }

    public int? EpRa001yr { get; set; }

    public int? ERamsMs { get; set; }

    public int? Fksz { get; set; }

    public string? De { get; set; }

    public int? DedDeg { get; set; }

    public int? DemArcmin { get; set; }

    public int? Decs10mas { get; set; }

    public int? PmDeMasYr { get; set; }

    public int? EpDe001yr { get; set; }

    public int? EDecs10mas { get; set; }

    public int? Gc { get; set; }

    public string? Note { get; set; }
}
