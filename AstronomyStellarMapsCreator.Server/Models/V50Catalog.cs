using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class V50Catalog
{
    public int Id { get; set; }

    public int? Hr { get; set; }

    public string? Name { get; set; }

    public string? Dm { get; set; }

    public int? Hd { get; set; }

    public int? Sao { get; set; }

    public int? Fk5 { get; set; }

    public string? Irflag { get; set; }

    public string? RIrflag { get; set; }

    public string? Multiple { get; set; }

    public string? Ads { get; set; }

    public string? Adscomp { get; set; }

    public string? VarId { get; set; }

    public int? Rah1900H { get; set; }

    public int? Ram1900Min { get; set; }

    public double? Ras1900S { get; set; }

    public string? De1900 { get; set; }

    public int? Ded1900Deg { get; set; }

    public int? Dem1900Arcmin { get; set; }

    public int? Des1900Arcsec { get; set; }

    public int? RahH { get; set; }

    public int? RamMin { get; set; }

    public double? RasS { get; set; }

    public string? De { get; set; }

    public int? DedDeg { get; set; }

    public int? DemArcmin { get; set; }

    public int? DesArcsec { get; set; }

    public double? GlonDeg { get; set; }

    public double? GlatDeg { get; set; }

    public double? VmagMag { get; set; }

    public string? NVmag { get; set; }

    public string? UVmag { get; set; }

    public double? BVMag { get; set; }

    public string? UBV { get; set; }

    public double? UBMag { get; set; }

    public string? UUB { get; set; }

    public double? RIMag { get; set; }

    public string? NRI { get; set; }

    public string? SpType { get; set; }

    public string? NSpType { get; set; }

    public double? PmRaArcsecYr { get; set; }

    public double? PmDeArcsecYr { get; set; }

    public string? NParallax { get; set; }

    public double? ParallaxArcsec { get; set; }

    public int? RadVelKmS { get; set; }

    public string? NRadVel { get; set; }

    public string? LRotVel { get; set; }

    public int? RotVelKmS { get; set; }

    public string? URotVel { get; set; }

    public double? DmagMag { get; set; }

    public double? SepArcsec { get; set; }

    public string? MultId { get; set; }

    public int? MultCnt { get; set; }

    public string? NoteFlag { get; set; }
}
