using System;
using System.Collections.Generic;

namespace AP3_MEDIA.Entities;

public partial class Commentaire
{
    public string? TextCom { get; set; }

    public int? NoteCom { get; set; }

    public DateOnly DateCom { get; set; }

    public int IdCom { get; set; }

    public virtual ICollection<Emprunter> Emprunters { get; set; } = new List<Emprunter>();
}
