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
        /// Fonction qui retourne la liste de toutes les auteurs
        /// </summary>
        /// <returns>Liste</returns>
        public static List<Auteur> getListAuteurs()
        {
            return Modele.MonModele.Auteurs.ToList();
        }


        /// <summary>
        /// Fonction qui retourne vrai si l'ajout d'un auteur est possible
        /// </summary>
        /// <param name="libelle"></param>
        /// <returns>bool</returns>
        public static bool AjoutAuteur(string libelle)
        {
            Auteur unAuteur;
            bool vretour = true;
            try
            {
                // ajout dans la table Auteur

                unAuteur = new Auteur();
                unAuteur.NomAuteur = libelle;

                Modele.MonModele.Auteurs.Add(unAuteur);
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
        public static bool ModifierAuteur(int idA, string libelle)
        {
            Auteur unAuteur;
            bool vretour = true;
            try
            {
                // récupération de la categorie à modifier
                unAuteur = RecupererAuteur(idA);
                unAuteur.NomAuteur = libelle;

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
        public static bool SupprimerAuteur(int idA)
        {
            Auteur unAuteur;
            bool vretour = true;
            try
            {
                // récupération de la categorie à supprimer
                unAuteur = RecupererAuteur(idA);
                Modele.MonModele.Auteurs.Remove(unAuteur);

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
        public static Auteur RecupererAuteur(int idA)
        {
            Auteur unAuteur = new Auteur();
            try
            {
                unAuteur = Modele.MonModele.Auteurs.First(x => x.IdAuteur == idA);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unAuteur;
        }
    }
}
