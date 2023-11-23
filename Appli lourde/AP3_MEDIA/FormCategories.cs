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
            try
            {
                lbCategories.ValueMember = "idcategorie";
                lbCategories.DisplayMember = "libellecategorie";
                bsCategories.DataSource = ModeleCategorie.getListCategories();
                lbCategories.DataSource = bsCategories;
                lbCategories.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            try
            {
                remplirListeCategories();
                btnModifier.Hide();
                btnSupprimer.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                string libelle = tbLibelle.Text;

                if (!string.IsNullOrEmpty(libelle))
                {
                    if (ModeleCategorie.AjoutCategorie(libelle))
                    {
                        MessageBox.Show("Catégorie ajoutée ");
                        tbLibelle.Clear();
                        remplirListeCategories();
                    }
                    else
                    {
                        MessageBox.Show("L'ajout de la catégorie a échoué", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERREUR : Le libellé ne doit pas être vide", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bsCategories_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbCategories.SelectedIndex != -1)
                {
                    C = (Categorie)bsCategories.Current;
                    tbLibelle.Text = C.Libellecategorie;
                    btnValider.Hide();
                    btnModifier.Show();
                    btnSupprimer.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbCategories.SelectedIndex != -1)
                {
                    string libelle = tbLibelle.Text;

                    if (!string.IsNullOrEmpty(libelle))
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
                            MessageBox.Show("La modification de la catégorie a échoué", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERREUR : Le libellé ne doit pas être vide", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERREUR : Sélectionner la catégorie à modifier", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbCategories.SelectedIndex != -1)
                {
                    string libelle = tbLibelle.Text;

                    if (!string.IsNullOrEmpty(libelle))
                    {
                        if (ModeleCategorie.SupprimerCategorie(C.Idcategorie))
                        {
                            MessageBox.Show("Catégorie supprimée ");
                            remplirListeCategories();
                            lbCategories.SelectedIndex = -1;
                            tbLibelle.Clear();
                        }
                        else
                        {
                            MessageBox.Show("La suppression de la catégorie a échoué", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERREUR : Sélectionner la catégorie à supprimer", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERREUR : Sélectionner la catégorie à supprimer", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeselectionner_Click(object sender, EventArgs e)
        {
            try
            {
                lbCategories.SelectedIndex = -1;
                tbLibelle.Clear();
                btnValider.Show();
                btnModifier.Hide();
                btnSupprimer.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
