namespace AP3_MEDIA
{
    partial class FormExemplaire
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
            labelRessource = new Label();
            labelEtat = new Label();
            labelDateEntree = new Label();
            btnValider = new Button();
            bsExemplaire = new BindingSource(components);
            cbEtat = new ComboBox();
            cbRessource = new ComboBox();
            dtpEntree = new DateTimePicker();
            bsRessource = new BindingSource(components);
            bsEtat = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsExemplaire).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRessource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEtat).BeginInit();
            SuspendLayout();
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(180, 262);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(72, 39);
            btnFermer.TabIndex = 3;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // labelRessource
            // 
            labelRessource.AutoSize = true;
            labelRessource.Location = new Point(28, 28);
            labelRessource.Name = "labelRessource";
            labelRessource.Size = new Size(66, 15);
            labelRessource.TabIndex = 4;
            labelRessource.Text = "Ressource :";
            // 
            // labelEtat
            // 
            labelEtat.AutoSize = true;
            labelEtat.Location = new Point(30, 90);
            labelEtat.Name = "labelEtat";
            labelEtat.Size = new Size(33, 15);
            labelEtat.TabIndex = 5;
            labelEtat.Text = "Etat :";
            // 
            // labelDateEntree
            // 
            labelDateEntree.AutoSize = true;
            labelDateEntree.Location = new Point(28, 160);
            labelDateEntree.Name = "labelDateEntree";
            labelDateEntree.Size = new Size(73, 15);
            labelDateEntree.TabIndex = 6;
            labelDateEntree.Text = "Date Entrée :";
            // 
            // btnValider
            // 
            btnValider.Location = new Point(28, 262);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(75, 23);
            btnValider.TabIndex = 9;
            btnValider.Text = "Ajouter";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // cbEtat
            // 
            cbEtat.FormattingEnabled = true;
            cbEtat.Location = new Point(28, 108);
            cbEtat.Name = "cbEtat";
            cbEtat.Size = new Size(121, 23);
            cbEtat.TabIndex = 10;
            // 
            // cbRessource
            // 
            cbRessource.FormattingEnabled = true;
            cbRessource.Location = new Point(28, 46);
            cbRessource.Name = "cbRessource";
            cbRessource.Size = new Size(121, 23);
            cbRessource.TabIndex = 11;
            // 
            // dtpEntree
            // 
            dtpEntree.Location = new Point(28, 178);
            dtpEntree.Name = "dtpEntree";
            dtpEntree.Size = new Size(200, 23);
            dtpEntree.TabIndex = 12;
            // 
            // FormExemplaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(264, 309);
            Controls.Add(dtpEntree);
            Controls.Add(cbRessource);
            Controls.Add(cbEtat);
            Controls.Add(btnValider);
            Controls.Add(labelDateEntree);
            Controls.Add(labelEtat);
            Controls.Add(labelRessource);
            Controls.Add(btnFermer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormExemplaire";
            Text = "FormExemplaire";
            ((System.ComponentModel.ISupportInitialize)bsExemplaire).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRessource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEtat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFermer;
        private Label labelRessource;
        private Label labelEtat;
        private Label labelDateEntree;
        private Button btnValider;
        private BindingSource bsExemplaire;
        private ComboBox cbEtat;
        private ComboBox cbRessource;
        private DateTimePicker dtpEntree;
        private BindingSource bsRessource;
        private BindingSource bsEtat;
    }
}