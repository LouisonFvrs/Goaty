using System;
using System.Collections.Generic;

namespace AP3_MEDIA.Entities;

public partial class Emprunteur
{
    public int Idemprunteur { get; set; }

    public string Nomemprunteur { get; set; } = null!;

    public string Prenomemprunteur { get; set; } = null!;

    public DateOnly Datenaissance { get; set; }

    public string? Emailemprunteur { get; set; }

    public string? Motpasseemprunteur { get; set; }

    public string? Telportable { get; set; }

    public int? Validationcompte { get; set; }

    public virtual ICollection<Emprunter> Emprunters { get; set; } = new List<Emprunter>();
}
