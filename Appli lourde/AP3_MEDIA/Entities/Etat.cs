using System;
using System.Collections.Generic;

namespace AP3_MEDIA.Entities;

public partial class Etat
{
    public int Idetat { get; set; }

    public string? Libelleetat { get; set; }

    public virtual ICollection<Exemplaire> Exemplaires { get; set; } = new List<Exemplaire>();
}
