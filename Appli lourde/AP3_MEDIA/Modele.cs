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
    internal static class Modele
    {
        private static GoatyContext monModele;
       
        /// <summary>
        /// Initialisation du modèle
        /// </summary>
        public static void init()
        {
            monModele = new GoatyContext();
        }

        public static GoatyContext MonModele { get => monModele; set => monModele = value; }


        /// <summary>
        /// Fonction qui retourne la liste de toutes les catégories
        /// </summary>
        /// <returns>Liste</returns>
        public static List<Categorie> getListCategories()
        {
            return monModele.Categories.ToList();
        }

        /// <summary>
        /// Fonction qui retourne la liste des ressources
        /// </summary>
        /// <returns>Liste</returns>
        public static List<Ressource> getListRessources()
        {
            return monModele.Ressources.Where(p => p.ArchiverRess == false).Include(a=> a.IdcategorieNavigation).ToList();
        }

        /// <summary>
        /// Fonction qui retourne la liste des Exemplaires
        /// </summary>
        /// <returns>Liste</returns>
        public static List<Exemplaire> getListExemplaires()
        {
            return monModele.Exemplaires.ToList();
        }

        /// <summary>
        /// Fonction qui retourne la liste des exemplaires d'une ressource dont l'identifiant est passé en paramètre
        /// </summary>
        /// <param name="idR">Identifiant Ressource</param>
        /// <returns>Liste</returns>
        public static List<Exemplaire> listeExemplairesParRessource(int idR)
        {
            List<Exemplaire> lesEx = monModele.Exemplaires.Where(p => p.Idressource == idR).Include(p=> p.IdetatNavigation).ToList();
            return lesEx;
        }

        public static List<Emprunteur> getListEmprunteurs()
        {
            return monModele.Emprunteurs.ToList();
        }

        /// <summary>
        /// Fonction qui retourne vrai si l'ajout d'une ressource peut s'effectuer
        /// </summary>
        /// <param name="titre"></param>
        /// <param name="description"></param>
        /// <param name="image"></param>
        /// <param name="annee"></param>
        /// <param name="langue"></param>
        /// <param name="isbn"></param>
        /// <param name="idCategorie"></param>
        /// <returns>bool</returns>
        public static bool AjoutRessource(string titre, string description, string image, int annee, string langue, string isbn, int idCategorie, List<Auteur> ListAuteur)
        {
            Ressource uneRessource;
            bool vretour = true;
            try
            {
                // ajout dans la table Ressource
               
                uneRessource = new Ressource();
                uneRessource.Titre = titre;
                uneRessource.Description = description;
                uneRessource.Image = image;
                uneRessource.Anneesortie= annee;
                uneRessource.Langue= langue;
                uneRessource.Isbn = isbn;
                uneRessource.Idcategorie= idCategorie;

                monModele.Ressources.Add(uneRessource);
                monModele.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        /// <summary>
        /// Fonction qui retourne l'identifiant de la dernière ressource
        /// </summary>
        /// <returns>entier</returns>
        public static int RetourneDerniereRessourceSaisie()
        {
            return monModele.Ressources.Max(x => x.Idressource);
        }

        /// <summary>
        /// Fonction qui retourne vrai si la modification d'une ressource est possible
        /// </summary>
        /// <param name="idR"></param>
        /// <param name="titre"></param>
        /// <param name="description"></param>
        /// <param name="image"></param>
        /// <param name="annee"></param>
        /// <param name="langue"></param>
        /// <param name="isbn"></param>
        /// <param name="idCategorie"></param>
        /// <returns>bool</returns>
        public static bool ModificationRessource(int idR, string titre, string description, string image, int annee, string langue, string isbn, int idCategorie)
        {
            Ressource uneRessource;
            bool vretour = true;
            try
            {
                // récupération de la ressource à modifier
                uneRessource = RecupererRessource(idR);

                // mise à jour des champs
                uneRessource.Titre = titre;
                uneRessource.Description = description;
                uneRessource.Image = image;
                uneRessource.Anneesortie = annee;
                uneRessource.Langue = langue;
                uneRessource.Isbn = isbn;
                uneRessource.Idcategorie = idCategorie;

                monModele.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        /// <summary>
        /// Fonction qui retourne l'objet Ressoutce correspondant à son identifiant passé en paramètre
        /// </summary>
        /// <param name="idR"></param>
        /// <returns>Ressource</returns>
        public static Ressource RecupererRessource(int idR)
        {
            Ressource uneRessource = new Ressource();
            try
            {
                uneRessource = monModele.Ressources.First(x => x.Idressource == idR);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneRessource;
        }

        public static bool ArchiverRessource(int idR)
        {
            Ressource uneRessource;
            bool vretour = true;
            try
            {
                if (listeExemplairesParRessource(idR).Count <= 0 )
                {
                    // récupération de la ressource à modifier
                    uneRessource = RecupererRessource(idR);

                    // mise à jour des champs
                    uneRessource.ArchiverRess = true;
                    monModele.SaveChanges();
                } else
                {
                    MessageBox.Show("Impossible d'archiver la ressource, il existe un exemplaire.");
                }
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool SupprimerRessource(int idR)
        {
            Ressource uneRessource;
            bool vretour = true;
            try
            {
                if (listeExemplairesParRessource(idR).Count <= 0)
                {
                    // récupération de la ressource à supprimer
                    uneRessource = RecupererRessource(idR);
                    monModele.Ressources.Remove(uneRessource);
                    monModele.SaveChanges();
                } else {
                    MessageBox.Show("Impossible de supprimer la ressource, il existe un exemplaire.");
                }
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static List<Ressource> getListRessourcesArchivees()
        {
            return monModele.Ressources.Where(p => p.ArchiverRess == true).Include(a => a.IdcategorieNavigation).ToList();
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

                monModele.Categories.Add(uneCategorie);
                monModele.SaveChanges();

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

                monModele.SaveChanges();

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
                uneCategorie.ArchiverCat = false ;
                monModele.Categories.Remove(uneCategorie);

                monModele.SaveChanges();

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
                uneCategorie = monModele.Categories.First(x => x.Idcategorie == idC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneCategorie;
        }
    }
}
