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
             return Modele.MonModele.Emprunters.Include(p => p.IdEtatEmpruntNavigation).ToList();
        }

        public static List<EtatEmprunt> getListEtatEmprunts()
        {
            return Modele.MonModele.EtatEmprunts.ToList();
        }

        public static EtatEmprunt RecupererEtatEmprunt(int idE)
        {
            EtatEmprunt unEtatEmprunt = new EtatEmprunt();
            try
            {
                unEtatEmprunt = Modele.MonModele.EtatEmprunts.First(x => x.Id == idE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur");
            }
            return unEtatEmprunt;
        }

        public static Emprunter RecupererEmprunts(int Idressource, int Idemprunteur, int Idexemplaire, DateTime Datedebutemprunt)
        {
            Emprunter unEmprunt = new Emprunter();
            try
            {
                unEmprunt = Modele.MonModele.Emprunters.Where(x => x.Idressource == Idressource).Where(x => x.Idemprunteur == Idemprunteur).Where(x => x.Idexemplaire == Idexemplaire).Where(x => x.Datedebutemprunt == Datedebutemprunt).First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unEmprunt;
        }

        public static bool ProlongationDureeEmprunts(int Idressource, int Idemprunteur, int Idexemplaire, DateTime Datedebutemprunt, DateTime NouvelleDateRetour)
        {
            Emprunter unEmprunt;
            bool vretour = true;
            try
            {
                // récupération de la ressource à modifier
                unEmprunt = RecupererEmprunts(Idressource, Idemprunteur, Idexemplaire, Datedebutemprunt);

                // Calcul de la différence en jours
                TimeSpan difference = NouvelleDateRetour - unEmprunt.Dateretour;

                // Obtention du nombre total de jours
                int nouvelleDuree = difference.Days;

                // mise à jour des champs
                unEmprunt.Dateretour = NouvelleDateRetour;
                unEmprunt.Dureeemprunt = nouvelleDuree;

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
