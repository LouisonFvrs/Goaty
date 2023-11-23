using AP3_MEDIA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_MEDIA
{
    internal class ModeleLocalisation
    {
        /// <summary>
        /// Fonction qui retourne la liste de toutes les auteurs
        /// </summary>
        /// <returns>Liste</returns>
        public static List<Localisation> getListLocalisations()
        {
            return Modele.MonModele.Localisations.ToList();
        }


        /// <summary>
        /// Fonction qui retourne vrai si l'ajout d'un auteur est possible
        /// </summary>
        /// <param name="libelle"></param>
        /// <returns>bool</returns>
        public static bool AjoutLocalisation(string ville, string adresse)
        {
            Localisation uneVille;
            bool vretour = true;
            try
            {
                // ajout dans la table Auteur

                uneVille = new Localisation();
                uneVille.VilleLocalisation = ville;
                uneVille.AdresseLocalisation = adresse;

                Modele.MonModele.Localisations.Add(uneVille);
                Modele.MonModele.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        /// <summary>
        /// Fonction qui retourne vrai si la modification d'une catégorie (son libellé) est possible à partir de son identifiant passé en paramètre
        /// </summary>
        /// <param name="idC">identifiant de la catégorie à modifier</param>
        /// <param name="libelle"></param>
        /// <returns>bool</returns>
        public static bool ModifierLocalisation(int idL, string ville, string adresse)
        {
            Localisation uneVille;
            bool vretour = true;
            try
            {
                // récupération de la categorie à modifier
                uneVille = RecupererLocalisation(idL);
                uneVille.VilleLocalisation = ville;
                uneVille.AdresseLocalisation = adresse;

                Modele.MonModele.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        /// <summary>
        /// Fonction qui retourne vrai si la suppression d'une catégorie est possible à partir de son identifiant passé en paramètre
        /// </summary>
        /// <param name="idC">identifiant de la catégorie à supprimer</param>
        /// <returns>bool</returns>
        public static bool SupprimerLocalisation(int idL)
        {
            Localisation uneVille;
            bool vretour = true;
            try
            {
                // récupération de la categorie à supprimer
                uneVille = RecupererLocalisation(idL);
                Modele.MonModele.Localisations.Remove(uneVille);

                Modele.MonModele.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show("Suppression impossible");
            }
            return vretour;
        }

        /// <summary>
        /// Fonction qui retourne l'objet Categorie correspond à son identifiant passé en paramètre
        /// </summary>
        /// <param name="idC"></param>
        /// <returns>Categorie</returns>
        public static Localisation RecupererLocalisation(int idL)
        {
            Localisation uneVille = new Localisation();
            try
            {
                uneVille = Modele.MonModele.Localisations.First(x => x.IdLocalisation == idL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneVille;
        }

        public static Localisation RecupererDerniereLocalisation()
        {
            int idLocalisation = Modele.MonModele.Localisations.Max(x => x.IdLocalisation);
            return RecupererLocalisation(idLocalisation);
        }
    }
}
