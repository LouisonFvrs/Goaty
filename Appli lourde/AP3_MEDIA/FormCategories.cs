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
using static System.Net.Mime.MediaTypeNames;

namespace AP3_MEDIA
{
    public partial class FormCategories : Form
    {
        private Categorie C = new Categorie();
        public FormCategories()
        {
            InitializeComponent();

        }

        public void remplirListeCategories()
        {
            // remplir la comboBox des catégories
            lbCategories.ValueMember = "idcategorie";    //permet de stocker l'identifiant
            lbCategories.DisplayMember = "libellecategorie";
            bsCategories.DataSource = ModeleCategorie.getListCategories();
            lbCategories.DataSource = bsCategories;
            lbCategories.SelectedIndex = -1;
        }
        private void FormCategories_Load(object sender, EventArgs e)
        {
            remplirListeCategories();

            btnModifier.Hide();
            btnSupprimer.Hide();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string libelle = tbLibelle.Text;
            if (libelle != "")
            {
                if (ModeleCategorie.AjoutCategorie(libelle))
                {
                    MessageBox.Show("Catégorie ajoutée ");
                    tbLibelle.Clear();
                    remplirListeCategories();
                }
                else
                {
                    MessageBox.Show("Ajout impossible", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERREUR : Libellé ne doit pas être vide", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bsCategories_CurrentChanged(object sender, EventArgs e)
        {
            if (lbCategories.SelectedIndex != -1)
            {
                // récupération de la catégorie sélectionnée
                C = (Categorie)bsCategories.Current;

                // mise à jour du libellé pour modifier ou supprimer
                tbLibelle.Text = C.Libellecategorie;

                btnValider.Hide();
                btnModifier.Show();
                btnSupprimer.Show();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string libelle = tbLibelle.Text;

            if (libelle != "")
            {
                if (ModeleCategorie.ModifierCategorie(C.Idcategorie, libelle))
                {
                    MessageBox.Show("Catégorie modifiée ");
                    remplirListeCategories();
                    lbCategories.SelectedIndex = -1;
                    tbLibelle.Clear();
                }
                else
                {
                    MessageBox.Show("Modification impossible", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERREUR : Sélectionner la catégorie à modifier", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string libelle = tbLibelle.Text;
            if (libelle != "")
            {
                if (ModeleCategorie.SupprimerCategorie(C.Idcategorie))
                {
                    MessageBox.Show("Catégorie supprimée ");
                    remplirListeCategories();
                    lbCategories.SelectedIndex = -1;
                    tbLibelle.Clear();
                }
            }
            else
            {
                MessageBox.Show("ERREUR : Sélectionner la catégorie à supprimer", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeselectionner_Click(object sender, EventArgs e)
        {
            lbCategories.SelectedIndex = -1;
            tbLibelle.Clear();
            btnValider.Show();
            btnModifier.Hide();
            btnSupprimer.Hide();
        }
    }
}
