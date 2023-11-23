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

        private Localisation L = new Localisation();
        public FormLocalisations()
        {
            InitializeComponent();
        }

        public void remplirListeLocalisation()
        {
            // remplir la comboBox des localisations
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

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLocalisations_Load(object sender, EventArgs e)
        {
            remplirListeLocalisation();

            btnModifier.Hide();
            btnSupprimer.Hide();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string ville = tbLibelle.Text;
            string adresse = tbAdresse.Text;
            if (ville != "" && adresse != "")
            {
                if (ModeleAuteur.SupprimerAuteur(L.IdLocalisation))
                {
                    MessageBox.Show("Localisation supprimée ");
                    remplirListeLocalisation();
                    lbLocalisations.SelectedIndex = -1;
                    tbLibelle.Clear();
                    tbAdresse.Clear();
                }
            }
            else
            {
                MessageBox.Show("ERREUR : Sélectionner la localisation à supprimer", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string ville = tbLibelle.Text;
            string adresse = tbAdresse.Text;

            if (ville != "" && adresse != "")
            {
                if (ModeleLocalisation.ModifierLocalisation(L.IdLocalisation, ville, adresse))
                {
                    MessageBox.Show("Localisation modifiée ");
                    remplirListeLocalisation();
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
                MessageBox.Show("ERREUR : Sélectionner la localisation à modifier", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string ville = tbLibelle.Text;
            string adresse = tbAdresse.Text;

            if (ville != "" && adresse != "")
            {
                if (ModeleLocalisation.AjoutLocalisation(ville, adresse))
                {
                    MessageBox.Show("Localisation ajoutée");
                    tbLibelle.Clear();
                    tbAdresse.Clear();
                    remplirListeLocalisation();
                }
                else
                {
                    MessageBox.Show("Ajout impossible", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERREUR : la ville ne doit pas être vide", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // récupération de la catégorie sélectionnée
                L = (Localisation)bsLocalisations.Current;

                // mise à jour du libellé pour modifier ou supprimer
                tbLibelle.Text = L.VilleLocalisation;
                tbAdresse.Text = L.AdresseLocalisation;

                btnValider.Hide();
                btnModifier.Show();
                btnSupprimer.Show();
            }
        }
    }
}

