using System;
using System.Collections.Generic;

namespace AP3_MEDIA.Entities;

public partial class Categorie
{
    public int Idcategorie { get; set; }

    public string? Libellecategorie { get; set; }

    public virtual ICollection<Ressource> Ressources { get; set; } = new List<Ressource>();
}
