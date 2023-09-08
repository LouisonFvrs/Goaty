using System;
using System.Collections.Generic;

namespace AP3_MEDIA.Entities;

public partial class Exemplaire
{
    public int Idressource { get; set; }

    public int Idexemplaire { get; set; }

    public int Idetat { get; set; }

    public DateOnly? Dateentree { get; set; }

    public virtual ICollection<Emprunter> Emprunters { get; set; } = new List<Emprunter>();

    public virtual Etat IdetatNavigation { get; set; } = null!;

    public virtual Ressource IdressourceNavigation { get; set; } = null!;
}
