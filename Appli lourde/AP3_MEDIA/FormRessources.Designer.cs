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
            supprimerToolStripMenuItem = new ToolStripMenuItem();
            supprimerToolStripMenuItem1 = new ToolStripMenuItem();
            label1 = new Label();
            btnFermer = new Button();
            bsRessources = new BindingSource(components);
            label2 = new Label();
            bsExemplaires = new BindingSource(components);
            dgvExemplaires = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            btnListeArchive = new Button();
            bsRessourcesArchivees = new BindingSource(components);
            btnRessources = new Button();
            btnAjoutExem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRessources).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsRessources).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsExemplaires).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExemplaires).BeginInit();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsRessourcesArchivees).BeginInit();
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
            dgvRessources.Location = new Point(83, 68);
            dgvRessources.Margin = new Padding(4, 5, 4, 5);
            dgvRessources.Name = "dgvRessources";
            dgvRessources.ReadOnly = true;
            dgvRessources.RowHeadersWidth = 62;
            dgvRessources.RowTemplate.Height = 25;
            dgvRessources.Size = new Size(957, 358);
            dgvRessources.TabIndex = 0;
            dgvRessources.CellContentClick += dgvRessources_CellContentClick;
            dgvRessources.CellMouseClick += dgvRessources_CellMouseClick;
            dgvRessources.Click += dgvRessources_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { voirLesExemplaireToolStripMenuItem, supprimerToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(239, 68);
            // 
            // voirLesExemplaireToolStripMenuItem
            // 
            voirLesExemplaireToolStripMenuItem.Name = "voirLesExemplaireToolStripMenuItem";
            voirLesExemplaireToolStripMenuItem.Size = new Size(238, 32);
            voirLesExemplaireToolStripMenuItem.Text = "voir les exemplaires";
            voirLesExemplaireToolStripMenuItem.Click += voirLesExemplaireToolStripMenuItem_Click;
            // 
            // supprimerToolStripMenuItem
            // 
            supprimerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { supprimerToolStripMenuItem1 });
            supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            supprimerToolStripMenuItem.Size = new Size(238, 32);
            supprimerToolStripMenuItem.Text = "archiver";
            // 
            // supprimerToolStripMenuItem1
            // 
            supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            supprimerToolStripMenuItem1.Size = new Size(195, 34);
            supprimerToolStripMenuItem1.Text = "supprimer";
            supprimerToolStripMenuItem1.Click += supprimerToolStripMenuItem1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(83, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(294, 40);
            label1.TabIndex = 1;
            label1.Text = "Liste des Ressources";
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(992, 486);
            btnFermer.Margin = new Padding(4, 5, 4, 5);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(119, 56);
            btnFermer.TabIndex = 2;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(83, 450);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(677, 31);
            label2.TabIndex = 4;
            label2.Text = "click droit sur la ressource sélectionnée pour voir ses exemplaires";
            // 
            // dgvExemplaires
            // 
            dgvExemplaires.AllowUserToAddRows = false;
            dgvExemplaires.AllowUserToDeleteRows = false;
            dgvExemplaires.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExemplaires.ContextMenuStrip = contextMenuStrip2;
            dgvExemplaires.Location = new Point(439, 85);
            dgvExemplaires.Margin = new Padding(4, 5, 4, 5);
            dgvExemplaires.Name = "dgvExemplaires";
            dgvExemplaires.ReadOnly = true;
            dgvExemplaires.RowHeadersWidth = 62;
            dgvExemplaires.RowTemplate.Height = 25;
            dgvExemplaires.Size = new Size(653, 265);
            dgvExemplaires.TabIndex = 5;
            dgvExemplaires.Visible = false;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(24, 24);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            contextMenuStrip2.Name = "contextMenuStrip1";
            contextMenuStrip2.Size = new Size(146, 36);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3 });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(145, 32);
            toolStripMenuItem2.Text = "archiver";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(195, 34);
            toolStripMenuItem3.Text = "supprimer";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // btnListeArchive
            // 
            btnListeArchive.Location = new Point(83, 503);
            btnListeArchive.Margin = new Padding(4, 5, 4, 5);
            btnListeArchive.Name = "btnListeArchive";
            btnListeArchive.Size = new Size(191, 38);
            btnListeArchive.TabIndex = 6;
            btnListeArchive.Text = "Ressources archivées";
            btnListeArchive.UseVisualStyleBackColor = true;
            btnListeArchive.Click += btnListeArchive_Click;
            // 
            // btnRessources
            // 
            btnRessources.Location = new Point(296, 503);
            btnRessources.Margin = new Padding(4, 5, 4, 5);
            btnRessources.Name = "btnRessources";
            btnRessources.Size = new Size(191, 38);
            btnRessources.TabIndex = 7;
            btnRessources.Text = "Ressources";
            btnRessources.UseVisualStyleBackColor = true;
            btnRessources.Click += btnRessources_Click;
            // 
            // btnAjoutExem
            // 
            btnAjoutExem.Location = new Point(517, 503);
            btnAjoutExem.Margin = new Padding(4, 5, 4, 5);
            btnAjoutExem.Name = "btnAjoutExem";
            btnAjoutExem.Size = new Size(218, 38);
            btnAjoutExem.TabIndex = 9;
            btnAjoutExem.Text = "Ajouter un exemplaire";
            btnAjoutExem.UseVisualStyleBackColor = true;
            btnAjoutExem.Click += btnAjoutExem_Click;
            // 
            // FormRessources
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1143, 562);
            Controls.Add(btnAjoutExem);
            Controls.Add(btnRessources);
            Controls.Add(btnListeArchive);
            Controls.Add(dgvExemplaires);
            Controls.Add(label2);
            Controls.Add(btnFermer);
            Controls.Add(label1);
            Controls.Add(dgvRessources);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormRessources";
            Text = "Liste des Ressources";
            Load += FormRessources_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRessources).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsRessources).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsExemplaires).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExemplaires).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsRessourcesArchivees).EndInit();
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
        private ToolStripMenuItem supprimerToolStripMenuItem;
        private Button btnListeArchive;
        private BindingSource bsRessourcesArchivees;
        private Button btnRessources;
        private ToolStripMenuItem supprimerToolStripMenuItem1;
        private Button btnAjoutExem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}