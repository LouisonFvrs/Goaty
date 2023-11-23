namespace AP3_MEDIA
{
    partial class FormLocalisations
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
            gbCategorie = new GroupBox();
            label5 = new Label();
            tbAdresse = new TextBox();
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnValider = new Button();
            label2 = new Label();
            tbLibelle = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            lbLocalisations = new ListBox();
            btnDeselectionner = new Button();
            btnFermer = new Button();
            bsLocalisations = new BindingSource(components);
            gbCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsLocalisations).BeginInit();
            SuspendLayout();
            // 
            // gbCategorie
            // 
            gbCategorie.Controls.Add(label5);
            gbCategorie.Controls.Add(tbAdresse);
            gbCategorie.Controls.Add(btnSupprimer);
            gbCategorie.Controls.Add(btnModifier);
            gbCategorie.Controls.Add(btnValider);
            gbCategorie.Controls.Add(label2);
            gbCategorie.Controls.Add(tbLibelle);
            gbCategorie.Location = new Point(43, 165);
            gbCategorie.Margin = new Padding(4, 5, 4, 5);
            gbCategorie.Name = "gbCategorie";
            gbCategorie.Padding = new Padding(4, 5, 4, 5);
            gbCategorie.Size = new Size(397, 303);
            gbCategorie.TabIndex = 26;
            gbCategorie.TabStop = false;
            gbCategorie.Text = "A ajouter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 153);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 28);
            label5.TabIndex = 12;
            label5.Text = "Adresse";
            // 
            // tbAdresse
            // 
            tbAdresse.Location = new Point(29, 187);
            tbAdresse.Margin = new Padding(4, 5, 4, 5);
            tbAdresse.Name = "tbAdresse";
            tbAdresse.Size = new Size(335, 31);
            tbAdresse.TabIndex = 11;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(259, 255);
            btnSupprimer.Margin = new Padding(4, 5, 4, 5);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(107, 38);
            btnSupprimer.TabIndex = 10;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(143, 255);
            btnModifier.Margin = new Padding(4, 5, 4, 5);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(107, 38);
            btnModifier.TabIndex = 9;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(27, 255);
            btnValider.Margin = new Padding(4, 5, 4, 5);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(107, 38);
            btnValider.TabIndex = 8;
            btnValider.Text = "Ajouter";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 28);
            label2.TabIndex = 7;
            label2.Text = "Ville";
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
            label1.Location = new Point(43, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(254, 40);
            label1.TabIndex = 25;
            label1.Text = "Gestion des villes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(173, 497);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(566, 31);
            label4.TabIndex = 24;
            label4.Text = "sélectionner une ville pour la modifier ou la supprimer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(501, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 23;
            label3.Text = "Liste existante";
            // 
            // lbLocalisations
            // 
            lbLocalisations.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbLocalisations.FormattingEnabled = true;
            lbLocalisations.ItemHeight = 28;
            lbLocalisations.Location = new Point(501, 65);
            lbLocalisations.Margin = new Padding(4, 5, 4, 5);
            lbLocalisations.Name = "lbLocalisations";
            lbLocalisations.Size = new Size(437, 396);
            lbLocalisations.TabIndex = 22;
            // 
            // btnDeselectionner
            // 
            btnDeselectionner.BackColor = Color.Black;
            btnDeselectionner.FlatStyle = FlatStyle.Popup;
            btnDeselectionner.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeselectionner.ForeColor = Color.White;
            btnDeselectionner.Location = new Point(950, 65);
            btnDeselectionner.Margin = new Padding(4, 5, 4, 5);
            btnDeselectionner.Name = "btnDeselectionner";
            btnDeselectionner.Size = new Size(151, 54);
            btnDeselectionner.TabIndex = 21;
            btnDeselectionner.Text = "Désélectionner";
            btnDeselectionner.UseVisualStyleBackColor = false;
            btnDeselectionner.Click += btnDeselectionner_Click;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(996, 485);
            btnFermer.Margin = new Padding(4, 5, 4, 5);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(124, 54);
            btnFermer.TabIndex = 20;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // bsLocalisations
            // 
            bsLocalisations.CurrentChanged += bsLocalisations_CurrentChanged;
            // 
            // FormLocalisations
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1143, 562);
            Controls.Add(gbCategorie);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbLocalisations);
            Controls.Add(btnDeselectionner);
            Controls.Add(btnFermer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormLocalisations";
            Text = "FormLocalisations";
            Load += FormLocalisations_Load;
            gbCategorie.ResumeLayout(false);
            gbCategorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsLocalisations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbCategorie;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnValider;
        private Label label2;
        private TextBox tbLibelle;
        private Label label1;
        private Label label4;
        private Label label3;
        private ListBox lbLocalisations;
        private Button btnDeselectionner;
        private Button btnFermer;
        private BindingSource bsLocalisations;
        private Label label5;
        private TextBox tbAdresse;
    }
}