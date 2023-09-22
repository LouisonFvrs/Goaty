using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_MEDIA
{
    public partial class FormEmprunteurs : Form
    {
        public FormEmprunteurs()
        {
            InitializeComponent();
        }

        private void FormEmprunteurs_Load(object sender, EventArgs e)
        {
            bsEmprunteurs.DataSource = Modele.getListEmprunteurs().Select(x => new
            {
                x.Prenomemprunteur,
                x.Nomemprunteur,
                x.Datenaissance,
                x.Emailemprunteur,
                x.Telportable,
            })
            .OrderBy(x => x.Prenomemprunteur);
            dgvEmprunteurs.DataSource = bsEmprunteurs;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
