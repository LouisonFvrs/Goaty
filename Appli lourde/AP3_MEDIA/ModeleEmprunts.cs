using AP3_MEDIA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_MEDIA
{
    internal class ModeleEmprunts
    {
        public static List<Emprunter> getListEmprunts()
        {
             return Modele.MonModele.Emprunters.Include(p => p.IdEtatEmpruntNavigation).Where(p => p.IdEtatEmpruntNavigation.LibEtat != "Rendu").ToList();
        }
    }
}
