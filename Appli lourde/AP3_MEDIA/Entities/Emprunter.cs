using System;
using System.Collections.Generic;

namespace AP3_MEDIA.Entities;

public partial class Emprunter
{
    public int Idemprunteur { get; set; }

    public int Idressource { get; set; }

    public int Idexemplaire { get; set; }

    public DateTime Datedebutemprunt { get; set; }

    public int Dureeemprunt { get; set; }

    public DateTime Dateretour { get; set; }

    public bool ArchiverEmprunter { get; set; }

    public int? IdCom { get; set; }

    public int IdEtatEmprunt { get; set; }

    public virtual Exemplaire Id { get; set; } = null!;

    public virtual Commentaire? IdComNavigation { get; set; }

    public virtual EtatEmprunt IdEtatEmpruntNavigation { get; set; } = null!;

    public virtual Emprunteur IdemprunteurNavigation { get; set; } = null!;
}
