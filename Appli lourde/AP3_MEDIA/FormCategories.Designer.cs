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
            ((System.ComponentModel.ISupportInitialize)bsCategories).BeginInit();
            gbCategorie.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 20);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 3;
            label1.Text = "Gestion des catégories";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(400, 26);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 5;
            label3.Text = "Liste existante";
            // 
            // bsCategories
            // 
            bsCategories.CurrentChanged += bsCategories_CurrentChanged;
            // 
            // tbLibelle
            // 
            tbLibelle.Location = new Point(20, 49);
            tbLibelle.Name = "tbLibelle";
            tbLibelle.Size = new Size(236, 23);
            tbLibelle.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 29);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 7;
            label2.Text = "Libellé ";
            // 
            // lbCategories
            // 
            lbCategories.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbCategories.FormattingEnabled = true;
            lbCategories.ItemHeight = 17;
            lbCategories.Location = new Point(400, 46);
            lbCategories.Name = "lbCategories";
            lbCategories.Size = new Size(142, 242);
            lbCategories.TabIndex = 8;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(633, 250);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(105, 55);
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
            gbCategorie.Location = new Point(43, 100);
            gbCategorie.Name = "gbCategorie";
            gbCategorie.Size = new Size(278, 129);
            gbCategorie.TabIndex = 11;
            gbCategorie.TabStop = false;
            gbCategorie.Text = "A ajouter";
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(181, 90);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 10;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(101, 90);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 9;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(20, 90);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(75, 23);
            btnValider.TabIndex = 8;
            btnValider.Text = "Ajouter";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(138, 291);
            label4.Name = "label4";
            label4.Size = new Size(404, 20);
            label4.TabIndex = 12;
            label4.Text = "sélectionner une catégorie pour la modifier ou la supprimer";
            // 
            // FormCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 337);
            Controls.Add(label4);
            Controls.Add(gbCategorie);
            Controls.Add(btnFermer);
            Controls.Add(lbCategories);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
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
    }
}