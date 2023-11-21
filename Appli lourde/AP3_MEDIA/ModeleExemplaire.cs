using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP3_MEDIA.Entities;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AP3_MEDIA
{
    public static class ModeleExemplaire
    {
    

        /// <summary>
        /// Fonction qui retourne la liste des Exemplaires
        /// </summary>
        /// <returns>Liste</returns>
        public static List<Exemplaire> getListExemplaires()
        {
            return Modele.MonModele.Exemplaires.ToList();
        }

        // retourne la liste des exemplaires selon la ressource sélectionnée 
        public static List<Exemplaire> listeExemplairesParRessource(int idR)
        {
            List<Exemplaire> lesEx = Modele.MonModele.Exemplaires.Where(p => p.Idressource == idR).Include(p => p.IdetatNavigation).ToList();
            return lesEx;
        }


        public static int ObtenirDernierIdExemplaire()
        {
            int dernierIdExemplaire = Modele.MonModele.Exemplaires.Max(p => (int?)p.Idexemplaire) ?? 0;
            return dernierIdExemplaire;
        }


        // Renvoie vrai si l'exemplaire a été ajouté à la base de donnée 
        public static bool AjouterExemplaire(int idR, int idL, int idEtat, DateOnly dateEntree)
        {
            Exemplaire unExemplaire;
            bool vretour = true;
            try
            {
                // ajout dans la table Exemplaire
                unExemplaire = new Exemplaire();

                unExemplaire.Idressource = idR;
                unExemplaire.Idexemplaire = ObtenirDernierIdExemplaire() + 1;
                unExemplaire.Idetat = idEtat;
                unExemplaire.Dateentree = dateEntree;
                unExemplaire.ArchiverExem = false;
                unExemplaire.IdLocalisation = idL;

                Modele.MonModele.Exemplaires.Add(unExemplaire);
                Modele.MonModele.SaveChanges();
                MessageBox.Show("L'exemplaire a été ajouté");

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static List<Etat> getListEtats()
        {
            return Modele.MonModele.Etats.ToList();
        }

        public static List<Localisation> getListLocalisation()
        {
            return Modele.MonModele.Localisations.ToList();
        }

        public static Exemplaire RecupererExemplaire(int id)
        {
            Exemplaire unExemplaire = new Exemplaire();
            try
            {
                unExemplaire = Modele.MonModele.Exemplaires.First(x => x.Idexemplaire == id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur");
            }
            return unExemplaire;
        }
    }
}
