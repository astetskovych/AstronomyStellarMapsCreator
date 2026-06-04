using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Cat
{
    public int Id { get; set; }

    public int? UniqueIdetifierId { get; set; }

    public string Name { get; set; } = null!;

    public int? YCat { get; set; }

    public double? SizeKb { get; set; }

    public int? Records { get; set; }

    public DateOnly? DateAdded { get; set; }

    public DateOnly? DateVizieR { get; set; }

    public string? Title { get; set; }

    public int? Popular { get; set; }

    public int? Announced { get; set; }

    public string? Ignored { get; set; }

    public string? Cite { get; set; }

    public int? CatCategoryId { get; set; }

    public virtual ICollection<Adsid> Adsids { get; set; } = new List<Adsid>();

    public virtual ICollection<BibCode> BibCodes { get; set; } = new List<BibCode>();

    public virtual CatCategory? CatCategory { get; set; }

    public virtual ICollection<CatFile> CatFiles { get; set; } = new List<CatFile>();

    public virtual ICollection<CatsAcronym> CatsAcronyms { get; set; } = new List<CatsAcronym>();

    public virtual ICollection<CatsAuthor> CatsAuthors { get; set; } = new List<CatsAuthor>();

    public virtual ICollection<CatsKeyword> CatsKeywords { get; set; } = new List<CatsKeyword>();

    public virtual ICollection<CatsMedia> CatsMedia { get; set; } = new List<CatsMedia>();

    public virtual ICollection<CatsStatus> CatsStatuses { get; set; } = new List<CatsStatus>();

    public virtual ICollection<CatscServer> CatscServers { get; set; } = new List<CatscServer>();

    public virtual ICollection<Content> Contents { get; set; } = new List<Content>();

    public virtual ICollection<Orcid> Orcids { get; set; } = new List<Orcid>();

    public virtual ICollection<QProgram> QPrograms { get; set; } = new List<QProgram>();

    public virtual ICollection<Ref> Refs { get; set; } = new List<Ref>();

    public virtual ICollection<Remark> Remarks { get; set; } = new List<Remark>();

    public virtual ICollection<Source> Sources { get; set; } = new List<Source>();

    public virtual UniqueIdetifier? UniqueIdetifier { get; set; }
}
