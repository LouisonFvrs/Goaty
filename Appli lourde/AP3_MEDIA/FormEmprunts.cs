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

        private void FormEmprunts_Load(object sender, EventArgs e)
        {
            bsEmprunts.DataSource = ModeleEmprunts.getListEmprunts().Select(x => new
            {
                Nom = ModeleEmprunteur.RecupererEmprunteurId(x.Idemprunteur).Nomemprunteur,
                Prenom = ModeleEmprunteur.RecupererEmprunteurId(x.Idemprunteur).Prenomemprunteur,
                ModeleRessource.RecupererRessource(ModeleExemplaire.RecupererExemplaire(x.Idexemplaire).Idressource).Titre,
                Debut_emprunt = DateOnly.FromDateTime(x.Datedebutemprunt),
                Duree_emprunt = x.Dureeemprunt,
                Retour_emprunt = DateOnly.FromDateTime(x.Dateretour),
            }); ;
            dgvEmprunteurs.DataSource = bsEmprunts;

            // remplir la comboBox des emprunteurs
            cbEmprunts.ValueMember = "Idemprunteur";    //permet de stocker l'identifiant
            cbEmprunts.DisplayMember = "Emprunteur";
            bsEmprunteurs.DataSource = ModeleEmprunteur.getListEmprunteurs().Select(x => new
            {
                x.Idemprunteur,
                Emprunteur = x.Prenomemprunteur + " " + x.Nomemprunteur
            });
            cbEmprunts.DataSource = bsEmprunteurs;
        }
    }
}
