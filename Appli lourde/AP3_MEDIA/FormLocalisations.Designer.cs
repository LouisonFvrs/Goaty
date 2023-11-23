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
            gbCategorie.Location = new Point(30, 99);
            gbCategorie.Name = "gbCategorie";
            gbCategorie.Size = new Size(278, 182);
            gbCategorie.TabIndex = 26;
            gbCategorie.TabStop = false;
            gbCategorie.Text = "A ajouter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 92);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 12;
            label5.Text = "Adresse";
            // 
            // tbAdresse
            // 
            tbAdresse.Location = new Point(20, 112);
            tbAdresse.Name = "tbAdresse";
            tbAdresse.Size = new Size(236, 23);
            tbAdresse.TabIndex = 11;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(181, 153);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 10;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(100, 153);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 9;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(19, 153);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(75, 23);
            btnValider.TabIndex = 8;
            btnValider.Text = "Ajouter";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 29);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 7;
            label2.Text = "Ville";
            // 
            // tbLibelle
            // 
            tbLibelle.Location = new Point(20, 49);
            tbLibelle.Name = "tbLibelle";
            tbLibelle.Size = new Size(236, 23);
            tbLibelle.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 25;
            label1.Text = "Gestion des villes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(121, 298);
            label4.Name = "label4";
            label4.Size = new Size(368, 20);
            label4.TabIndex = 24;
            label4.Text = "sélectionner une ville pour le modifier ou le supprimer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(351, 19);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 23;
            label3.Text = "Liste existante";
            // 
            // lbLocalisations
            // 
            lbLocalisations.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbLocalisations.FormattingEnabled = true;
            lbLocalisations.ItemHeight = 17;
            lbLocalisations.Location = new Point(351, 39);
            lbLocalisations.Name = "lbLocalisations";
            lbLocalisations.Size = new Size(307, 242);
            lbLocalisations.TabIndex = 22;
            // 
            // btnDeselectionner
            // 
            btnDeselectionner.BackColor = Color.Black;
            btnDeselectionner.FlatStyle = FlatStyle.Popup;
            btnDeselectionner.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeselectionner.ForeColor = Color.White;
            btnDeselectionner.Location = new Point(664, 39);
            btnDeselectionner.Name = "btnDeselectionner";
            btnDeselectionner.Size = new Size(106, 42);
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
            btnFermer.Location = new Point(665, 263);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(105, 55);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 337);
            Controls.Add(gbCategorie);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbLocalisations);
            Controls.Add(btnDeselectionner);
            Controls.Add(btnFermer);
            FormBorderStyle = FormBorderStyle.None;
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