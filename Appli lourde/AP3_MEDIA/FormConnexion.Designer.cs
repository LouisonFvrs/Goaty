namespace AP3_MEDIA
{
    partial class FormConnexion
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbEmail = new TextBox();
            tbMdp = new TextBox();
            btnConnexion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(176, 66);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 0;
            label1.Text = "Connexion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 118);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 185);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Mot de passe";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(178, 136);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(100, 23);
            tbEmail.TabIndex = 3;
            // 
            // tbMdp
            // 
            tbMdp.Location = new Point(178, 203);
            tbMdp.Name = "tbMdp";
            tbMdp.PasswordChar = '*';
            tbMdp.Size = new Size(100, 23);
            tbMdp.TabIndex = 4;
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(191, 247);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(75, 23);
            btnConnexion.TabIndex = 5;
            btnConnexion.Text = "connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // FormConnexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(457, 356);
            Controls.Add(btnConnexion);
            Controls.Add(tbMdp);
            Controls.Add(tbEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormConnexion";
            Text = "FormConnexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbEmail;
        private TextBox tbMdp;
        private Button btnConnexion;
    }
}