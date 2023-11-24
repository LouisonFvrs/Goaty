using AP3_MEDIA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_MEDIA
{
    public partial class FormRessources : Form
    {
        private FormMenu formMenu;

        public FormRessources()
        {
            InitializeComponent();
        }

        // Fermer la page
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Affiche le tableau de ressources à l'aide de la fonction getListRessources
        private void FormRessources_Load(object sender, EventArgs e)
        {
            try
            {
                var ressources = ModeleRessource.getListRessources().Select(x => new
                {
                    x.Idressource,
                    x.Titre,
                    x.Description,
                    x.Langue,
                    Annee_sortie = x.Anneesortie,
                    Libelle = x.IdcategorieNavigation.Libellecategorie,
                }).OrderBy(x => x.Titre).ToList();

                bsRessources.DataSource = ressources;
                dgvRessources.DataSource = bsRessources;
                dgvRessources.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des ressources : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Permet d'afficher les exemplaires selon la ressource sélectionnée en récupérant l'Id
        private void voirLesExemplaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Type type = bsRessources.Current.GetType();
                int idR = (int)type.GetProperty("Idressource").GetValue(bsRessources.Current, null);

                List<Exemplaire> lesExemplaires = ModeleExemplaire.listeExemplairesParRessource(idR);

                if (lesExemplaires.Count != 0)
                {
                    bsExemplaires.DataSource = lesExemplaires.Select(x => new
                    {
                        x.Idexemplaire,
                        Date_entree = x.Dateentree,
                        Libelle = x.IdetatNavigation.Libelleetat,
                        Localisation = x.IdLocalisationNavigation.VilleLocalisation
                    });

                    dgvExemplaires.DataSource = bsExemplaires;
                    dgvExemplaires.Visible = true;
                }
                else
                {
                    dgvExemplaires.Visible = false;
                    MessageBox.Show("Pas d'exemplaire pour cette ressource");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des exemplaires : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ne pas afficher la liste des exemplaires de l'ensemble de ces actions
        private void dgvRessources_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvExemplaires.Visible = false;
        }

        private void dgvRessources_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvExemplaires.Visible = false;
        }

        private void dgvRessources_Click(object sender, EventArgs e)
        {
            dgvExemplaires.Visible = false;
        }

        // Affiche la liste des ressources archivées
        private void btnListeArchive_Click(object sender, EventArgs e)
        {
            try
            {
                List<Ressource> lesRessources = ModeleRessource.getListRessourcesArchivees();

                if (lesRessources.Count != 0)
                {
                    bsRessources.DataSource = lesRessources.Select(x => new
                    {
                        x.Idressource,
                        x.Titre,
                        x.Description,
                        x.Langue,
                        Annee_sortie = x.Anneesortie,
                        Libelle = x.IdcategorieNavigation.Libellecategorie
                    }).OrderBy(x => x.Titre).ToList();

                    dgvRessources.DataSource = bsRessources;
                    dgvRessources.Columns[0].Visible = false;
                }
                else
                {
                    dgvRessources.Visible = false;
                    MessageBox.Show("Pas de ressource archivée");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des ressources archivées : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Affiche la liste des ressources non archivées
        private void btnRessources_Click(object sender, EventArgs e)
        {
            dgvRessources.Visible = true;

            try
            {
                var ressources = ModeleRessource.getListRessources().Select(x => new
                {
                    x.Idressource,
                    x.Titre,
                    x.Description,
                    x.Langue,
                    Annee_sortie = x.Anneesortie,
                    Libelle = x.IdcategorieNavigation.Libellecategorie
                }).OrderBy(x => x.Titre).ToList();

                bsRessources.DataSource = ressources;
                dgvRessources.DataSource = bsRessources;
                dgvRessources.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des ressources : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bouton qui permet d'archiver la ressource sélectionnée
        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Type type = bsRessources.Current.GetType();
                int idR = (int)type.GetProperty("Idressource").GetValue(bsRessources.Current, null);
                ModeleRessource.ArchiverRessource(idR);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'archivage de la ressource : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Permet de supprimer réellement de la base de données la ressource sélectionnée
        private void supprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Type type = bsRessources.Current.GetType();
                int idR = (int)type.GetProperty("Idressource").GetValue(bsRessources.Current, null);
                ModeleRessource.SupprimerRessource(idR);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression de la ressource : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bouton qui permet d'ajouter un exemplaire à la ressource sélectionnée
        private void btnAjoutExem_Click(object sender, EventArgs e)
        {
            try
            {
                FormExemplaire formExemplaire = new FormExemplaire();
                formExemplaire.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ouverture du formulaire d'ajout d'exemplaire : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Type type = bsExemplaires.Current.GetType();
                int idE = (int)type.GetProperty("Idexemplaire").GetValue(bsExemplaires.Current, null);
                ModeleExemplaire.ArchiverExemplaire(idE);
                Modele.MonModele.SaveChanges();
                MessageBox.Show("L'exemplaire a bien été archivé");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'archivage de l'exemplaire : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                System.Type type = bsExemplaires.Current.GetType();
                int idE = (int)type.GetProperty("Idexemplaire").GetValue(bsExemplaires.Current, null);
                ModeleExemplaire.SupprimerExemplaire(idE);
                Modele.MonModele.SaveChanges();
                MessageBox.Show("L'exemplaire a bien été supprimé");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression de l'exemplaire : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
