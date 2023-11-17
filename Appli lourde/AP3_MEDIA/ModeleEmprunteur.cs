using AP3_MEDIA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_MEDIA
{
    internal class ModeleEmprunteur
    {
        public static List<Emprunteur> getListEmprunteurs()
        {
            return Modele.MonModele.Emprunteurs.ToList();
        }

        public static Emprunteur RecupererEmprunteur(string login)
        {
            Emprunteur unEmprunteur = new Emprunteur();
            try
            {
                unEmprunteur = Modele.MonModele.Emprunteurs.First(x => x.Emailemprunteur == login);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur login ou mot de passe");
            }
            return unEmprunteur;
        }
    }
}
