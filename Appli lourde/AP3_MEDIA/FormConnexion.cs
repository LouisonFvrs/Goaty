using AP3_MEDIA.Entities;
using BCrypt.Net;
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
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                string email = tbEmail.Text;
                string mdp = tbMdp.Text;

                Emprunteur emp = ModeleEmprunteur.RecupererEmprunteurLogin(email);

                if (emp != null && emp.Emailemprunteur != null)
                {
                    if (BCrypt.Net.BCrypt.Verify(mdp, emp.Motpasseemprunteur))
                    {
                        if (emp.IdRole == 1)
                        {
                            FormMenu formMenu = new FormMenu();
                            this.Hide();
                            formMenu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Vous n'avez pas les accès pour vous connecter", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login ou mot de passe erroné", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Login ou mot de passe erroné", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

