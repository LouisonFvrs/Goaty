using System;
using System.Collections.Generic;

namespace AP3_MEDIA.Entities;

public partial class Auteur
{
    public int IdAuteur { get; set; }

    public string NomAuteur { get; set; } = null!;

    public virtual ICollection<Ressource> IdRessources { get; set; } = new List<Ressource>();
}
