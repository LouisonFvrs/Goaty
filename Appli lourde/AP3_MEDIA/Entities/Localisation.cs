using System;
using System.Collections.Generic;

namespace AP3_MEDIA.Entities;

public partial class Localisation
{
    public int IdLocalisation { get; set; }

    public string VilleLocalisation { get; set; } = null!;

    public string AdresseLocalisation { get; set; } = null!;

    public virtual ICollection<Emprunteur> Emprunteurs { get; set; } = new List<Emprunteur>();

    public virtual ICollection<Exemplaire> Exemplaires { get; set; } = new List<Exemplaire>();
}
