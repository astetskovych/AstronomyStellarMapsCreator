using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class CatsKeyword
{
    public int Id { get; set; }

    public int? CatId { get; set; }

    public int? KeywordId { get; set; }

    public virtual Cat? Cat { get; set; }

    public virtual Keyword? Keyword { get; set; }
}
