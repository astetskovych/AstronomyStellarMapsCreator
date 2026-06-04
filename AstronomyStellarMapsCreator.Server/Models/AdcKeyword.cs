using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class AdcKeyword
{
    public int Id { get; set; }

    public int? CatalogueId { get; set; }

    public int? KeywordId { get; set; }

    public virtual Catalogue? Catalogue { get; set; }

    public virtual Keyword? Keyword { get; set; }
}
