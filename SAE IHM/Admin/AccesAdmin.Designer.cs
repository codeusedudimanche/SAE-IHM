namespace SAE_IHM
{
    partial class AccesAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccesAdmin));
            lblTitre = new Label();
            textBoxIdentifiant = new TextBox();
            textBoxMdp = new TextBox();
            buttonValider = new Button();
            pnlBackround = new Panel();
            pbAccueil = new PictureBox();
            lblMdpOublier = new Label();
            pnlBackround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAccueil).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(44, 23);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(316, 67);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Accès admin";
            // 
            // textBoxIdentifiant
            // 
            textBoxIdentifiant.Location = new Point(44, 142);
            textBoxIdentifiant.Name = "textBoxIdentifiant";
            textBoxIdentifiant.PlaceholderText = "Identifiant";
            textBoxIdentifiant.Size = new Size(316, 27);
            textBoxIdentifiant.TabIndex = 1;
            textBoxIdentifiant.TextChanged += textBoxIdentifiant_TextChanged;
            // 
            // textBoxMdp
            // 
            textBoxMdp.Location = new Point(44, 204);
            textBoxMdp.Name = "textBoxMdp";
            textBoxMdp.PlaceholderText = "Mot de passe";
            textBoxMdp.Size = new Size(316, 27);
            textBoxMdp.TabIndex = 2;
            textBoxMdp.TextChanged += textBoxMdp_TextChanged;
            // 
            // buttonValider
            // 
            buttonValider.Enabled = false;
            buttonValider.Location = new Point(158, 277);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(83, 29);
            buttonValider.TabIndex = 3;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += btnValider_Click;
            // 
            // pnlBackround
            // 
            pnlBackround.BackColor = SystemColors.ControlLightLight;
            pnlBackround.Controls.Add(lblMdpOublier);
            pnlBackround.Controls.Add(pbAccueil);
            pnlBackround.Controls.Add(textBoxMdp);
            pnlBackround.Controls.Add(lblTitre);
            pnlBackround.Controls.Add(textBoxIdentifiant);
            pnlBackround.Controls.Add(buttonValider);
            pnlBackround.Location = new Point(409, 198);
            pnlBackround.Name = "pnlBackround";
            pnlBackround.Size = new Size(402, 379);
            pnlBackround.TabIndex = 6;
            // 
            // pbAccueil
            // 
            pbAccueil.Image = (Image)resources.GetObject("pbAccueil.Image");
            pbAccueil.InitialImage = (Image)resources.GetObject("pbAccueil.InitialImage");
            pbAccueil.Location = new Point(340, 322);
            pbAccueil.Name = "pbAccueil";
            pbAccueil.Size = new Size(43, 42);
            pbAccueil.SizeMode = PictureBoxSizeMode.Zoom;
            pbAccueil.TabIndex = 8;
            pbAccueil.TabStop = false;
            pbAccueil.Click += pbAccueil_Click;
            // 
            // lblMdpOublier
            // 
            lblMdpOublier.AutoSize = true;
            lblMdpOublier.ForeColor = Color.FromArgb(128, 64, 0);
            lblMdpOublier.Location = new Point(44, 245);
            lblMdpOublier.Name = "lblMdpOublier";
            lblMdpOublier.Size = new Size(144, 20);
            lblMdpOublier.TabIndex = 9;
            lblMdpOublier.Text = "Mot de passe oublie";
            lblMdpOublier.Click += lblMdpOublier_Click;
            // 
            // AccesAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(pnlBackround);
            Name = "AccesAdmin";
            Text = "AccesAdmin";
            FormClosing += AccesAdmin_FormClosing;
            Load += AccesAdmin_Load;
            pnlBackround.ResumeLayout(false);
            pnlBackround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAccueil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitre;
        private TextBox textBoxIdentifiant;
        private TextBox textBoxMdp;
        private Button buttonValider;
        private Panel pnlBackround;
        private PictureBox pbAccueil;
        private Label lblMdpOublier;
    }
}