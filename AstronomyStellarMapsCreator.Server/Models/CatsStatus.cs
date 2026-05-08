using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class CatsStatus
{
    public int Id { get; set; }

    public int? CatId { get; set; }

    public int? StatusId { get; set; }

    public virtual Cat? Cat { get; set; }

    public virtual Status? Status { get; set; }
}
