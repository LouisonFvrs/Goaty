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
    public partial class FormRessources : Form
    {
        public FormRessources()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRessources_Load(object sender, EventArgs e)
        {
            bsRessources.DataSource = Modele.getListRessources().Select(x => new
            {
                x.Idressource,
                x.Titre,
                x.Description,
                x.Isbn,
                x.Idcategorie,
                x.IdcategorieNavigation.Libellecategorie
            }).OrderBy(x => x.Idressource).ToList();


            dgvRessources.DataSource = bsRessources;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void voirLesExemplaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = bsRessources.Current.GetType();
            int idR = (int)type.GetProperty("Idressource").GetValue(bsRessources.Current, null);
            List<Exemplaire> lesExemplaires = Modele.listeExemplairesParRessource(idR);
            if (lesExemplaires.Count != 0)
            {
                bsExemplaires.DataSource = (lesExemplaires).Select(x => new
                {
                    x.Idexemplaire,
                    x.Dateentree,
                    x.IdetatNavigation.Libelleetat
                });

                dgvExemplaires.DataSource = bsExemplaires;
                dgvExemplaires.Visible = true;
            }
            else
            {
                dgvExemplaires.Visible = false;
                MessageBox.Show("Pas d'exemplaire pour cette ressource");
            }
        }

        private void dgvRessources_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvExemplaires.Visible = false;
        }

        private void dgvRessources_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvExemplaires.Visible = false;
        }

        private void dgvRessources_Click(object sender, EventArgs e)
        {
            dgvExemplaires.Visible = false;
        }
    }
}
