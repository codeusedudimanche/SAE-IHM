namespace SAE_IHM
{
    partial class AdminModifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminModifier));
            pnlBackround = new Panel();
            pbAcceuil = new PictureBox();
            lblHoraire = new Label();
            lblLigne = new Label();
            lblTitre = new Label();
            pbAjoutLigne = new PictureBox();
            pbAjoutArret = new PictureBox();
            pbHorraire = new PictureBox();
            lblArret = new Label();
            pnlBackround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAjoutLigne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAjoutArret).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHorraire).BeginInit();
            SuspendLayout();
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
            pnlBackround.Location = new Point(233, 275);
            pnlBackround.Name = "pnlBackround";
            pnlBackround.Size = new Size(598, 372);
            pnlBackround.TabIndex = 5;
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
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(194, 23);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(224, 67);
            lblTitre.TabIndex = 3;
            lblTitre.Text = "Modifier";
            // 
            // pbAjoutLigne
            // 
            pbAjoutLigne.BackColor = SystemColors.AppWorkspace;
            pbAjoutLigne.Location = new Point(238, 159);
            pbAjoutLigne.Name = "pbAjoutLigne";
            pbAjoutLigne.Size = new Size(125, 62);
            pbAjoutLigne.TabIndex = 1;
            pbAjoutLigne.TabStop = false;
            // 
            // pbAjoutArret
            // 
            pbAjoutArret.BackColor = SystemColors.AppWorkspace;
            pbAjoutArret.Location = new Point(52, 159);
            pbAjoutArret.Name = "pbAjoutArret";
            pbAjoutArret.Size = new Size(125, 62);
            pbAjoutArret.TabIndex = 2;
            pbAjoutArret.TabStop = false;
            // 
            // pbHorraire
            // 
            pbHorraire.BackColor = SystemColors.AppWorkspace;
            pbHorraire.Location = new Point(424, 159);
            pbHorraire.Name = "pbHorraire";
            pbHorraire.Size = new Size(125, 62);
            pbHorraire.TabIndex = 0;
            pbHorraire.TabStop = false;
            // 
            // lblArret
            // 
            lblArret.AutoSize = true;
            lblArret.Location = new Point(91, 245);
            lblArret.Name = "lblArret";
            lblArret.Size = new Size(42, 20);
            lblArret.TabIndex = 4;
            lblArret.Text = "Arrêt";
            // 
            // AdminModifier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(pnlBackround);
            Name = "AdminModifier";
            Text = "AdminModifier";
            FormClosing += AdminModifier_FormClosing;
            FormClosed += AdminModifier_FormClosed;
            Load += AdminModifier_Load;
            pnlBackround.ResumeLayout(false);
            pnlBackround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAjoutLigne).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAjoutArret).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHorraire).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBackround;
        private PictureBox pbAcceuil;
        private Label lblHoraire;
        private Label lblLigne;
        private Label lblTitre;
        private PictureBox pbAjoutLigne;
        private PictureBox pbAjoutArret;
        private PictureBox pbHorraire;
        private Label lblArret;
    }
}