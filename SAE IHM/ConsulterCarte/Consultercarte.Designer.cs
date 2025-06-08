namespace SAE_IHM
{
    partial class Consultercarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultercarte));
            lblTitre = new Label();
            btnReseauComplet = new Button();
            btnLigne = new Button();
            btnHoraires = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            pnlBackround = new Panel();
            pbAccueil = new PictureBox();
            pnlBackround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAccueil).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 30F);
            lblTitre.Location = new Point(0, 31);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(429, 67);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Consulter la carte";
            lblTitre.Click += label1_Click;
            // 
            // btnReseauComplet
            // 
            btnReseauComplet.Location = new Point(112, 236);
            btnReseauComplet.Name = "btnReseauComplet";
            btnReseauComplet.Size = new Size(198, 29);
            btnReseauComplet.TabIndex = 1;
            btnReseauComplet.Text = "Le réseau complet";
            btnReseauComplet.UseVisualStyleBackColor = true;
            btnReseauComplet.Click += btnReseauComplet_Click;
            // 
            // btnLigne
            // 
            btnLigne.Location = new Point(112, 136);
            btnLigne.Name = "btnLigne";
            btnLigne.Size = new Size(198, 29);
            btnLigne.TabIndex = 2;
            btnLigne.Text = "Une ligne particulière";
            btnLigne.UseVisualStyleBackColor = true;
            btnLigne.Click += btnLigne_Click;
            // 
            // btnHoraires
            // 
            btnHoraires.Location = new Point(112, 185);
            btnHoraires.Name = "btnHoraires";
            btnHoraires.Size = new Size(198, 29);
            btnHoraires.TabIndex = 3;
            btnHoraires.Text = "Les horaires";
            btnHoraires.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 5;
            // 
            // pnlBackround
            // 
            pnlBackround.BackColor = SystemColors.ControlLightLight;
            pnlBackround.Controls.Add(pbAccueil);
            pnlBackround.Controls.Add(btnLigne);
            pnlBackround.Controls.Add(lblTitre);
            pnlBackround.Controls.Add(btnReseauComplet);
            pnlBackround.Controls.Add(btnHoraires);
            pnlBackround.Location = new Point(402, 177);
            pnlBackround.Name = "pnlBackround";
            pnlBackround.Size = new Size(424, 379);
            pnlBackround.TabIndex = 7;
            // 
            // pbAccueil
            // 
            pbAccueil.Image = (Image)resources.GetObject("pbAccueil.Image");
            pbAccueil.InitialImage = (Image)resources.GetObject("pbAccueil.InitialImage");
            pbAccueil.Location = new Point(361, 318);
            pbAccueil.Name = "pbAccueil";
            pbAccueil.Size = new Size(43, 42);
            pbAccueil.SizeMode = PictureBoxSizeMode.Zoom;
            pbAccueil.TabIndex = 8;
            pbAccueil.TabStop = false;
            pbAccueil.Click += pictureBox1_Click;
            // 
            // Consultercarte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(pnlBackround);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Name = "Consultercarte";
            Text = "Consulter la carte";
            FormClosing += Consultercarte_FormClosing;
            pnlBackround.ResumeLayout(false);
            pnlBackround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAccueil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private Button btnReseauComplet;
        private Button btnLigne;
        private Button btnHoraires;
        private LinkLabel linkLabel1;
        private Label label2;
        private Button btnRetour;
        private Panel pnlBackround;
        private Panel panel2;
        private PictureBox pbAccueil;
    }
}