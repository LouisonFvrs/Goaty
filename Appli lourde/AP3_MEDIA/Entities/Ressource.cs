using System;
using System.Collections.Generic;

namespace AP3_MEDIA.Entities;

public partial class Ressource
{
    public int Idressource { get; set; }

    public int Idcategorie { get; set; }

    public string Titre { get; set; } = null!;

    public string? Description { get; set; }

    public string? Image { get; set; }

    public int? Anneesortie { get; set; }

    public string? Isbn { get; set; }

    public string? Langue { get; set; }

    public virtual ICollection<Exemplaire> Exemplaires { get; set; } = new List<Exemplaire>();

    public virtual Categorie IdcategorieNavigation { get; set; } = null!;
}
