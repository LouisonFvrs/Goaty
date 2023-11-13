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
    internal class ModeleCategorie
    {
     

        /// <summary>
        /// Fonction qui retourne la liste de toutes les catégories
        /// </summary>
        /// <returns>Liste</returns>
        public static List<Categorie> getListCategories()
        {
            return Modele.MonModele.Categories.ToList();
        }


        /// <summary>
        /// Fonction qui retourne vrai si l'ajout d'une catégorie est possible
        /// </summary>
        /// <param name="libelle"></param>
        /// <returns>bool</returns>
        public static bool AjoutCategorie(string libelle)
        {
            Categorie uneCategorie;
            bool vretour = true;
            try
            {
                // ajout dans la table Ressource

                uneCategorie = new Categorie();
                uneCategorie.Libellecategorie = libelle;

                Modele.MonModele.Categories.Add(uneCategorie);
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
        public static bool ModifierCategorie(int idC, string libelle)
        {
            Categorie uneCategorie;
            bool vretour = true;
            try
            {
                // récupération de la categorie à modifier
                uneCategorie = RecupererCategorie(idC);
                uneCategorie.Libellecategorie = libelle;

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
        public static bool SupprimerCategorie(int idC)
        {
            Categorie uneCategorie;
            bool vretour = true;
            try
            {
                // récupération de la categorie à supprimer
                uneCategorie = RecupererCategorie(idC);
                uneCategorie.ArchiverCat = false;
                Modele.MonModele.Categories.Remove(uneCategorie);

                Modele.MonModele.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show("Suppression impossible, lien existant avec des ressources");
            }
            return vretour;
        }

        /// <summary>
        /// Fonction qui retourne l'objet Categorie correspond à son identifiant passé en paramètre
        /// </summary>
        /// <param name="idC"></param>
        /// <returns>Categorie</returns>
        public static Categorie RecupererCategorie(int idC)
        {
            Categorie uneCategorie = new Categorie();
            try
            {
                uneCategorie = Modele.MonModele.Categories.First(x => x.Idcategorie == idC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneCategorie;
        }
    }
}
