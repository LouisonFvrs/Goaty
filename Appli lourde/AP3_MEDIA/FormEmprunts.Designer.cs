namespace AP3_MEDIA
{
    partial class FormEmprunts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnFermer = new Button();
            dgvEmprunteurs = new DataGridView();
            label1 = new Label();
            bsEmprunts = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvEmprunteurs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEmprunts).BeginInit();
            SuspendLayout();
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(667, 231);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(105, 55);
            btnFermer.TabIndex = 4;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // dgvEmprunteurs
            // 
            dgvEmprunteurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmprunteurs.Location = new Point(101, 48);
            dgvEmprunteurs.Name = "dgvEmprunteurs";
            dgvEmprunteurs.RowTemplate.Height = 25;
            dgvEmprunteurs.Size = new Size(552, 187);
            dgvEmprunteurs.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 6;
            label1.Text = "Liste des emprunts";
            // 
            // FormEmprunts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(784, 298);
            Controls.Add(dgvEmprunteurs);
            Controls.Add(label1);
            Controls.Add(btnFermer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormEmprunts";
            Text = "FormEmprunts";
            Load += FormEmprunts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmprunteurs).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEmprunts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFermer;
        private DataGridView dgvEmprunteurs;
        private Label label1;
        private BindingSource bsEmprunts;
    }
}