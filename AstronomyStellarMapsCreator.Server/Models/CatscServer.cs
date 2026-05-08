using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class CatscServer
{
    public int Id { get; set; }

    public int CatId { get; set; }

    public int CServerId { get; set; }

    public virtual CServer CServer { get; set; } = null!;

    public virtual Cat Cat { get; set; } = null!;
}
