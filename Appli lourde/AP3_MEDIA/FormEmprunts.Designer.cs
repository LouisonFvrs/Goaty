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
            contextMenuStrip1 = new ContextMenuStrip(components);
            supprimerToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            bsEmprunts = new BindingSource(components);
            cbEmprunteurs = new ComboBox();
            label2 = new Label();
            bsEmprunteurs = new BindingSource(components);
            label3 = new Label();
            cbEtats = new ComboBox();
            bsEtats = new BindingSource(components);
            label4 = new Label();
            btnDureePret = new Button();
            dtpDateRetour = new DateTimePicker();
            btnEmpruntsArchives = new Button();
            btnEmprunts = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmprunteurs).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsEmprunts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEmprunteurs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEtats).BeginInit();
            SuspendLayout();
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(1019, 497);
            btnFermer.Margin = new Padding(4, 5, 4, 5);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(111, 51);
            btnFermer.TabIndex = 4;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // dgvEmprunteurs
            // 
            dgvEmprunteurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmprunteurs.ContextMenuStrip = contextMenuStrip1;
            dgvEmprunteurs.Location = new Point(147, 95);
            dgvEmprunteurs.Margin = new Padding(4, 5, 4, 5);
            dgvEmprunteurs.Name = "dgvEmprunteurs";
            dgvEmprunteurs.RowHeadersWidth = 62;
            dgvEmprunteurs.RowTemplate.Height = 25;
            dgvEmprunteurs.Size = new Size(849, 370);
            dgvEmprunteurs.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { supprimerToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(146, 36);
            // 
            // supprimerToolStripMenuItem
            // 
            supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            supprimerToolStripMenuItem.Size = new Size(145, 32);
            supprimerToolStripMenuItem.Text = "archiver";
            supprimerToolStripMenuItem.Click += supprimerToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(276, 40);
            label1.TabIndex = 6;
            label1.Text = "Liste des emprunts";
            // 
            // cbEmprunteurs
            // 
            cbEmprunteurs.FormattingEnabled = true;
            cbEmprunteurs.Location = new Point(674, 38);
            cbEmprunteurs.Margin = new Padding(4, 5, 4, 5);
            cbEmprunteurs.Name = "cbEmprunteurs";
            cbEmprunteurs.Size = new Size(171, 33);
            cbEmprunteurs.TabIndex = 8;
            cbEmprunteurs.SelectedValueChanged += cbEmprunteurs_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(557, 43);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 9;
            label2.Text = "Emprunteur :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(856, 43);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 10;
            label3.Text = "Etat :";
            // 
            // cbEtats
            // 
            cbEtats.FormattingEnabled = true;
            cbEtats.Location = new Point(911, 38);
            cbEtats.Margin = new Padding(4, 5, 4, 5);
            cbEtats.Name = "cbEtats";
            cbEtats.Size = new Size(140, 33);
            cbEtats.TabIndex = 11;
            cbEtats.SelectedValueChanged += cbEtats_SelectedValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 497);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(450, 25);
            label4.TabIndex = 12;
            label4.Text = "Sélectionner une ligne et prolonger l'emprunt jusqu'au :";
            // 
            // btnDureePret
            // 
            btnDureePret.Location = new Point(889, 490);
            btnDureePret.Margin = new Padding(4, 5, 4, 5);
            btnDureePret.Name = "btnDureePret";
            btnDureePret.Size = new Size(107, 38);
            btnDureePret.TabIndex = 14;
            btnDureePret.Text = "Valider";
            btnDureePret.UseVisualStyleBackColor = true;
            btnDureePret.Click += btnDureePret_Click;
            // 
            // dtpDateRetour
            // 
            dtpDateRetour.Location = new Point(586, 490);
            dtpDateRetour.Margin = new Padding(4, 5, 4, 5);
            dtpDateRetour.Name = "dtpDateRetour";
            dtpDateRetour.Size = new Size(284, 31);
            dtpDateRetour.TabIndex = 15;
            // 
            // btnEmpruntsArchives
            // 
            btnEmpruntsArchives.Location = new Point(17, 213);
            btnEmpruntsArchives.Margin = new Padding(4, 5, 4, 5);
            btnEmpruntsArchives.Name = "btnEmpruntsArchives";
            btnEmpruntsArchives.Size = new Size(107, 72);
            btnEmpruntsArchives.TabIndex = 16;
            btnEmpruntsArchives.Text = "Emprunts archivés";
            btnEmpruntsArchives.UseVisualStyleBackColor = true;
            btnEmpruntsArchives.Click += btnEmpruntsArchives_Click;
            // 
            // btnEmprunts
            // 
            btnEmprunts.Location = new Point(17, 313);
            btnEmprunts.Margin = new Padding(4, 5, 4, 5);
            btnEmprunts.Name = "btnEmprunts";
            btnEmprunts.Size = new Size(107, 72);
            btnEmprunts.TabIndex = 17;
            btnEmprunts.Text = "Emprunts";
            btnEmprunts.UseVisualStyleBackColor = true;
            btnEmprunts.Click += btnEmprunts_Click;
            // 
            // FormEmprunts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1143, 562);
            Controls.Add(btnEmprunts);
            Controls.Add(btnEmpruntsArchives);
            Controls.Add(dtpDateRetour);
            Controls.Add(btnDureePret);
            Controls.Add(label4);
            Controls.Add(cbEtats);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbEmprunteurs);
            Controls.Add(dgvEmprunteurs);
            Controls.Add(label1);
            Controls.Add(btnFermer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEmprunts";
            Text = "FormEmprunts";
            Load += FormEmprunts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmprunteurs).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsEmprunts).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEmprunteurs).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEtats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFermer;
        private DataGridView dgvEmprunteurs;
        private Label label1;
        private BindingSource bsEmprunts;
        private ComboBox cbEmprunteurs;
        private Label label2;
        private BindingSource bsEmprunteurs;
        private Label label3;
        private ComboBox cbEtats;
        private BindingSource bsEtats;
        private Label label4;
        private Button btnDureePret;
        private DateTimePicker dtpDateRetour;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem supprimerToolStripMenuItem;
        private Button btnEmpruntsArchives;
        private Button btnEmprunts;
    }
}