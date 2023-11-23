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

        public static Emprunteur RecupererEmprunteurLogin(string login)
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

        public static Emprunteur RecupererEmprunteurId(int id)
        {
            Emprunteur unEmprunteur = new Emprunteur();
            try
            {
                unEmprunteur = Modele.MonModele.Emprunteurs.First(x => x.Idemprunteur == id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur");
            }
            return unEmprunteur;
        }

        public static bool ArchiverEmprunteur(int id)
        {
            Emprunteur unEmprunteur;
            bool vretour = true;
            try
            {
                unEmprunteur = RecupererEmprunteurId(id);

                // mise à jour des champs
                unEmprunteur.ArchiverEmprunteur = true;
                Modele.MonModele.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
    }
}
