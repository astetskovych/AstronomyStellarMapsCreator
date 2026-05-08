using System;
using System.Collections.Generic;

namespace AstronomyStellarMapsCreator.Server.Models;

public partial class CatsAuthor
{
    public int Id { get; set; }

    public int CatId { get; set; }

    public int AuthorId { get; set; }

    public virtual Author Author { get; set; } = null!;

    public virtual Cat Cat { get; set; } = null!;
}
