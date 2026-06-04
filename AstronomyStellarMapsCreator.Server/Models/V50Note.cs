using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class V50Note
{
    public int Id { get; set; }

    public int? Hr { get; set; }

    public int? Count { get; set; }

    public string? Category { get; set; }

    public string? Remark { get; set; }
}
