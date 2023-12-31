﻿namespace AP3_MEDIA
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
            btnValider = new Button();
            bsRessource = new BindingSource(components);
            bsEtat = new BindingSource(components);
            bsExemplaire = new BindingSource(components);
            cbRessource = new ComboBox();
            cbEtat = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpEntree = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            cbLocalisation = new ComboBox();
            bsLocalisation = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsRessource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEtat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsExemplaire).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsLocalisation).BeginInit();
            SuspendLayout();
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(253, 550);
            btnFermer.Margin = new Padding(4, 5, 4, 5);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(107, 38);
            btnFermer.TabIndex = 0;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click_1;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(17, 550);
            btnValider.Margin = new Padding(4, 5, 4, 5);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(107, 38);
            btnValider.TabIndex = 1;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click_1;
            // 
            // cbRessource
            // 
            cbRessource.FormattingEnabled = true;
            cbRessource.Location = new Point(17, 137);
            cbRessource.Margin = new Padding(4, 5, 4, 5);
            cbRessource.Name = "cbRessource";
            cbRessource.Size = new Size(233, 33);
            cbRessource.TabIndex = 2;
            // 
            // cbEtat
            // 
            cbEtat.FormattingEnabled = true;
            cbEtat.Location = new Point(17, 238);
            cbEtat.Margin = new Padding(4, 5, 4, 5);
            cbEtat.Name = "cbEtat";
            cbEtat.Size = new Size(171, 33);
            cbEtat.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 107);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 4;
            label1.Text = "Ressource";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 208);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 5;
            label2.Text = "Etat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 45);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 6;
            label3.Text = "Ajouter un exemplaire";
            // 
            // dtpEntree
            // 
            dtpEntree.Location = new Point(17, 453);
            dtpEntree.Margin = new Padding(4, 5, 4, 5);
            dtpEntree.Name = "dtpEntree";
            dtpEntree.Size = new Size(284, 31);
            dtpEntree.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 405);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 8;
            label4.Text = "Date entrée ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 305);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 10;
            label5.Text = "Localisation";
            // 
            // cbLocalisation
            // 
            cbLocalisation.FormattingEnabled = true;
            cbLocalisation.Location = new Point(17, 335);
            cbLocalisation.Margin = new Padding(4, 5, 4, 5);
            cbLocalisation.Name = "cbLocalisation";
            cbLocalisation.Size = new Size(171, 33);
            cbLocalisation.TabIndex = 9;
            // 
            // FormExemplaire
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(377, 608);
            Controls.Add(label5);
            Controls.Add(cbLocalisation);
            Controls.Add(label4);
            Controls.Add(dtpEntree);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbEtat);
            Controls.Add(cbRessource);
            Controls.Add(btnValider);
            Controls.Add(btnFermer);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormExemplaire";
            Text = "FormExemplaire";
            Load += FormExemplaire_Load;
            ((System.ComponentModel.ISupportInitialize)bsRessource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEtat).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsExemplaire).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsLocalisation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFermer;
        private Button btnValider;
        private BindingSource bsRessource;
        private BindingSource bsEtat;
        private BindingSource bsExemplaire;
        private ComboBox cbRessource;
        private ComboBox cbEtat;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpEntree;
        private Label label4;
        private Label label5;
        private ComboBox cbLocalisation;
        private BindingSource bsLocalisation;
    }
}