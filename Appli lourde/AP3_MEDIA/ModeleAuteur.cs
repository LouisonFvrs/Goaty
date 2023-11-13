using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP3_MEDIA.Entities;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AP3_MEDIA
{
    internal class ModeleAuteur
    {

        /// <summary>
        /// Fonction qui retourne la liste de toutes les catégories
        /// </summary>
        /// <returns>Liste</returns>
        public static List<Auteur> getListAuteurs()
        {
            return Modele.MonModele.Auteurs.ToList();
        }
    }
}
