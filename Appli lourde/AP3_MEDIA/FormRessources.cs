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
        FormMenu f = new FormMenu();
        public FormRessources()
        {
            InitializeComponent();
        }
        
        //fermer la page
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // affiche le tableau de ressources à l'aide de la fonction getListRessources
        private void FormRessources_Load(object sender, EventArgs e)
        {
            bsRessources.DataSource = ModeleRessource.getListRessources().Select(x => new
            {
                x.Idressource,
                x.Titre,
                x.Description,
                x.Langue,
                x.Anneesortie,
                x.IdcategorieNavigation.Libellecategorie
            }).OrderBy(x => x.Titre).ToList();

            dgvRessources.DataSource = bsRessources;
            dgvRessources.Columns[0].Visible = false;
        }

        // permet d'afficher les exemplaires selon la ressource sélectionnée en récupérant l'Id
        private void voirLesExemplaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = bsRessources.Current.GetType();
            int idR = (int)type.GetProperty("Idressource").GetValue(bsRessources.Current, null);
            List<Exemplaire> lesExemplaires = ModeleExemplaire.listeExemplairesParRessource(idR);
            if (lesExemplaires.Count != 0)
            {
                bsExemplaires.DataSource = (lesExemplaires).Select(x => new
                {
                    x.Idexemplaire,
                    x.Dateentree,
                    x.IdetatNavigation.Libelleetat
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

        // ne pas afficher la liste des exemplaires de l'enesemble de ces actions 
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

        // affiche la liste des ressources archivées
        private void btnListeArchive_Click(object sender, EventArgs e)
        {
            List<Ressource> lesRessources = ModeleRessource.getListRessourcesArchivees();
            if (lesRessources.Count != 0)
            {
                bsRessourcesArchivees.DataSource = (lesRessources).Select(x => new
                {
                    x.Idressource,
                    x.Titre,
                    x.Description,
                    x.Langue,
                    x.Anneesortie,
                    x.IdcategorieNavigation.Libellecategorie
                }).OrderBy(x => x.Titre).ToList();

                dgvRessources.DataSource = bsRessourcesArchivees;
                dgvRessources.Columns[0].Visible = false;
            }
            else
            {
                dgvRessources.Visible = false;
                MessageBox.Show("Pas de ressource archivée");
            }
        }

        // affiche la liste des ressources non archivées
        private void btnRessources_Click(object sender, EventArgs e)
        {
            dgvRessources.Visible = true;
            bsRessources.DataSource = ModeleRessource.getListRessources().Select(x => new
            {
                x.Idressource,
                x.Titre,
                x.Description,
                x.Langue,
                x.Anneesortie,
                x.IdcategorieNavigation.Libellecategorie
            }).OrderBy(x => x.Titre).ToList();

            dgvRessources.DataSource = bsRessources;
            dgvRessources.Columns[0].Visible = false;
        }

        // bouton qui permet d'archiver la ressource sélectionnée
        private void archiveToolStripMenuItem(object sender, EventArgs e)
        {
            System.Type type = bsRessources.Current.GetType();
            int idR = (int)type.GetProperty("Idressource").GetValue(bsRessources.Current, null);
            ModeleRessource.ArchiverRessource(idR);
        }

        // permet de supprimer réellement de la base de donnée la ressource sélectionnée 
        private void supprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Type type = bsRessources.Current.GetType();
            int idR = (int)type.GetProperty("Idressource").GetValue(bsRessources.Current, null);
            ModeleRessource.SupprimerRessource(idR);
        }

        // bouton qui permet d'ajouter un exemplaire à la ressource sélectionnée 
        private void btnAjoutExem_Click(object sender, EventArgs e)
        {
            f.openChildForm(new FormExemplaire());
        }
    }
}