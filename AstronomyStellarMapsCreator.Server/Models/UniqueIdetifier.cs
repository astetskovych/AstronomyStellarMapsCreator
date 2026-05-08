using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class UniqueIdetifier
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public int? No { get; set; }

    public string? SubNo { get; set; }

    public string? Abbreviation { get; set; }

    public int? JournalId { get; set; }

    public virtual Cat? Cat { get; set; }

    public virtual ICollection<CatalogueReference> CatalogueReferenceUniqueIdetifierMains { get; set; } = new List<CatalogueReference>();

    public virtual ICollection<CatalogueReference> CatalogueReferenceUniqueIdetifierRefs { get; set; } = new List<CatalogueReference>();

    public virtual ICollection<Catalogue> Catalogues { get; set; } = new List<Catalogue>();

    public virtual Category Category { get; set; } = null!;

    public virtual Journal? Journal { get; set; }

    public virtual ICollection<ObsoleteCatalogue> ObsoleteCatalogues { get; set; } = new List<ObsoleteCatalogue>();
}
