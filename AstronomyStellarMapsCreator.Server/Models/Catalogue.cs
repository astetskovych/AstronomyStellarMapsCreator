using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Catalogue
{
    public int Id { get; set; }

    public int? UniqueIdetifierId { get; set; }

    public string Name { get; set; } = null!;

    public string? Author { get; set; }

    public int Year { get; set; }

    public string? FullName { get; set; }

    public string? Description { get; set; }

    public string? Abstract { get; set; }

    public DateOnly? CompileDate { get; set; }

    public virtual ICollection<Acknowledgement> Acknowledgements { get; set; } = new List<Acknowledgement>();

    public virtual ICollection<AdcKeyword> AdcKeywords { get; set; } = new List<AdcKeyword>();

    public virtual ICollection<AditionalFile> AditionalFiles { get; set; } = new List<AditionalFile>();

    public virtual ICollection<CatalogueField> CatalogueFields { get; set; } = new List<CatalogueField>();

    public virtual ICollection<CatalogueInsertionLog> CatalogueInsertionLogs { get; set; } = new List<CatalogueInsertionLog>();

    public virtual ICollection<CataloguesFile> CataloguesFiles { get; set; } = new List<CataloguesFile>();

    public virtual ICollection<Footge> Footges { get; set; } = new List<Footge>();

    public virtual ICollection<History> Histories { get; set; } = new List<History>();

    public virtual ICollection<Prov> Provs { get; set; } = new List<Prov>();

    public virtual ICollection<ReadMe> ReadMes { get; set; } = new List<ReadMe>();

    public virtual ICollection<Reference> References { get; set; } = new List<Reference>();

    public virtual UniqueIdetifier? UniqueIdetifier { get; set; }
}
