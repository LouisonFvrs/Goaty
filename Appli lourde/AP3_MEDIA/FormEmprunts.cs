using AP3_MEDIA.Entities;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections;
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
        public FormEmprunts()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemplirTab(bool param)
        {
            try
            {
                bsEmprunts.DataSource = ModeleEmprunts.getListEmprunts().Select(x => new
                {
                    x.Idressource,
                    ModeleEmprunteur.RecupererEmprunteurId(x.Idemprunteur).Idemprunteur,
                    ModeleExemplaire.RecupererExemplaire(x.Idexemplaire).Idexemplaire,
                    x.Datedebutemprunt,
                    IdEtat = x.IdEtatEmprunt,
                    x.ArchiverEmprunter,
                    Nom = ModeleEmprunteur.RecupererEmprunteurId(x.Idemprunteur).Nomemprunteur,
                    Prenom = ModeleEmprunteur.RecupererEmprunteurId(x.Idemprunteur).Prenomemprunteur,
                    ModeleRessource.RecupererRessource(ModeleExemplaire.RecupererExemplaire(x.Idexemplaire).Idressource).Titre,
                    Debut_emprunt = DateOnly.FromDateTime(x.Datedebutemprunt),
                    Duree_emprunt = x.Dureeemprunt,
                    Retour_emprunt = DateOnly.FromDateTime(x.Dateretour),
                    Etat = ModeleEmprunts.RecupererEtatEmprunt(x.IdEtatEmprunt).LibEtat
                }).Where(x => x.ArchiverEmprunter == param);

                dgvEmprunteurs.DataSource = bsEmprunts;
                dgvEmprunteurs.Columns[0].Visible = false;
                dgvEmprunteurs.Columns[1].Visible = false;
                dgvEmprunteurs.Columns[2].Visible = false;
                dgvEmprunteurs.Columns[3].Visible = false;
                dgvEmprunteurs.Columns[4].Visible = false;
                dgvEmprunteurs.Columns[5].Visible = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors du remplissage de la liste d'emprunts : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormEmprunts_Load(object sender, EventArgs e)
        {
            try
            {
                RemplirTab(false);

                cbEmprunteurs.ValueMember = "Idemprunteur";
                cbEmprunteurs.DisplayMember = "Emprunteur";
                bsEmprunteurs.DataSource = ModeleEmprunteur.getListEmprunteurs().Select(x => new
                {
                    x.Idemprunteur,
                    Emprunteur = x.Prenomemprunteur + " " + x.Nomemprunteur
                });
                cbEmprunteurs.DataSource = bsEmprunteurs;

                cbEtats.ValueMember = "Id";
                cbEtats.DisplayMember = "Libelle";
                bsEtats.DataSource = ModeleEmprunts.getListEtatEmprunts().Select(x => new
                {
                    x.Id,
                    Libelle = x.LibEtat
                });
                cbEtats.DataSource = bsEtats;

                dgvEmprunteurs.RowPrePaint += dgvEmprunteurs_RowPrePaint;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors du chargement des emprunts : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbEmprunteurs_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbEmprunteurs.SelectedValue == null) return;

                int selectedEmprunteurId = (int)cbEmprunteurs.SelectedValue;

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

                bsEmprunts.DataSource = filteredData.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de la sélection de l'emprunteur : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbEtats_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbEtats.SelectedValue == null) return;

                int selectedEtatId = (int)cbEtats.SelectedValue;

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

                bsEmprunts.DataSource = filteredData.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de la sélection de l'état : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmprunteurs_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0)
                {
                    int etatId = (int)dgvEmprunteurs.Rows[rowIndex].Cells["IdEtat"].Value;

                    Color rowColor = Color.White;

                    switch (etatId)
                    {
                        case 1:
                            rowColor = Color.Yellow;
                            break;
                        case 2:
                            rowColor = Color.Orange;
                            break;
                        case 3:
                            rowColor = Color.Green;
                            break;
                    }

                    dgvEmprunteurs.Rows[rowIndex].DefaultCellStyle.BackColor = rowColor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de la pré-peinture des lignes : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDureePret_Click(object sender, EventArgs e)
        {
            try
            {
                if (bsEmprunteurs.Current == null)
                {
                    MessageBox.Show("ERREUR : Il faut sélectionner une ligne", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (bsEmprunts.Current != null)
                    {
                        PropertyDescriptor IDEmprunteurPropertyDescriptor = bsEmprunts.GetItemProperties(null)[1];
                        int idemprunteur = (int)IDEmprunteurPropertyDescriptor.GetValue(bsEmprunts.Current);

                        PropertyDescriptor IDRessourcePropertyDescriptor = bsEmprunts.GetItemProperties(null)[0];
                        int idressource = (int)IDRessourcePropertyDescriptor.GetValue(bsEmprunts.Current);

                        PropertyDescriptor IDExemplairePropertyDescriptor = bsEmprunts.GetItemProperties(null)[2];
                        int idexemplaire = (int)IDExemplairePropertyDescriptor.GetValue(bsEmprunts.Current);

                        PropertyDescriptor DateDebutEmpruntPropertyDescriptor = bsEmprunts.GetItemProperties(null)[3];
                        DateTime datedebutemprunt = (DateTime)DateDebutEmpruntPropertyDescriptor.GetValue(bsEmprunts.Current);

                        DateTime dureeProlongation = dtpDateRetour.Value;

                        if (ModeleEmprunts.ProlongationDureeEmprunts(idressource, idemprunteur, idexemplaire, datedebutemprunt, dureeProlongation))
                        {
                            Modele.MonModele.SaveChanges();
                            FormEmprunts_Load(sender, e);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERREUR", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de la prolongation de la durée d'emprunt : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PropertyDescriptor IDEmprunteurPropertyDescriptor = bsEmprunts.GetItemProperties(null)[1];
                int idemprunteur = (int)IDEmprunteurPropertyDescriptor.GetValue(bsEmprunts.Current);

                PropertyDescriptor IDRessourcePropertyDescriptor = bsEmprunts.GetItemProperties(null)[0];
                int idressource = (int)IDRessourcePropertyDescriptor.GetValue(bsEmprunts.Current);

                PropertyDescriptor IDExemplairePropertyDescriptor = bsEmprunts.GetItemProperties(null)[2];
                int idexemplaire = (int)IDExemplairePropertyDescriptor.GetValue(bsEmprunts.Current);

                PropertyDescriptor DateDebutEmpruntPropertyDescriptor = bsEmprunts.GetItemProperties(null)[3];
                DateTime datedebutemprunt = (DateTime)DateDebutEmpruntPropertyDescriptor.GetValue(bsEmprunts.Current);

                ModeleEmprunts.ArchiverEmprunt(idressource, idemprunteur, idexemplaire, datedebutemprunt);
                FormEmprunts_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de la suppression de l'emprunt : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEmpruntsArchives_Click(object sender, EventArgs e)
        {
            List<Emprunter> listEmprunts = ModeleEmprunts.getListEmpruntsArchives();
            if (listEmprunts.Count != 0)
            {
                RemplirTab(true);
            } 
            else
            {
                dgvEmprunteurs.Visible = false;
                MessageBox.Show("Pas d'emprunt archivé");
            }
        }

        private void btnEmprunts_Click(object sender, EventArgs e)
        {
            RemplirTab(false);
        }
    }
}
