using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class I40CatalogDat
{
    public int Id { get; set; }

    public int? Seq { get; set; }

    public string? Dm { get; set; }

    public string? Sp { get; set; }

    public string? NumSp { get; set; }

    public double? VmagMag { get; set; }

    public string? NVmag { get; set; }

    public double? ObsMagMag { get; set; }

    public int? RahH { get; set; }

    public int? RamMin { get; set; }

    public double? RasS { get; set; }

    public double? PmRaSA { get; set; }

    public string? De { get; set; }

    public int? DedDeg { get; set; }

    public int? DemArcmin { get; set; }

    public double? DesArcsec { get; set; }

    public double? PmDeArcsecA { get; set; }

    public int? ORas { get; set; }

    public int? ODes { get; set; }

    public int? EpRa1900001a { get; set; }

    public int? EpDe1900001a { get; set; }

    public string? Note { get; set; }
}
