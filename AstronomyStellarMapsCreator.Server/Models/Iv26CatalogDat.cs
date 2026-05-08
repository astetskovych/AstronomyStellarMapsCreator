using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Iv26CatalogDat
{
    public int Id { get; set; }

    public int? Seq { get; set; }

    public string? NSeq { get; set; }

    public int? Ma { get; set; }

    public string? NMa { get; set; }

    public int? Dm { get; set; }

    public double? Xpos { get; set; }

    public double? Ypos { get; set; }

    public int? DXpos30mas { get; set; }

    public string? UDXpos { get; set; }

    public int? DYpos30mas { get; set; }

    public string? UDYpos { get; set; }

    public string? ORa { get; set; }

    public int? ORamArcmin { get; set; }

    public double? ORasArcsec { get; set; }

    public string? ODe { get; set; }

    public int? ODemArcmin { get; set; }

    public double? ODesArcsec { get; set; }

    public int? S { get; set; }

    public string? NA1 { get; set; }

    public int? S2 { get; set; }

    public string? US { get; set; }

    public string? NS { get; set; }

    public double? GrMag { get; set; }

    public double? DRaArcsec { get; set; }

    public string? UDRa { get; set; }

    public double? DDeArcsec { get; set; }

    public string? UDDe { get; set; }
}
