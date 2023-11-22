using AP3_MEDIA.Entities;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
    public partial class FormEmprunts : Form
    {
        private int Idressource;
        private int Idemprunteur;
        private int Idexemplaire;
        private DateTime Datedebutemprunt;

        public FormEmprunts()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemplirTab()
        {
            bsEmprunts.DataSource = ModeleEmprunts.getListEmprunts().Select(x => new
            {
                x.Idressource,
                ModeleEmprunteur.RecupererEmprunteurId(x.Idemprunteur).Idemprunteur,
                ModeleExemplaire.RecupererExemplaire(x.Idexemplaire).Idexemplaire,
                x.Datedebutemprunt,
                IdEtat = x.IdEtatEmprunt,
                Nom = ModeleEmprunteur.RecupererEmprunteurId(x.Idemprunteur).Nomemprunteur,
                Prenom = ModeleEmprunteur.RecupererEmprunteurId(x.Idemprunteur).Prenomemprunteur,
                ModeleRessource.RecupererRessource(ModeleExemplaire.RecupererExemplaire(x.Idexemplaire).Idressource).Titre,
                Debut_emprunt = DateOnly.FromDateTime(x.Datedebutemprunt),
                Duree_emprunt = x.Dureeemprunt,
                Retour_emprunt = DateOnly.FromDateTime(x.Dateretour),
                Etat = ModeleEmprunts.RecupererEtatEmprunt(x.IdEtatEmprunt).LibEtat
            }); ;
            dgvEmprunteurs.DataSource = bsEmprunts;
            dgvEmprunteurs.Columns[0].Visible = false;
            dgvEmprunteurs.Columns[1].Visible = false;
            dgvEmprunteurs.Columns[2].Visible = false;
            dgvEmprunteurs.Columns[3].Visible = false;
            dgvEmprunteurs.Columns[4].Visible = false;
        }

        private void FormEmprunts_Load(object sender, EventArgs e)
        {
            RemplirTab();

            // remplir la comboBox des emprunteurs
            cbEmprunteurs.ValueMember = "Idemprunteur";    //permet de stocker l'identifiant
            cbEmprunteurs.DisplayMember = "Emprunteur";
            bsEmprunteurs.DataSource = ModeleEmprunteur.getListEmprunteurs().Select(x => new
            {
                x.Idemprunteur,
                Emprunteur = x.Prenomemprunteur + " " + x.Nomemprunteur
            });
            cbEmprunteurs.DataSource = bsEmprunteurs;

            // remplir la comboBox des emprunteurs
            cbEtats.ValueMember = "Id";    //permet de stocker l'identifiant
            cbEtats.DisplayMember = "Libelle";
            bsEtats.DataSource = ModeleEmprunts.getListEtatEmprunts().Select(x => new
            {
                x.Id,
                Libelle = x.LibEtat
            });
            cbEtats.DataSource = bsEtats;

            // Ajoutez le gestionnaire d'événements RowPrePaint à la DataGridView
            dgvEmprunteurs.RowPrePaint += dgvEmprunteurs_RowPrePaint;
        }
        private void cbEmprunteurs_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbEmprunteurs.SelectedValue == null) return;

            // Filtrez les données en fonction de la sélection dans cbEmprunteurs
            int selectedEmprunteurId = (int)cbEmprunteurs.SelectedValue;

            // Filtrer les données ici, par exemple, vous pouvez utiliser LINQ
            var filteredData = ModeleEmprunts.getListEmprunts()
                .Where(x => ModeleEmprunteur.RecupererEmprunteurId(x.Idemprunteur).Idemprunteur == selectedEmprunteurId)
                .Select(x => new
                {
                    x.Idressource,
                    ModeleEmprunteur.RecupererEmprunteurId(x.Idemprunteur).Idemprunteur,
                    ModeleExemplaire.RecupererExemplaire(x.Idexemplaire).Idexemplaire,
                    x.Datedebutemprunt,
                    IdEtat = x.IdEtatEmprunt,
                    Nom = ModeleEmprunteur.RecupererEmprunteurId(x.Idemprunteur).Nomemprunteur,
                    Prenom = ModeleEmprunteur.RecupererEmprunteurId(x.Idemprunteur).Prenomemprunteur,
                    ModeleRessource.RecupererRessource(ModeleExemplaire.RecupererExemplaire(x.Idexemplaire).Idressource).Titre,
                    Debut_emprunt = DateOnly.FromDateTime(x.Datedebutemprunt),
                    Duree_emprunt = x.Dureeemprunt,
                    Retour_emprunt = DateOnly.FromDateTime(x.Dateretour),
                    Etat = ModeleEmprunts.RecupererEtatEmprunt(x.IdEtatEmprunt).LibEtat
                });

            // Mettez à jour la source de données de la DataGridView
            bsEmprunts.DataSource = filteredData.ToList();
        }

        private void cbEtats_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbEtats.SelectedValue == null) return;

            // Filtrez les données en fonction de la sélection dans cbEtats
            int selectedEtatId = (int)cbEtats.SelectedValue;

            // Filtrer les données ici, par exemple, vous pouvez utiliser LINQ
            var filteredData = ModeleEmprunts.getListEmprunts()
                .Where(x => x.IdEtatEmpruntNavigation.Id == selectedEtatId)
                .Select(x => new
                {
                    x.Idressource,
                    ModeleEmprunteur.RecupererEmprunteurId(x.Idemprunteur).Idemprunteur,
                    ModeleExemplaire.RecupererExemplaire(x.Idexemplaire).Idexemplaire,
                    x.Datedebutemprunt,
                    IdEtat = x.IdEtatEmprunt,
                    Nom = ModeleEmprunteur.RecupererEmprunteurId(x.Idemprunteur).Nomemprunteur,
                    Prenom = ModeleEmprunteur.RecupererEmprunteurId(x.Idemprunteur).Prenomemprunteur,
                    ModeleRessource.RecupererRessource(ModeleExemplaire.RecupererExemplaire(x.Idexemplaire).Idressource).Titre,
                    Debut_emprunt = DateOnly.FromDateTime(x.Datedebutemprunt),
                    Duree_emprunt = x.Dureeemprunt,
                    Retour_emprunt = DateOnly.FromDateTime(x.Dateretour),
                    Etat = ModeleEmprunts.RecupererEtatEmprunt(x.IdEtatEmprunt).LibEtat
                });

            // Mettez à jour la source de données de la DataGridView
            bsEmprunts.DataSource = filteredData.ToList();
        }

        private void dgvEmprunteurs_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Obtenez l'index de la ligne
            int rowIndex = e.RowIndex;

            // Obtenez la valeur de l'état de l'emprunt pour la ligne actuelle
            int etatId = (int)dgvEmprunteurs.Rows[rowIndex].Cells["IdEtat"].Value;

            // Définissez la couleur en fonction de l'état de l'emprunt
            Color rowColor = Color.White; // Par défaut

            switch (etatId)
            {
                case 1: // "en cours" 
                    rowColor = Color.Yellow;
                    break;
                case 2: // "en attente"
                    rowColor = Color.Orange;
                    break;
                case 3: // "rendu"
                    rowColor = Color.Green;
                    break;
            }

            // Appliquez la couleur de fond à la ligne
            dgvEmprunteurs.Rows[rowIndex].DefaultCellStyle.BackColor = rowColor;
        }
        private void dgvEmprunteurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifiez si le clic a été effectué sur la colonne "Action" et si c'est un clic gauche (ButtonState.Pressed)
            if (e.ColumnIndex == dgvEmprunteurs.Columns["Action"].Index && e.RowIndex >= 0 &&
                (Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left)
            {
                // Obtenez les informations associées à la ligne cliquée
                Idressource = (int)dgvEmprunteurs.Rows[e.RowIndex].Cells["Idressource"].Value; // Assurez-vous que le nom de la colonne est correct
                Idemprunteur = (int)dgvEmprunteurs.Rows[e.RowIndex].Cells["Idemprunteur"].Value; // Assurez-vous que le nom de la colonne est correct
                Idexemplaire = (int)dgvEmprunteurs.Rows[e.RowIndex].Cells["Idexemplaire"].Value; // Assurez-vous que le nom de la colonne est correct
                Datedebutemprunt = (DateTime)dgvEmprunteurs.Rows[e.RowIndex].Cells["Datedebutemprunt"].Value; // Assurez-vous que le nom de la colonne est correct
            }
        }


        private void btnDureePret_Click(object sender, EventArgs e)
        {
            if (bsEmprunteurs.Current == null)
            {
                MessageBox.Show("ERREUR : Il faut sélectionner une ligne", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime dureeProlongation = dtpDateRetour.Value;
                if (ModeleEmprunts.ProlongationDureeEmprunts(Idressource, Idemprunteur, Idexemplaire, Datedebutemprunt, dureeProlongation)
))
                {
                    MessageBox.Show("Durée du prêt prolongée");
                    Modele.MonModele.SaveChanges();
                }
            }
        }
    }
}
