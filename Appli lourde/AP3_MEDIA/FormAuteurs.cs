﻿using AP3_MEDIA.Entities;
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
    public partial class FormAuteurs : Form
    {

        private Auteur A = new Auteur();
        public FormAuteurs()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void remplirListeAuteurs()
        {
            // remplir la comboBox des auteurs
            lbAuteurs.ValueMember = "IdAuteur";    //permet de stocker l'identifiant
            lbAuteurs.DisplayMember = "NomAuteur";
            bsAuteurs.DataSource = ModeleAuteur.getListAuteurs();
            lbAuteurs.DataSource = bsAuteurs;
            lbAuteurs.SelectedIndex = -1;
        }
        private void FormAuteurs_Load(object sender, EventArgs e)
        {
            remplirListeAuteurs();

            btnModifier.Hide();
            btnSupprimer.Hide();
        }

        private void bsAuteurs_CurrentChanged_1(object sender, EventArgs e)
        {
            if (lbAuteurs.SelectedIndex != -1)
            {
                // récupération de la catégorie sélectionnée
                A = (Auteur)bsAuteurs.Current;

                // mise à jour du libellé pour modifier ou supprimer
                tbLibelle.Text = A.NomAuteur;

                btnValider.Hide();
                btnModifier.Show();
                btnSupprimer.Show();
            }
        }

        private void btnDeselectionner_Click_1(object sender, EventArgs e)
        {
            lbAuteurs.SelectedIndex = -1;
            tbLibelle.Clear();
            btnValider.Show();
            btnModifier.Hide();
            btnSupprimer.Hide();
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            string libelle = tbLibelle.Text;
            if (libelle != "")
            {
                if (ModeleAuteur.SupprimerAuteur(A.IdAuteur))
                {
                    MessageBox.Show("Auteur supprimé ");
                    remplirListeAuteurs();
                    lbAuteurs.SelectedIndex = -1;
                    tbLibelle.Clear();
                }
            }
            else
            {
                MessageBox.Show("ERREUR : Sélectionner la catégorie à supprimer", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            string libelle = tbLibelle.Text;

            if (libelle != "")
            {
                if (ModeleAuteur.ModifierAuteur(A.IdAuteur, libelle))
                {
                    MessageBox.Show("Catégorie modifiée ");
                    remplirListeAuteurs();
                    lbAuteurs.SelectedIndex = -1;
                    tbLibelle.Clear();
                }
                else
                {
                    MessageBox.Show("Modification impossible", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERREUR : Sélectionner l'auteur à modifier", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {
            string libelle = tbLibelle.Text;
            if (libelle != "")
            {
                if (ModeleAuteur.AjoutAuteur(libelle))
                {
                    MessageBox.Show("Auteur ajouté ");
                    tbLibelle.Clear();
                    remplirListeAuteurs();
                }
                else
                {
                    MessageBox.Show("Ajout impossible", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERREUR : le nom ne doit pas être vide", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAuteurs_Load_1(object sender, EventArgs e)
        {
            remplirListeAuteurs();

            btnModifier.Hide();
            btnSupprimer.Hide();
        }
    }
}