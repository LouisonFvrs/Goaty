using System;
using System.Collections.Generic;

namespace AP3_MEDIA.Entities;

public partial class Role
{
    public int IdRole { get; set; }

    public string Titre { get; set; } = null!;

    public virtual ICollection<Emprunteur> Emprunteurs { get; set; } = new List<Emprunteur>();
}
