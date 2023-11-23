namespace AP3_MEDIA
{
    partial class FormCategories
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
            label3 = new Label();
            bsCategories = new BindingSource(components);
            tbLibelle = new TextBox();
            label2 = new Label();
            lbCategories = new ListBox();
            btnFermer = new Button();
            gbCategorie = new GroupBox();
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnValider = new Button();
            label4 = new Label();
            btnDeselectionner = new Button();
            ((System.ComponentModel.ISupportInitialize)bsCategories).BeginInit();
            gbCategorie.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(61, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(327, 40);
            label1.TabIndex = 3;
            label1.Text = "Gestion des catégories";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(571, 43);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 5;
            label3.Text = "Liste existante";
            // 
            // bsCategories
            // 
            bsCategories.CurrentChanged += bsCategories_CurrentChanged;
            // 
            // tbLibelle
            // 
            tbLibelle.Location = new Point(29, 82);
            tbLibelle.Margin = new Padding(4, 5, 4, 5);
            tbLibelle.Name = "tbLibelle";
            tbLibelle.Size = new Size(335, 31);
            tbLibelle.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 7;
            label2.Text = "Libellé ";
            // 
            // lbCategories
            // 
            lbCategories.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbCategories.FormattingEnabled = true;
            lbCategories.ItemHeight = 28;
            lbCategories.Location = new Point(571, 77);
            lbCategories.Margin = new Padding(4, 5, 4, 5);
            lbCategories.Name = "lbCategories";
            lbCategories.Size = new Size(201, 396);
            lbCategories.TabIndex = 8;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(991, 485);
            btnFermer.Margin = new Padding(4, 5, 4, 5);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(115, 61);
            btnFermer.TabIndex = 9;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // gbCategorie
            // 
            gbCategorie.Controls.Add(btnSupprimer);
            gbCategorie.Controls.Add(btnModifier);
            gbCategorie.Controls.Add(btnValider);
            gbCategorie.Controls.Add(label2);
            gbCategorie.Controls.Add(tbLibelle);
            gbCategorie.Location = new Point(61, 167);
            gbCategorie.Margin = new Padding(4, 5, 4, 5);
            gbCategorie.Name = "gbCategorie";
            gbCategorie.Padding = new Padding(4, 5, 4, 5);
            gbCategorie.Size = new Size(397, 215);
            gbCategorie.TabIndex = 11;
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
            btnSupprimer.Click += btnSupprimer_Click;
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
            btnModifier.Click += btnModifier_Click;
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
            btnValider.Click += btnValider_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(197, 485);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(621, 31);
            label4.TabIndex = 12;
            label4.Text = "sélectionner une catégorie pour la modifier ou la supprimer";
            // 
            // btnDeselectionner
            // 
            btnDeselectionner.BackColor = Color.Black;
            btnDeselectionner.FlatStyle = FlatStyle.Popup;
            btnDeselectionner.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeselectionner.ForeColor = Color.White;
            btnDeselectionner.Location = new Point(783, 77);
            btnDeselectionner.Margin = new Padding(4, 5, 4, 5);
            btnDeselectionner.Name = "btnDeselectionner";
            btnDeselectionner.Size = new Size(164, 49);
            btnDeselectionner.TabIndex = 13;
            btnDeselectionner.Text = "Désélectionner";
            btnDeselectionner.UseVisualStyleBackColor = false;
            btnDeselectionner.Click += btnDeselectionner_Click;
            // 
            // FormCategories
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1143, 562);
            Controls.Add(btnDeselectionner);
            Controls.Add(label4);
            Controls.Add(gbCategorie);
            Controls.Add(btnFermer);
            Controls.Add(lbCategories);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormCategories";
            Text = "Gestion des catégories";
            Load += FormCategories_Load;
            ((System.ComponentModel.ISupportInitialize)bsCategories).EndInit();
            gbCategorie.ResumeLayout(false);
            gbCategorie.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private BindingSource bsCategories;
        private TextBox tbLibelle;
        private Label label2;
        private ListBox lbCategories;
        private Button btnFermer;
        private GroupBox gbCategorie;
        private Label label4;
        private Button btnValider;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnDeselectionner;
    }
}