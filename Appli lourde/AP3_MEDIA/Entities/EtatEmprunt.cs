using System;
using System.Collections.Generic;

namespace AP3_MEDIA.Entities;

public partial class EtatEmprunt
{
    public int Id { get; set; }

    public string LibEtat { get; set; } = null!;

    public virtual ICollection<Emprunter> Emprunters { get; set; } = new List<Emprunter>();
}
