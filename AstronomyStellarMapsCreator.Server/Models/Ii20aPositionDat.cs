using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Ii20aPositionDat
{
    public int Id { get; set; }

    public int? MSeq { get; set; }

    public int? Seq { get; set; }

    public string? FSname { get; set; }

    public int? RahH { get; set; }

    public int? RamMin { get; set; }

    public double? RasS { get; set; }

    public string? De { get; set; }

    public int? DedDeg { get; set; }

    public int? DemArcmin { get; set; }

    public double? DesArcsec { get; set; }

    public string? NA1 { get; set; }

    public string? Sname { get; set; }

    public string? Name2 { get; set; }
}
