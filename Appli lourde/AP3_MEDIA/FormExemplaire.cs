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
        public FormExemplaire()
        {
            InitializeComponent();
            // remplir la comboBox des ressources
            cbRessource.ValueMember = "Idressource";    //permet de stocker l'identifiant
            cbRessource.DisplayMember = "libelleressource";
            cbRessource.DataSource = ModeleRessource.getListRessources();
            cbRessource.DataSource = bsRessource;
            // remplir la comboBox des états
            cbEtat.ValueMember = "idetat";    //permet de stocker l'identifiant
            cbEtat.DisplayMember = "libelleetat";
            cbEtat.DataSource = ModeleExemplaire.getListEtats();
            cbEtat.DataSource = bsEtat;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            System.Type type = bsExemplaire.Current.GetType();
            int idR = (int)type.GetProperty("Idressource").GetValue(bsRessource.Current, null);
            int idEtat = (int)type.GetProperty("Idetat").GetValue(bsEtat.Current, null);
            //DateOnly dateEntree = ;
            //ModeleExemplaire.AjouterExemplaire(idR, idEtat, dateEntree);
        }
    }
}
