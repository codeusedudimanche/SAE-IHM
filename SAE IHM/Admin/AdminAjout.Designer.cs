namespace SAE_IHM
{
    partial class AdminAjout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAjout));
            pbHorraire = new PictureBox();
            pbAjoutLigne = new PictureBox();
            pbAjoutArret = new PictureBox();
            lblTitre = new Label();
            pnlBackround = new Panel();
            pbAcceuil = new PictureBox();
            lblHoraire = new Label();
            lblLigne = new Label();
            lblArret = new Label();
            ((System.ComponentModel.ISupportInitialize)pbHorraire).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAjoutLigne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAjoutArret).BeginInit();
            pnlBackround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).BeginInit();
            SuspendLayout();
            // 
            // pbHorraire
            // 
            pbHorraire.BackColor = Color.Transparent;
            pbHorraire.BackgroundImage = Properties.Resources.temps;
            pbHorraire.BackgroundImageLayout = ImageLayout.Zoom;
            pbHorraire.Location = new Point(424, 159);
            pbHorraire.Name = "pbHorraire";
            pbHorraire.Size = new Size(125, 62);
            pbHorraire.TabIndex = 0;
            pbHorraire.TabStop = false;
            pbHorraire.Click += pbHoraire_Click;
            // 
            // pbAjoutLigne
            // 
            pbAjoutLigne.BackColor = Color.Transparent;
            pbAjoutLigne.BackgroundImage = Properties.Resources.feuille_de_route;
            pbAjoutLigne.BackgroundImageLayout = ImageLayout.Zoom;
            pbAjoutLigne.Location = new Point(238, 159);
            pbAjoutLigne.Name = "pbAjoutLigne";
            pbAjoutLigne.Size = new Size(125, 62);
            pbAjoutLigne.TabIndex = 1;
            pbAjoutLigne.TabStop = false;
            pbAjoutLigne.Click += pbAjoutLigne_Click;
            // 
            // pbAjoutArret
            // 
            pbAjoutArret.BackColor = Color.Transparent;
            pbAjoutArret.BackgroundImage = Properties.Resources.emplacement;
            pbAjoutArret.BackgroundImageLayout = ImageLayout.Zoom;
            pbAjoutArret.Location = new Point(52, 159);
            pbAjoutArret.Name = "pbAjoutArret";
            pbAjoutArret.Size = new Size(125, 62);
            pbAjoutArret.TabIndex = 2;
            pbAjoutArret.TabStop = false;
            pbAjoutArret.Click += pbAjoutArret_Click;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(194, 23);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(199, 67);
            lblTitre.TabIndex = 3;
            lblTitre.Text = "Ajouter";
            // 
            // pnlBackround
            // 
            pnlBackround.BackColor = SystemColors.ControlLightLight;
            pnlBackround.Controls.Add(pbAcceuil);
            pnlBackround.Controls.Add(lblHoraire);
            pnlBackround.Controls.Add(lblLigne);
            pnlBackround.Controls.Add(lblArret);
            pnlBackround.Controls.Add(lblTitre);
            pnlBackround.Controls.Add(pbAjoutLigne);
            pnlBackround.Controls.Add(pbAjoutArret);
            pnlBackround.Controls.Add(pbHorraire);
            pnlBackround.Location = new Point(303, 135);
            pnlBackround.Name = "pnlBackround";
            pnlBackround.Size = new Size(598, 372);
            pnlBackround.TabIndex = 4;
            pnlBackround.Paint += panel1_Paint;
            // 
            // pbAcceuil
            // 
            pbAcceuil.Image = (Image)resources.GetObject("pbAcceuil.Image");
            pbAcceuil.InitialImage = (Image)resources.GetObject("pbAcceuil.InitialImage");
            pbAcceuil.Location = new Point(26, 315);
            pbAcceuil.Name = "pbAcceuil";
            pbAcceuil.Size = new Size(43, 42);
            pbAcceuil.SizeMode = PictureBoxSizeMode.Zoom;
            pbAcceuil.TabIndex = 11;
            pbAcceuil.TabStop = false;
            pbAcceuil.Click += pbAcceuil_Click;
            // 
            // lblHoraire
            // 
            lblHoraire.AutoSize = true;
            lblHoraire.Location = new Point(456, 245);
            lblHoraire.Name = "lblHoraire";
            lblHoraire.Size = new Size(59, 20);
            lblHoraire.TabIndex = 6;
            lblHoraire.Text = "Horaire";
            // 
            // lblLigne
            // 
            lblLigne.AutoSize = true;
            lblLigne.Location = new Point(275, 245);
            lblLigne.Name = "lblLigne";
            lblLigne.Size = new Size(45, 20);
            lblLigne.TabIndex = 5;
            lblLigne.Text = "Ligne";
            lblLigne.Click += label3_Click;
            // 
            // lblArret
            // 
            lblArret.AutoSize = true;
            lblArret.Location = new Point(91, 245);
            lblArret.Name = "lblArret";
            lblArret.Size = new Size(42, 20);
            lblArret.TabIndex = 4;
            lblArret.Text = "Arrêt";
            lblArret.Click += label2_Click;
            // 
            // AdminAjout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(pnlBackround);
            Name = "AdminAjout";
            Text = "AdminAjout";
            FormClosed += AdminAjout_FormClosed;
            Load += AdminAjout_Load;
            ((System.ComponentModel.ISupportInitialize)pbHorraire).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAjoutLigne).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAjoutArret).EndInit();
            pnlBackround.ResumeLayout(false);
            pnlBackround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbHorraire;
        private PictureBox pbAjoutLigne;
        private PictureBox pbAjoutArret;
        private Label lblTitre;
        private Panel pnlBackround;
        private Label lblArret;
        private Label lblLigne;
        private Label lblHoraire;
        private PictureBox pbAcceuil;
    }
}