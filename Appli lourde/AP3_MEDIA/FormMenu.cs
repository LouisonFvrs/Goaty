using System.Windows.Forms;

namespace AP3_MEDIA
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void qUITTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        public Form activeForm = null;
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formEnfant);
            panelPrincipal.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }


        private void cATEGORIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCategories());

        }
        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRessources());
        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionRessources(EtatGestion.Create));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionRessources(EtatGestion.Update)); // Form de Gestion en modification (update)
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eMPRUNTEURToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEmprunteurs());
        }
    }
}