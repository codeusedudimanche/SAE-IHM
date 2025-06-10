namespace SAE_IHM.Admin.Modifier
{
    partial class ModifierMotDePasse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierMotDePasse));
            panel1 = new Panel();
            pbAcceuil = new PictureBox();
            btnValiderEmail = new Button();
            lblTitre = new Label();
            txtMDP = new TextBox();
            lblNewMdp = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pbAcceuil);
            panel1.Controls.Add(btnValiderEmail);
            panel1.Controls.Add(lblTitre);
            panel1.Controls.Add(txtMDP);
            panel1.Controls.Add(lblNewMdp);
            panel1.Location = new Point(219, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(607, 499);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // pbAcceuil
            // 
            pbAcceuil.Image = (Image)resources.GetObject("pbAcceuil.Image");
            pbAcceuil.InitialImage = (Image)resources.GetObject("pbAcceuil.InitialImage");
            pbAcceuil.Location = new Point(22, 437);
            pbAcceuil.Name = "pbAcceuil";
            pbAcceuil.Size = new Size(43, 42);
            pbAcceuil.SizeMode = PictureBoxSizeMode.Zoom;
            pbAcceuil.TabIndex = 10;
            pbAcceuil.TabStop = false;
            pbAcceuil.Click += pbAcceuil_Click;
            // 
            // btnValiderEmail
            // 
            btnValiderEmail.Location = new Point(107, 250);
            btnValiderEmail.Name = "btnValiderEmail";
            btnValiderEmail.Size = new Size(385, 29);
            btnValiderEmail.TabIndex = 3;
            btnValiderEmail.Text = "Valider";
            btnValiderEmail.UseVisualStyleBackColor = true;
            btnValiderEmail.Click += btnValiderEmail_Click;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblTitre.Location = new Point(116, 30);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(401, 46);
            lblTitre.TabIndex = 2;
            lblTitre.Text = "Modifier le mot de passe";
            // 
            // txtMDP
            // 
            txtMDP.Location = new Point(107, 199);
            txtMDP.Name = "txtMDP";
            txtMDP.Size = new Size(385, 27);
            txtMDP.TabIndex = 1;
            txtMDP.TextChanged += txtMDP_TextChanged;
            // 
            // lblNewMdp
            // 
            lblNewMdp.AutoSize = true;
            lblNewMdp.Location = new Point(107, 176);
            lblNewMdp.Name = "lblNewMdp";
            lblNewMdp.Size = new Size(235, 20);
            lblNewMdp.TabIndex = 0;
            lblNewMdp.Text = "Saisir votre nouveau mot de passe";
            // 
            // ModifierMotDePasse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Name = "ModifierMotDePasse";
            Text = "ModifierMotDePasse";
            FormClosed += ModifierMotDePasse_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbAcceuil;
        private Button btnValiderEmail;
        private Label lblTitre;
        private TextBox txtMDP;
        private Label lblNewMdp;
    }
}