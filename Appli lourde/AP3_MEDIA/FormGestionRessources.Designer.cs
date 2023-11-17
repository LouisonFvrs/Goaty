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
            btnAuteurInsert = new Button();
            tbAuteur = new TextBox();
            lbAuteurs = new ListBox();
            btnAuteurList = new Button();
            cbAuteurs = new ComboBox();
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
            bsAuteurs = new BindingSource(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            supprimerToolStripMenuItem = new ToolStripMenuItem();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRessources).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAuteurs).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 25);
            label1.TabIndex = 2;
            label1.Text = "Ajout d'une ressource";
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(btnAuteurInsert);
            gbInfo.Controls.Add(tbAuteur);
            gbInfo.Controls.Add(lbAuteurs);
            gbInfo.Controls.Add(btnAuteurList);
            gbInfo.Controls.Add(cbAuteurs);
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
            gbInfo.Location = new Point(52, 49);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(683, 235);
            gbInfo.TabIndex = 3;
            gbInfo.TabStop = false;
            // 
            // btnAuteurInsert
            // 
            btnAuteurInsert.BackColor = Color.Transparent;
            btnAuteurInsert.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAuteurInsert.Location = new Point(395, 140);
            btnAuteurInsert.Margin = new Padding(2);
            btnAuteurInsert.Name = "btnAuteurInsert";
            btnAuteurInsert.Size = new Size(54, 22);
            btnAuteurInsert.TabIndex = 17;
            btnAuteurInsert.Text = "Ajouter";
            btnAuteurInsert.TextAlign = ContentAlignment.TopRight;
            btnAuteurInsert.UseVisualStyleBackColor = false;
            btnAuteurInsert.Click += btnAuteurInsert_Click;
            // 
            // tbAuteur
            // 
            tbAuteur.ForeColor = SystemColors.WindowText;
            tbAuteur.Location = new Point(225, 138);
            tbAuteur.Name = "tbAuteur";
            tbAuteur.Size = new Size(165, 25);
            tbAuteur.TabIndex = 16;
            // 
            // lbAuteurs
            // 
            lbAuteurs.ContextMenuStrip = contextMenuStrip1;
            lbAuteurs.FormattingEnabled = true;
            lbAuteurs.ItemHeight = 17;
            lbAuteurs.Location = new Point(225, 166);
            lbAuteurs.Name = "lbAuteurs";
            lbAuteurs.Size = new Size(165, 55);
            lbAuteurs.TabIndex = 15;
            // 
            // btnAuteurList
            // 
            btnAuteurList.BackColor = Color.Transparent;
            btnAuteurList.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAuteurList.Location = new Point(395, 107);
            btnAuteurList.Margin = new Padding(2);
            btnAuteurList.Name = "btnAuteurList";
            btnAuteurList.Size = new Size(54, 22);
            btnAuteurList.TabIndex = 14;
            btnAuteurList.Text = "Ajouter";
            btnAuteurList.TextAlign = ContentAlignment.TopRight;
            btnAuteurList.UseVisualStyleBackColor = false;
            btnAuteurList.Click += btnAuteurList_Click;
            // 
            // cbAuteurs
            // 
            cbAuteurs.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAuteurs.FormattingEnabled = true;
            cbAuteurs.Location = new Point(225, 107);
            cbAuteurs.Name = "cbAuteurs";
            cbAuteurs.Size = new Size(165, 25);
            cbAuteurs.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(225, 88);
            label9.Name = "label9";
            label9.Size = new Size(46, 17);
            label9.TabIndex = 12;
            label9.Text = "Auteur";
            // 
            // cbCategories
            // 
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(494, 166);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(165, 25);
            cbCategories.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(494, 146);
            label8.Name = "label8";
            label8.Size = new Size(74, 17);
            label8.TabIndex = 11;
            label8.Text = "Catégorie *";
            // 
            // tbLangue
            // 
            tbLangue.Location = new Point(494, 104);
            tbLangue.MaxLength = 2;
            tbLangue.Name = "tbLangue";
            tbLangue.Size = new Size(65, 25);
            tbLangue.TabIndex = 5;
            tbLangue.KeyPress += tbLangue_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(494, 84);
            label7.Name = "label7";
            label7.Size = new Size(50, 17);
            label7.TabIndex = 9;
            label7.Text = "Langue";
            // 
            // tbIsbn
            // 
            tbIsbn.Location = new Point(494, 38);
            tbIsbn.MaxLength = 13;
            tbIsbn.Name = "tbIsbn";
            tbIsbn.Size = new Size(165, 25);
            tbIsbn.TabIndex = 4;
            tbIsbn.KeyPress += tbIsbn_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(494, 18);
            label6.Name = "label6";
            label6.Size = new Size(35, 17);
            label6.TabIndex = 8;
            label6.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 176);
            label5.Name = "label5";
            label5.Size = new Size(100, 17);
            label5.TabIndex = 7;
            label5.Text = "Année de sortie";
            // 
            // tbAnnee
            // 
            tbAnnee.Location = new Point(22, 196);
            tbAnnee.MaxLength = 4;
            tbAnnee.Name = "tbAnnee";
            tbAnnee.Size = new Size(100, 25);
            tbAnnee.TabIndex = 3;
            tbAnnee.KeyPress += tbAnnee_KeyPress;
            // 
            // tbImage
            // 
            tbImage.ForeColor = SystemColors.WindowText;
            tbImage.Location = new Point(225, 38);
            tbImage.Multiline = true;
            tbImage.Name = "tbImage";
            tbImage.Size = new Size(186, 47);
            tbImage.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 18);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 4;
            label4.Text = "Image";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 66);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 18);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 2;
            label2.Text = "Titre *";
            // 
            // tbDescription
            // 
            tbDescription.ForeColor = SystemColors.WindowText;
            tbDescription.Location = new Point(22, 86);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(186, 89);
            tbDescription.TabIndex = 1;
            // 
            // tbTitre
            // 
            tbTitre.ForeColor = SystemColors.WindowText;
            tbTitre.Location = new Point(22, 38);
            tbTitre.Name = "tbTitre";
            tbTitre.Size = new Size(186, 25);
            tbTitre.TabIndex = 0;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Black;
            btnAjouter.FlatStyle = FlatStyle.Popup;
            btnAjouter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAjouter.ForeColor = Color.White;
            btnAjouter.Location = new Point(614, 290);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(84, 35);
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
            btnFermer.Location = new Point(704, 290);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(84, 35);
            btnFermer.TabIndex = 4;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // cbRessources
            // 
            cbRessources.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRessources.FormattingEnabled = true;
            cbRessources.Location = new Point(365, 19);
            cbRessources.Name = "cbRessources";
            cbRessources.Size = new Size(370, 23);
            cbRessources.TabIndex = 13;
            cbRessources.SelectedIndexChanged += cbRessources_SelectedIndexChanged;
            // 
            // bsRessources
            // 
            bsRessources.CurrentChanged += bsRessources_CurrentChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { supprimerToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(129, 26);
            // 
            // supprimerToolStripMenuItem
            // 
            supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            supprimerToolStripMenuItem.Size = new Size(180, 22);
            supprimerToolStripMenuItem.Text = "supprimer";
            supprimerToolStripMenuItem.Click += supprimerToolStripMenuItem_Click;
            // 
            // FormGestionRessources
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 337);
            Controls.Add(cbRessources);
            Controls.Add(btnAjouter);
            Controls.Add(btnFermer);
            Controls.Add(gbInfo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionRessources";
            Load += FormGestionRessources_Load;
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRessources).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAuteurs).EndInit();
            contextMenuStrip1.ResumeLayout(false);
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
        private ComboBox cbAuteurs;
        private Label label9;
        private ListBox lbAuteurs;
        private TextBox tbAuteur;
        private Button btnAuteurList;
        private BindingSource bsAuteurs;
        private Button btnAuteurInsert;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem supprimerToolStripMenuItem;
    }
}