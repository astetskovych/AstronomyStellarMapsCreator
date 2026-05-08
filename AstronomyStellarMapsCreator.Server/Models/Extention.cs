using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Extention
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AditionalFile> AditionalFiles { get; set; } = new List<AditionalFile>();

    public virtual ICollection<CatFile> CatFiles { get; set; } = new List<CatFile>();

    public virtual ICollection<CataloguesFile> CataloguesFiles { get; set; } = new List<CataloguesFile>();
}
