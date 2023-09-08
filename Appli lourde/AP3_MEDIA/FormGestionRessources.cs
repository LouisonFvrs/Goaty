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
        public FormGestionRessources(EtatGestion etat)
        {
            InitializeComponent();
            this.etat = etat; // pour savoir si on est en create ou update 
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {


        }

        private void tbAnnee_TextChanged(object sender, EventArgs e)
        {

        }
        private void remplirListeRessources()
        {
            // remplir la comboBox des ressources (si modification)
            cbRessources.ValueMember = "idressource";    //permet de stocker l'identifiant
            cbRessources.DisplayMember = "titre";
            bsRessources.DataSource = Modele.getListRessources();
            cbRessources.DataSource = bsRessources;
        }
        public void remplirListeCategories()
        {
            // remplir la comboBox des catégories
            cbCategories.ValueMember = "idcategorie";    //permet de stocker l'identifiant
            cbCategories.DisplayMember = "libellecategorie";
            bsCategories.DataSource = Modele.getListCategories();
            cbCategories.DataSource = bsCategories;
        }
        private void FormGestionRessources_Load(object sender, EventArgs e)
        {
            remplirListeCategories();

            if (etat == EtatGestion.Create) // cas etat create
            {
                label1.Text = "Ajout d'une ressource";
                btnAjouter.Text = "AJOUTER";
                gbInfo.Visible = true;
                cbRessources.Visible = false;

            }
            else // cas etat update
            {
                label1.Text = "Modification d'une ressource";
                btnAjouter.Text = "MODIFIER";
                btnAjouter.Visible = false;
                gbInfo.Visible = false;
                cbRessources.Visible = true;
                remplirListeRessources();
            }
        }

        private void tbAnnee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur dans le format de saisie de l'année (que des chiffres)", "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void tbIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur dans le format de saisie de l'ISBN (que des chiffres)", "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void tbLangue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur dans le format de saisie de la langue (2 caractères)", "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
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

            if (tbTitre.Text != "" && cbCategories.SelectedIndex != -1)
            {
                // ajout possible si les champs titre et catégorie sont remplis au moins
                if (Convert.ToInt32(tbAnnee.Text) >= 1000 && Convert.ToInt32(tbAnnee.Text) <= 2100)
                {
                    // ajout possible si l'année est correcte
                    titre = tbTitre.Text;
                    description = tbDescription.Text;
                    image = tbImage.Text;
                    langue = tbLangue.Text;
                    isbn = tbIsbn.Text;
                    annee = Convert.ToInt32(tbAnnee.Text);
                    idCat = Convert.ToInt32(cbCategories.SelectedValue.ToString());


                    if (etat == EtatGestion.Create) // cas de l'ajout
                    {
                        if (Modele.AjoutRessource(titre, description, image, annee, langue, isbn, idCat))
                        {
                            MessageBox.Show("Ressource ajoutée " + Modele.RetourneDerniereRessourceSaisie());
                            Annuler();
                        }
                    }
                    if (etat == EtatGestion.Update) // cas de la mise à jour
                    {
                        Ressource R = (Ressource)bsRessources.Current;
                        if (Modele.ModificationRessource(R.Idressource, titre, description, image, annee, langue, isbn, idCat))
                        {
                            MessageBox.Show("Ressource modifiée");
                            gbInfo.Visible = false;
                            btnAjouter.Visible = false;
                            cbRessources.SelectedIndex = -1;
                            // Annuler();
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
            // si une ressource est sélectionnée dans la liste
            if (cbRessources.SelectedIndex != -1)
            {
                // récupération de la ressource sélectionnée
                Ressource R = (Ressource)bsRessources.Current;

                // mise à jour des champs de la ressource sélectionnée
                tbTitre.Text = R.Titre;
                tbDescription.Text = R.Description;
                tbAnnee.Text = R.Anneesortie.ToString();
                tbIsbn.Text = R.Isbn;
                tbLangue.Text = R.Langue;
                tbImage.Text = R.Image;
                cbCategories.Text = R.IdcategorieNavigation.Libellecategorie;

                gbInfo.Visible = true;
                btnAjouter.Visible = true;
            }
            else
                gbInfo.Visible = false;
        }

        private void cbRessources_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsRessources_CurrentChanged(sender, e);
        }
    }
}
