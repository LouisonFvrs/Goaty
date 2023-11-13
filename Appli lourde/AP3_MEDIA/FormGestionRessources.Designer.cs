namespace AP3_MEDIA
{
    partial class FormGestionRessources
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
            label1 = new Label();
            gbInfo = new GroupBox();
            btnPlus = new Button();
            cbAuteur = new ComboBox();
            label9 = new Label();
            cbCategories = new ComboBox();
            label8 = new Label();
            tbLangue = new TextBox();
            label7 = new Label();
            tbIsbn = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tbAnnee = new TextBox();
            tbImage = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbDescription = new TextBox();
            tbTitre = new TextBox();
            btnAjouter = new Button();
            btnFermer = new Button();
            bsCategories = new BindingSource(components);
            cbRessources = new ComboBox();
            bsRessources = new BindingSource(components);
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRessources).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(319, 40);
            label1.TabIndex = 2;
            label1.Text = "Ajout d'une ressource";
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(btnPlus);
            gbInfo.Controls.Add(cbAuteur);
            gbInfo.Controls.Add(label9);
            gbInfo.Controls.Add(cbCategories);
            gbInfo.Controls.Add(label8);
            gbInfo.Controls.Add(tbLangue);
            gbInfo.Controls.Add(label7);
            gbInfo.Controls.Add(tbIsbn);
            gbInfo.Controls.Add(label6);
            gbInfo.Controls.Add(label5);
            gbInfo.Controls.Add(tbAnnee);
            gbInfo.Controls.Add(tbImage);
            gbInfo.Controls.Add(label4);
            gbInfo.Controls.Add(label3);
            gbInfo.Controls.Add(label2);
            gbInfo.Controls.Add(tbDescription);
            gbInfo.Controls.Add(tbTitre);
            gbInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gbInfo.Location = new Point(74, 82);
            gbInfo.Margin = new Padding(4, 5, 4, 5);
            gbInfo.Name = "gbInfo";
            gbInfo.Padding = new Padding(4, 5, 4, 5);
            gbInfo.Size = new Size(976, 378);
            gbInfo.TabIndex = 3;
            gbInfo.TabStop = false;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.Transparent;
            btnPlus.Location = new Point(562, 179);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(37, 36);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.TextAlign = ContentAlignment.TopRight;
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // cbAuteur
            // 
            cbAuteur.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAuteur.FormattingEnabled = true;
            cbAuteur.Location = new Point(321, 179);
            cbAuteur.Margin = new Padding(4, 5, 4, 5);
            cbAuteur.Name = "cbAuteur";
            cbAuteur.Size = new Size(234, 36);
            cbAuteur.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(321, 146);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(71, 28);
            label9.TabIndex = 12;
            label9.Text = "Auteur";
            // 
            // cbCategories
            // 
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(619, 265);
            cbCategories.Margin = new Padding(4, 5, 4, 5);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(234, 36);
            cbCategories.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(619, 227);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 28);
            label8.TabIndex = 11;
            label8.Text = "Catégorie *";
            // 
            // tbLangue
            // 
            tbLangue.Location = new Point(619, 163);
            tbLangue.Margin = new Padding(4, 5, 4, 5);
            tbLangue.MaxLength = 2;
            tbLangue.Name = "tbLangue";
            tbLangue.Size = new Size(91, 33);
            tbLangue.TabIndex = 5;
            tbLangue.KeyPress += tbLangue_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(619, 130);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 28);
            label7.TabIndex = 9;
            label7.Text = "Langue";
            // 
            // tbIsbn
            // 
            tbIsbn.Location = new Point(619, 68);
            tbIsbn.Margin = new Padding(4, 5, 4, 5);
            tbIsbn.MaxLength = 13;
            tbIsbn.Name = "tbIsbn";
            tbIsbn.Size = new Size(234, 33);
            tbIsbn.TabIndex = 4;
            tbIsbn.KeyPress += tbIsbn_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(619, 35);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 28);
            label6.TabIndex = 8;
            label6.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 293);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(148, 28);
            label5.TabIndex = 7;
            label5.Text = "Année de sortie";
            label5.Click += label5_Click;
            // 
            // tbAnnee
            // 
            tbAnnee.Location = new Point(31, 326);
            tbAnnee.Margin = new Padding(4, 5, 4, 5);
            tbAnnee.MaxLength = 4;
            tbAnnee.Name = "tbAnnee";
            tbAnnee.Size = new Size(141, 33);
            tbAnnee.TabIndex = 3;
            tbAnnee.TextChanged += tbAnnee_TextChanged;
            tbAnnee.KeyPress += tbAnnee_KeyPress;
            // 
            // tbImage
            // 
            tbImage.ForeColor = SystemColors.WindowText;
            tbImage.Location = new Point(321, 63);
            tbImage.Margin = new Padding(4, 5, 4, 5);
            tbImage.Multiline = true;
            tbImage.Name = "tbImage";
            tbImage.Size = new Size(264, 75);
            tbImage.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 30);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 4;
            label4.Text = "Image";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 110);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 30);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 2;
            label2.Text = "Titre *";
            // 
            // tbDescription
            // 
            tbDescription.ForeColor = SystemColors.WindowText;
            tbDescription.Location = new Point(31, 143);
            tbDescription.Margin = new Padding(4, 5, 4, 5);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(264, 145);
            tbDescription.TabIndex = 1;
            // 
            // tbTitre
            // 
            tbTitre.ForeColor = SystemColors.WindowText;
            tbTitre.Location = new Point(31, 63);
            tbTitre.Margin = new Padding(4, 5, 4, 5);
            tbTitre.Name = "tbTitre";
            tbTitre.Size = new Size(264, 33);
            tbTitre.TabIndex = 0;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Black;
            btnAjouter.FlatStyle = FlatStyle.Popup;
            btnAjouter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAjouter.ForeColor = Color.White;
            btnAjouter.Location = new Point(726, 470);
            btnAjouter.Margin = new Padding(4, 5, 4, 5);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(143, 72);
            btnAjouter.TabIndex = 12;
            btnAjouter.Text = "AJOUTER";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(900, 470);
            btnFermer.Margin = new Padding(4, 5, 4, 5);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(150, 72);
            btnFermer.TabIndex = 4;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // cbRessources
            // 
            cbRessources.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRessources.FormattingEnabled = true;
            cbRessources.Location = new Point(521, 32);
            cbRessources.Margin = new Padding(4, 5, 4, 5);
            cbRessources.Name = "cbRessources";
            cbRessources.Size = new Size(527, 33);
            cbRessources.TabIndex = 13;
            cbRessources.SelectedIndexChanged += cbRessources_SelectedIndexChanged;
            // 
            // bsRessources
            // 
            bsRessources.CurrentChanged += bsRessources_CurrentChanged;
            // 
            // FormGestionRessources
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1143, 562);
            Controls.Add(cbRessources);
            Controls.Add(btnAjouter);
            Controls.Add(btnFermer);
            Controls.Add(gbInfo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormGestionRessources";
            Load += FormGestionRessources_Load;
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRessources).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbInfo;
        private Button btnFermer;
        private TextBox tbAnnee;
        private TextBox tbImage;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbDescription;
        private TextBox tbTitre;
        private Label label5;
        private Label label6;
        private ComboBox cbCategories;
        private Label label8;
        private TextBox tbLangue;
        private Label label7;
        private TextBox tbIsbn;
        private BindingSource bsCategories;
        private Button btnAjouter;
        private ComboBox cbRessources;
        private BindingSource bsRessources;
        private Button btnPlus;
        private ComboBox cbAuteur;
        private Label label9;
    }
}