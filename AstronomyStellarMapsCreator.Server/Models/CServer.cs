using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class CServer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CatscServer> CatscServers { get; set; } = new List<CatscServer>();
}
