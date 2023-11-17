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
    public static class ModeleRessource
    {
    

      
        /// <summary>
        /// Fonction qui retourne la liste des ressources
        /// </summary>
        /// <returns>Liste</returns>
        public static List<Ressource> getListRessources()
        {
            return Modele.MonModele.Ressources.Where(p => p.ArchiverRess == false).ToList();
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
        public static bool AjoutRessource(string titre, string description, string image, int annee, string langue, string isbn, int idCategorie)
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
                uneRessource.Anneesortie = annee;
                uneRessource.Langue = langue;
                uneRessource.Isbn = isbn;
                uneRessource.Idcategorie = idCategorie;

                Modele.MonModele.Ressources.Add(uneRessource);
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
        /// Fonction qui retourne l'identifiant de la dernière ressource
        /// </summary>
        /// <returns>entier</returns>
        public static int RetourneDerniereRessourceSaisie()
        {
            return Modele.MonModele.Ressources.Max(x => x.Idressource);
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
        /// Fonction qui retourne l'objet Ressource correspondant à son identifiant passé en paramètre
        /// </summary>
        /// <param name="idR"></param>
        /// <returns>Ressource</returns>
        public static Ressource RecupererRessource(int idR)
        {
            Ressource uneRessource = new Ressource();
            try
            {
                uneRessource = Modele.MonModele.Ressources.First(x => x.Idressource == idR);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneRessource;
        }

        // fonction qui récupère la ressource sélectionnée et passe le champ archive à 1 
        public static bool ArchiverRessource(int idR)
        {
            Ressource uneRessource;
            bool vretour = true;
            try
            {
                if (ModeleExemplaire.listeExemplairesParRessource(idR).Count <= 0)
                {
                    // récupération de la ressource à modifier
                    uneRessource = RecupererRessource(idR);

                    // mise à jour des champs
                    uneRessource.ArchiverRess = true;
                    Modele.MonModele.SaveChanges();
                }
                else
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

        // fonction qui supprime la ressource sélectionnée s'il n'y a pas d'exemplaire
        public static bool SupprimerRessource(int idR)
        {
            Ressource uneRessource;
            bool vretour = true;
            try
            {
                if (ModeleExemplaire.listeExemplairesParRessource(idR).Count <= 0)
                {
                    // récupération de la ressource à supprimer
                    uneRessource = RecupererRessource(idR);
                    Modele.MonModele.Ressources.Remove(uneRessource);
                    Modele.MonModele.SaveChanges();
                }
                else
                {
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

        // retourne la liste des ressources archivées 
        public static List<Ressource> getListRessourcesArchivees()
        {
            return Modele.MonModele.Ressources.Where(p => p.ArchiverRess == true).Include(a => a.IdcategorieNavigation).ToList();
        }
    }
}