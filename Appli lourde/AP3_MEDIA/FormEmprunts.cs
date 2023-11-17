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
                x.IdemprunteurNavigation.Nomemprunteur,
                x.Id.IdressourceNavigation.Titre,
                x.Idexemplaire,
                x.Datedebutemprunt,
                x.Dureeemprunt,
                x.Dateretour,
            })
            .OrderBy(x => x.IdemprunteurNavigation.Nomemprunteur);
            dgvEmprunteurs.DataSource = bsEmprunts;
        }
    }
}
