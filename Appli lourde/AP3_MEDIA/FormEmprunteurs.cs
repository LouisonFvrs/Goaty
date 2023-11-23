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
            try
            {
                bsEmprunteurs.DataSource = Modele.getListEmprunteurs()
                    .Select(x => new
                    {
                        Prenom = x.Prenomemprunteur,
                        Nom = x.Nomemprunteur,
                        Date_naissance = x.Datenaissance,
                        Email = x.Emailemprunteur,
                        Telephone = x.Telportable,
                    })
                    .OrderBy(x => x.Prenom);
                dgvEmprunteurs.DataSource = bsEmprunteurs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors du chargement des emprunteurs : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Type type = bsEmprunteurs.Current?.GetType();

                if (type != null)
                {
                    int idE = (int)type.GetProperty("Idemprunteur").GetValue(bsEmprunteurs.Current, null);
                    ModeleEmprunteur.ArchiverEmprunteur(idE);
                }
                else
                {
                    MessageBox.Show("Aucun emprunteur sélectionné", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de l'archivage de l'emprunteur : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
