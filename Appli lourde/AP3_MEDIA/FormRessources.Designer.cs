namespace AP3_MEDIA
{
    partial class FormRessources
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
            dgvRessources = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            voirLesExemplaireToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btnFermer = new Button();
            bsRessources = new BindingSource(components);
            label2 = new Label();
            bsExemplaires = new BindingSource(components);
            dgvExemplaires = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRessources).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsRessources).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsExemplaires).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExemplaires).BeginInit();
            SuspendLayout();
            // 
            // dgvRessources
            // 
            dgvRessources.AllowUserToAddRows = false;
            dgvRessources.AllowUserToDeleteRows = false;
            dgvRessources.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRessources.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRessources.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRessources.ContextMenuStrip = contextMenuStrip1;
            dgvRessources.Location = new Point(58, 41);
            dgvRessources.Name = "dgvRessources";
            dgvRessources.ReadOnly = true;
            dgvRessources.RowTemplate.Height = 25;
            dgvRessources.Size = new Size(670, 215);
            dgvRessources.TabIndex = 0;
            dgvRessources.CellContentClick += dgvRessources_CellContentClick;
            dgvRessources.CellMouseClick += dgvRessources_CellMouseClick;
            dgvRessources.Click += dgvRessources_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { voirLesExemplaireToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // voirLesExemplaireToolStripMenuItem
            // 
            voirLesExemplaireToolStripMenuItem.Name = "voirLesExemplaireToolStripMenuItem";
            voirLesExemplaireToolStripMenuItem.Size = new Size(180, 22);
            voirLesExemplaireToolStripMenuItem.Text = "voir les exemplaires";
            voirLesExemplaireToolStripMenuItem.Click += voirLesExemplaireToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 13);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 1;
            label1.Text = "Liste des Ressources";
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(623, 270);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(105, 55);
            btnFermer.TabIndex = 2;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(58, 270);
            label2.Name = "label2";
            label2.Size = new Size(438, 20);
            label2.TabIndex = 4;
            label2.Text = "click droit sur la ressource sélectionnée pour voir ses exemplaires";
            label2.Click += label2_Click;
            // 
            // dgvExemplaires
            // 
            dgvExemplaires.AllowUserToAddRows = false;
            dgvExemplaires.AllowUserToDeleteRows = false;
            dgvExemplaires.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExemplaires.Location = new Point(524, 51);
            dgvExemplaires.Name = "dgvExemplaires";
            dgvExemplaires.ReadOnly = true;
            dgvExemplaires.RowTemplate.Height = 25;
            dgvExemplaires.Size = new Size(240, 183);
            dgvExemplaires.TabIndex = 5;
            dgvExemplaires.Visible = false;
            // 
            // FormRessources
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 337);
            Controls.Add(dgvExemplaires);
            Controls.Add(label2);
            Controls.Add(btnFermer);
            Controls.Add(label1);
            Controls.Add(dgvRessources);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRessources";
            Text = "Liste des Ressources";
            Load += FormRessources_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRessources).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsRessources).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsExemplaires).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExemplaires).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRessources;
        private Label label1;
        private Button btnFermer;
        private BindingSource bsRessources;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem voirLesExemplaireToolStripMenuItem;
        private Label label2;
        private BindingSource bsExemplaires;
        private DataGridView dgvExemplaires;
    }
}