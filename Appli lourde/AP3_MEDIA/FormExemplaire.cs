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
    public partial class FormExemplaire : Form
    {
        public int idR;

        public FormExemplaire()
        {
            InitializeComponent();
        }

        private void FormExemplaire_Load(object sender, EventArgs e)
        {
            try
            {
                // Remplir la comboBox des ressources
                cbRessource.ValueMember = "Idressource";
                cbRessource.DisplayMember = "Titre";
                bsRessource.DataSource = ModeleRessource.getListRessources().Select(x => new
                {
                    x.Idressource,
                    x.Titre
                });
                cbRessource.DataSource = bsRessource;

                // Remplir la comboBox des états
                cbEtat.ValueMember = "Idetat";
                cbEtat.DisplayMember = "Libelleetat";
                bsEtat.DataSource = ModeleExemplaire.getListEtats().Select(x => new
                {
                    x.Idetat,
                    x.Libelleetat
                });
                cbEtat.DataSource = bsEtat;

                // Remplir la comboBox des localisations
                cbLocalisation.ValueMember = "IdLocalisation";
                cbLocalisation.DisplayMember = "VilleLocalisation";
                bsLocalisation.DataSource = ModeleExemplaire.getListLocalisation().Select(x => new
                {
                    x.IdLocalisation,
                    x.VilleLocalisation
                });
                cbLocalisation.DataSource = bsLocalisation;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors du chargement des données : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cbRessource.SelectedValue == null || cbLocalisation.SelectedValue == null || cbEtat.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez sélectionner une valeur pour chaque champ.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ModeleExemplaire.AjouterExemplaire(
                        Convert.ToInt32(cbRessource.SelectedValue),
                        Convert.ToInt32(cbLocalisation.SelectedValue),
                        Convert.ToInt32(cbEtat.SelectedValue),
                        DateOnly.FromDateTime(dtpEntree.Value)
                    );

                    MessageBox.Show("L'exemplaire a été ajouté avec succès.", "SUCCÈS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de l'ajout de l'exemplaire : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

