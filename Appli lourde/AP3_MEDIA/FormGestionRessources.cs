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
    public enum EtatGestion
    {
        Create,
        Update
    }

    public partial class FormGestionRessources : Form
    {
        private EtatGestion etat;
        private List<Auteur> ListAuteurs = new List<Auteur>();

        public FormGestionRessources(EtatGestion etat)
        {
            InitializeComponent();
            this.etat = etat;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemplirListeRessources()
        {
            try
            {
                // Remplir la comboBox des ressources (si modification)
                cbRessources.ValueMember = "Idressource";
                cbRessources.DisplayMember = "Titre";
                bsRessources.DataSource = ModeleRessource.getListRessources();
                cbRessources.DataSource = bsRessources;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors du chargement des ressources : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemplirListeCategories()
        {
            try
            {
                // Remplir la comboBox des catégories
                cbCategories.ValueMember = "Idcategorie";
                cbCategories.DisplayMember = "Libellecategorie";
                bsCategories.DataSource = ModeleCategorie.getListCategories();
                cbCategories.DataSource = bsCategories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors du chargement des catégories : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemplirListeAuteurs()
        {
            try
            {
                // Remplir la comboBox des auteurs
                cbAuteurs.ValueMember = "IdAuteur";
                cbAuteurs.DisplayMember = "NomAuteur";
                bsAuteurs.DataSource = ModeleAuteur.getListAuteurs();
                cbAuteurs.DataSource = bsAuteurs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors du chargement des auteurs : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormGestionRessources_Load(object sender, EventArgs e)
        {
            RemplirListeCategories();

            if (etat == EtatGestion.Create)
            {
                label1.Text = "Ajout d'une ressource";
                btnAjouter.Text = "AJOUTER";
                gbInfo.Visible = true;
                cbRessources.Visible = false;
                RemplirListeAuteurs();
            }
            else
            {
                label1.Text = "Modification d'une ressource";
                btnAjouter.Text = "MODIFIER";
                btnAjouter.Visible = false;
                gbInfo.Visible = false;
                cbRessources.Visible = true;
                RemplirListeRessources();
            }
        }

        private void tbAnnee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur dans le format de saisie de l'année (que des chiffres)", "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void tbIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur dans le format de saisie de l'ISBN (que des chiffres)", "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void tbLangue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur dans le format de saisie de la langue (2 caractères)", "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void Annuler()
        {
            tbTitre.Clear();
            tbDescription.Clear();
            tbLangue.Clear();
            tbImage.Clear();
            tbAnnee.Clear();
            tbIsbn.Clear();
            cbCategories.SelectedIndex = -1;
            tbTitre.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int idCat = -1, annee;
            string titre, description, image, langue, isbn;

            if (!string.IsNullOrEmpty(tbTitre.Text) && cbCategories.SelectedIndex != -1)
            {
                if (int.TryParse(tbAnnee.Text, out annee) && annee >= 1000 && annee <= 2100)
                {
                    titre = tbTitre.Text;
                    description = tbDescription.Text;
                    image = tbImage.Text;
                    langue = tbLangue.Text;
                    isbn = tbIsbn.Text;
                    idCat = Convert.ToInt32(cbCategories.SelectedValue);

                    if (etat == EtatGestion.Create)
                    {
                        if (Modele.AjoutRessource(titre, description, image, annee, langue, isbn, idCat, ListAuteurs))
                        {
                            MessageBox.Show("Ressource ajoutée " + Modele.RetourneDerniereRessourceSaisie());
                            Annuler();
                        }
                    }
                    else if (etat == EtatGestion.Update)
                    {
                        Ressource ressource = (Ressource)bsRessources.Current;
                        if (Modele.ModificationRessource(ressource.Idressource, titre, description, image, annee, langue, isbn, idCat))
                        {
                            MessageBox.Show("Ressource modifiée");
                            gbInfo.Visible = false;
                            btnAjouter.Visible = false;
                            cbRessources.SelectedIndex = -1;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ajout impossible : problème sur l'année", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ajout impossible : Il faut saisir au moins le titre et la catégorie", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bsRessources_CurrentChanged(object sender, EventArgs e)
        {
            if (cbRessources.SelectedIndex != -1)
            {
                Ressource ressource = (Ressource)bsRessources.Current;

                tbTitre.Text = ressource.Titre;
                tbDescription.Text = ressource.Description;
                tbAnnee.Text = ressource.Anneesortie.ToString();
                tbIsbn.Text = ressource.Isbn;
                tbLangue.Text = ressource.Langue;
                tbImage.Text = ressource.Image;
                cbCategories.Text = ressource.IdcategorieNavigation.Libellecategorie;

                gbInfo.Visible = true;
                btnAjouter.Visible = true;
                lbAuteurs.Items.Clear();
                ICollection<Auteur> auteurs = ModeleAuteur.RecupererAuteurParRessource(ressource.Idressource);
                foreach (Auteur auteur in auteurs)
                {
                    lbAuteurs.Items.Add(auteur.NomAuteur);
                }
            }
            else
            {
                gbInfo.Visible = false;
            }
        }

        private void cbRessources_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsRessources_CurrentChanged(sender, e);
        }

        private void btnAuteurList_Click(object sender, EventArgs e)
        {
            lbAuteurs.Items.Add(cbAuteurs.Text);
            ListAuteurs.Add(ModeleAuteur.RecupererAuteur(Convert.ToInt32(cbAuteurs.SelectedValue.ToString())));
        }

        private void btnAuteurInsert_Click(object sender, EventArgs e)
        {
            lbAuteurs.Items.Add(tbAuteur.Text);
            ModeleAuteur.AjoutAuteur(tbAuteur.Text);
            ListAuteurs.Add(ModeleAuteur.RecupererDernierAuteur());
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbAuteurs.Items.Remove(lbAuteurs.SelectedItem);
        }

    }
}

