using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class Media
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CatsMedia> CatsMedia { get; set; } = new List<CatsMedia>();
}
