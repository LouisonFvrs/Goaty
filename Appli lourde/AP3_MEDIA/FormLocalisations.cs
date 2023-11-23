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
    public partial class FormLocalisations : Form
    {
        private Localisation selectedLocalisation = new Localisation();

        public FormLocalisations()
        {
            InitializeComponent();
        }

        public void RemplirListeLocalisation()
        {
            try
            {
                // Remplir la comboBox des localisations
                lbLocalisations.ValueMember = "IdLocalisation";
                List<Localisation> listeLocalisations = ModeleLocalisation.getListLocalisations();
                bsLocalisations.DataSource = listeLocalisations;

                // Définir le champ à afficher en concaténant "VilleLocalisation" et "AdresseLocalisation"
                lbLocalisations.DisplayMember = "VilleEtAdresseLocalisation";
                lbLocalisations.DataSource = bsLocalisations;

                // Définir un gestionnaire d'événements pour formater l'affichage dans la ListBox
                lbLocalisations.Format += (sender, e) =>
                {
                    if (e.ListItem is Localisation localisation)
                    {
                        e.Value = $"{localisation.VilleLocalisation} - {localisation.AdresseLocalisation}";
                    }
                };
                lbLocalisations.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors du chargement des localisations : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLocalisations_Load(object sender, EventArgs e)
        {
            RemplirListeLocalisation();

            btnModifier.Hide();
            btnSupprimer.Hide();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (selectedLocalisation != null)
            {
                if (ModeleLocalisation.SupprimerLocalisation(selectedLocalisation.IdLocalisation))
                {
                    MessageBox.Show("Localisation supprimée");
                    RemplirListeLocalisation();
                    lbLocalisations.SelectedIndex = -1;
                    tbLibelle.Clear();
                    tbAdresse.Clear();
                }
                else
                {
                    MessageBox.Show("Suppression impossible", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERREUR : Sélectionner la localisation à supprimer", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (selectedLocalisation != null)
            {
                string ville = tbLibelle.Text;
                string adresse = tbAdresse.Text;

                if (!string.IsNullOrEmpty(ville) && !string.IsNullOrEmpty(adresse))
                {
                    if (ModeleLocalisation.ModifierLocalisation(selectedLocalisation.IdLocalisation, ville, adresse))
                    {
                        MessageBox.Show("Localisation modifiée");
                        RemplirListeLocalisation();
                        lbLocalisations.SelectedIndex = -1;
                        tbLibelle.Clear();
                        tbAdresse.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Modification impossible", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERREUR : Les champs ne doivent pas être vides", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERREUR : Sélectionner la localisation à modifier", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string ville = tbLibelle.Text;
            string adresse = tbAdresse.Text;

            if (!string.IsNullOrEmpty(ville) && !string.IsNullOrEmpty(adresse))
            {
                if (ModeleLocalisation.AjoutLocalisation(ville, adresse))
                {
                    MessageBox.Show("Localisation ajoutée");
                    tbLibelle.Clear();
                    tbAdresse.Clear();
                    RemplirListeLocalisation();
                }
                else
                {
                    MessageBox.Show("Ajout impossible", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERREUR : La ville et l'adresse ne doivent pas être vides", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeselectionner_Click(object sender, EventArgs e)
        {
            lbLocalisations.SelectedIndex = -1;
            tbLibelle.Clear();
            tbAdresse.Clear();
            btnValider.Show();
            btnModifier.Hide();
            btnSupprimer.Hide();
        }

        private void bsLocalisations_CurrentChanged(object sender, EventArgs e)
        {
            if (lbLocalisations.SelectedIndex != -1)
            {
                selectedLocalisation = (Localisation)bsLocalisations.Current;

                tbLibelle.Text = selectedLocalisation.VilleLocalisation;
                tbAdresse.Text = selectedLocalisation.AdresseLocalisation;

                btnValider.Hide();
                btnModifier.Show();
                btnSupprimer.Show();
            }
        }
    }
}
