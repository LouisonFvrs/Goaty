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
            // remplir la comboBox des ressources
            cbRessource.ValueMember = "Idressource";    //permet de stocker l'identifiant
            cbRessource.DisplayMember = "Titre";
            bsRessource.DataSource = ModeleRessource.getListRessources().Select(x => new
            {
                x.Idressource,
                x.Titre
            });
            cbRessource.DataSource = bsRessource;
            // remplir la comboBox des états
            cbEtat.ValueMember = "Idetat";    //permet de stocker l'identifiant
            cbEtat.DisplayMember = "Libelleetat";
            bsEtat.DataSource = ModeleExemplaire.getListEtats().Select(x => new
            {
                x.Idetat,
                x.Libelleetat
            });
            cbEtat.DataSource = bsEtat;
            // remplir la comboBox des localisations
            cbLocalisation.ValueMember = "IdLocalisation";    //permet de stocker l'identifiant
            cbLocalisation.DisplayMember = "villeLocalisation";
            bsLocalisation.DataSource = ModeleExemplaire.getListLocalisation().Select(x => new
            {
                x.IdLocalisation,
                x.VilleLocalisation
            });
            cbLocalisation.DataSource = bsLocalisation;
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {
            ModeleExemplaire.AjouterExemplaire(Convert.ToInt32(cbRessource.SelectedValue), Convert.ToInt32(cbLocalisation.SelectedValue), Convert.ToInt32(cbEtat.SelectedValue), DateOnly.FromDateTime(dtpEntree.Value));
        }
    }
}
