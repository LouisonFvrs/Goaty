namespace AP3_MEDIA
{
    partial class FormAuteurs
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
            btnDeselectionner = new Button();
            lbAuteurs = new ListBox();
            label3 = new Label();
            label4 = new Label();
            gbCategorie = new GroupBox();
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnValider = new Button();
            label2 = new Label();
            tbLibelle = new TextBox();
            label1 = new Label();
            bsAuteurs = new BindingSource(components);
            gbCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsAuteurs).BeginInit();
            SuspendLayout();
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(985, 480);
            btnFermer.Margin = new Padding(4, 5, 4, 5);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(129, 59);
            btnFermer.TabIndex = 3;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // btnDeselectionner
            // 
            btnDeselectionner.BackColor = Color.Black;
            btnDeselectionner.FlatStyle = FlatStyle.Popup;
            btnDeselectionner.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeselectionner.ForeColor = Color.White;
            btnDeselectionner.Location = new Point(782, 77);
            btnDeselectionner.Margin = new Padding(4, 5, 4, 5);
            btnDeselectionner.Name = "btnDeselectionner";
            btnDeselectionner.Size = new Size(151, 57);
            btnDeselectionner.TabIndex = 14;
            btnDeselectionner.Text = "Désélectionner";
            btnDeselectionner.UseVisualStyleBackColor = false;
            btnDeselectionner.Click += btnDeselectionner_Click_1;
            // 
            // lbAuteurs
            // 
            lbAuteurs.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbAuteurs.FormattingEnabled = true;
            lbAuteurs.ItemHeight = 28;
            lbAuteurs.Location = new Point(573, 77);
            lbAuteurs.Margin = new Padding(4, 5, 4, 5);
            lbAuteurs.Name = "lbAuteurs";
            lbAuteurs.Size = new Size(201, 396);
            lbAuteurs.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(573, 43);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 16;
            label3.Text = "Liste existante";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(199, 508);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(579, 31);
            label4.TabIndex = 17;
            label4.Text = "sélectionner un auteur pour le modifier ou le supprimer";
            // 
            // gbCategorie
            // 
            gbCategorie.Controls.Add(btnSupprimer);
            gbCategorie.Controls.Add(btnModifier);
            gbCategorie.Controls.Add(btnValider);
            gbCategorie.Controls.Add(label2);
            gbCategorie.Controls.Add(tbLibelle);
            gbCategorie.Location = new Point(69, 177);
            gbCategorie.Margin = new Padding(4, 5, 4, 5);
            gbCategorie.Name = "gbCategorie";
            gbCategorie.Padding = new Padding(4, 5, 4, 5);
            gbCategorie.Size = new Size(397, 215);
            gbCategorie.TabIndex = 19;
            gbCategorie.TabStop = false;
            gbCategorie.Text = "A ajouter";
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(259, 150);
            btnSupprimer.Margin = new Padding(4, 5, 4, 5);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(107, 38);
            btnSupprimer.TabIndex = 10;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click_1;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(144, 150);
            btnModifier.Margin = new Padding(4, 5, 4, 5);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(107, 38);
            btnModifier.TabIndex = 9;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click_1;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(29, 150);
            btnValider.Margin = new Padding(4, 5, 4, 5);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(107, 38);
            btnValider.TabIndex = 8;
            btnValider.Text = "Ajouter";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 7;
            label2.Text = "Nom";
            // 
            // tbLibelle
            // 
            tbLibelle.Location = new Point(29, 82);
            tbLibelle.Margin = new Padding(4, 5, 4, 5);
            tbLibelle.Name = "tbLibelle";
            tbLibelle.Size = new Size(335, 31);
            tbLibelle.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(289, 40);
            label1.TabIndex = 18;
            label1.Text = "Gestion des auteurs";
            // 
            // bsAuteurs
            // 
            bsAuteurs.CurrentChanged += bsAuteurs_CurrentChanged_1;
            // 
            // FormAuteurs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1143, 562);
            Controls.Add(gbCategorie);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbAuteurs);
            Controls.Add(btnDeselectionner);
            Controls.Add(btnFermer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormAuteurs";
            Text = "FormAuteurs";
            Load += FormAuteurs_Load_1;
            gbCategorie.ResumeLayout(false);
            gbCategorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsAuteurs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFermer;
        private Button btnDeselectionner;
        private ListBox lbAuteurs;
        private Label label3;
        private Label label4;
        private GroupBox gbCategorie;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnValider;
        private Label label2;
        private TextBox tbLibelle;
        private Label label1;
        private BindingSource bsAuteurs;
    }
}