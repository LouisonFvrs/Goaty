namespace AP3_MEDIA
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            rESSOURCESToolStripMenuItem = new ToolStripMenuItem();
            listeToolStripMenuItem = new ToolStripMenuItem();
            ajoutToolStripMenuItem = new ToolStripMenuItem();
            modificationToolStripMenuItem = new ToolStripMenuItem();
            eMPRUNTEURToolStripMenuItem = new ToolStripMenuItem();
            cATEGORIESToolStripMenuItem = new ToolStripMenuItem();
            qUITTERToolStripMenuItem = new ToolStripMenuItem();
            panelPrincipal = new Panel();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { rESSOURCESToolStripMenuItem, eMPRUNTEURToolStripMenuItem, cATEGORIESToolStripMenuItem, qUITTERToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // rESSOURCESToolStripMenuItem
            // 
            rESSOURCESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeToolStripMenuItem, ajoutToolStripMenuItem, modificationToolStripMenuItem });
            rESSOURCESToolStripMenuItem.Name = "rESSOURCESToolStripMenuItem";
            rESSOURCESToolStripMenuItem.Size = new Size(88, 20);
            rESSOURCESToolStripMenuItem.Text = "RESSOURCES";
            // 
            // listeToolStripMenuItem
            // 
            listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            listeToolStripMenuItem.Size = new Size(142, 22);
            listeToolStripMenuItem.Text = "Liste";
            listeToolStripMenuItem.Click += listeToolStripMenuItem_Click;
            // 
            // ajoutToolStripMenuItem
            // 
            ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            ajoutToolStripMenuItem.Size = new Size(142, 22);
            ajoutToolStripMenuItem.Text = "Ajout";
            ajoutToolStripMenuItem.Click += ajoutToolStripMenuItem_Click;
            // 
            // modificationToolStripMenuItem
            // 
            modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            modificationToolStripMenuItem.Size = new Size(142, 22);
            modificationToolStripMenuItem.Text = "Modification";
            modificationToolStripMenuItem.Click += modificationToolStripMenuItem_Click;
            // 
            // eMPRUNTEURToolStripMenuItem
            // 
            eMPRUNTEURToolStripMenuItem.Name = "eMPRUNTEURToolStripMenuItem";
            eMPRUNTEURToolStripMenuItem.Size = new Size(100, 20);
            eMPRUNTEURToolStripMenuItem.Text = "EMPRUNTEURS";
            eMPRUNTEURToolStripMenuItem.Click += eMPRUNTEURToolStripMenuItem_Click;
            // 
            // cATEGORIESToolStripMenuItem
            // 
            cATEGORIESToolStripMenuItem.Name = "cATEGORIESToolStripMenuItem";
            cATEGORIESToolStripMenuItem.Size = new Size(85, 20);
            cATEGORIESToolStripMenuItem.Text = "CATEGORIES";
            cATEGORIESToolStripMenuItem.Click += cATEGORIESToolStripMenuItem_Click;
            // 
            // qUITTERToolStripMenuItem
            // 
            qUITTERToolStripMenuItem.Name = "qUITTERToolStripMenuItem";
            qUITTERToolStripMenuItem.Size = new Size(64, 20);
            qUITTERToolStripMenuItem.Text = "QUITTER";
            qUITTERToolStripMenuItem.Click += qUITTERToolStripMenuItem_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.LightSteelBlue;
            panelPrincipal.BackgroundImageLayout = ImageLayout.Center;
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Location = new Point(0, 21);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(800, 337);
            panelPrincipal.TabIndex = 2;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(242, 130);
            label1.Name = "label1";
            label1.Size = new Size(337, 32);
            label1.TabIndex = 0;
            label1.Text = "Bienvenue à la Médiathèque";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 358);
            ControlBox = false;
            Controls.Add(panelPrincipal);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMenu";
            Text = "Application MEDIA'TOUT";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem rESSOURCESToolStripMenuItem;
        private ToolStripMenuItem listeToolStripMenuItem;
        private ToolStripMenuItem ajoutToolStripMenuItem;
        private ToolStripMenuItem modificationToolStripMenuItem;
        private ToolStripMenuItem eMPRUNTEURToolStripMenuItem;
        private ToolStripMenuItem cATEGORIESToolStripMenuItem;
        private ToolStripMenuItem qUITTERToolStripMenuItem;
        private Panel panelPrincipal;
        private Label label1;
    }
}