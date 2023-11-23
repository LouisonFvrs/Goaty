namespace AP3_MEDIA
{
    partial class FormEmprunteurs
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
            dgvEmprunteurs = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            toolStripMenuItem2 = new ToolStripMenuItem();
            bsEmprunteurs = new BindingSource(components);
            btnFermer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmprunteurs).BeginInit();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsEmprunteurs).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(61, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(322, 40);
            label1.TabIndex = 4;
            label1.Text = "Liste des emprunteurs";
            // 
            // dgvEmprunteurs
            // 
            dgvEmprunteurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmprunteurs.ContextMenuStrip = contextMenuStrip2;
            dgvEmprunteurs.Location = new Point(103, 99);
            dgvEmprunteurs.Margin = new Padding(4, 5, 4, 5);
            dgvEmprunteurs.Name = "dgvEmprunteurs";
            dgvEmprunteurs.RowHeadersWidth = 62;
            dgvEmprunteurs.RowTemplate.Height = 25;
            dgvEmprunteurs.Size = new Size(937, 365);
            dgvEmprunteurs.TabIndex = 5;
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
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(145, 32);
            toolStripMenuItem2.Text = "archiver";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(998, 489);
            btnFermer.Margin = new Padding(4, 5, 4, 5);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(127, 53);
            btnFermer.TabIndex = 10;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // FormEmprunteurs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1143, 562);
            Controls.Add(btnFermer);
            Controls.Add(dgvEmprunteurs);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormEmprunteurs";
            Text = "FormEmprunteurs";
            Load += FormEmprunteurs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmprunteurs).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsEmprunteurs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvEmprunteurs;
        private BindingSource bsEmprunteurs;
        private Button btnFermer;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}