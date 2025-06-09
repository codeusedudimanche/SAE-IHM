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
            lblArret = new Label();
            lblTitre = new Label();
            pbModifierLigne = new PictureBox();
            pbModifierArret = new PictureBox();
            pbModifierHorraire = new PictureBox();
            pnlBackround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbModifierLigne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbModifierArret).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbModifierHorraire).BeginInit();
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
            pnlBackround.Controls.Add(pbModifierLigne);
            pnlBackround.Controls.Add(pbModifierArret);
            pnlBackround.Controls.Add(pbModifierHorraire);
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
            // lblArret
            // 
            lblArret.AutoSize = true;
            lblArret.Location = new Point(91, 245);
            lblArret.Name = "lblArret";
            lblArret.Size = new Size(42, 20);
            lblArret.TabIndex = 4;
            lblArret.Text = "Arrêt";
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
            // pbModifierLigne
            // 
            pbModifierLigne.BackColor = Color.White;
            pbModifierLigne.Image = (Image)resources.GetObject("pbModifierLigne.Image");
            pbModifierLigne.Location = new Point(238, 159);
            pbModifierLigne.Name = "pbModifierLigne";
            pbModifierLigne.Size = new Size(125, 62);
            pbModifierLigne.SizeMode = PictureBoxSizeMode.Zoom;
            pbModifierLigne.TabIndex = 1;
            pbModifierLigne.TabStop = false;
            pbModifierLigne.Click += pbModifierLigne_Click;
            // 
            // pbModifierArret
            // 
            pbModifierArret.BackColor = Color.White;
            pbModifierArret.Image = (Image)resources.GetObject("pbModifierArret.Image");
            pbModifierArret.Location = new Point(52, 159);
            pbModifierArret.Name = "pbModifierArret";
            pbModifierArret.Size = new Size(125, 62);
            pbModifierArret.SizeMode = PictureBoxSizeMode.Zoom;
            pbModifierArret.TabIndex = 2;
            pbModifierArret.TabStop = false;
            pbModifierArret.Click += pbModifierArret_Click;
            // 
            // pbModifierHorraire
            // 
            pbModifierHorraire.BackColor = Color.White;
            pbModifierHorraire.Image = (Image)resources.GetObject("pbModifierHorraire.Image");
            pbModifierHorraire.Location = new Point(424, 159);
            pbModifierHorraire.Name = "pbModifierHorraire";
            pbModifierHorraire.Size = new Size(125, 62);
            pbModifierHorraire.SizeMode = PictureBoxSizeMode.Zoom;
            pbModifierHorraire.TabIndex = 0;
            pbModifierHorraire.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pbModifierLigne).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbModifierArret).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbModifierHorraire).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBackround;
        private PictureBox pbAcceuil;
        private Label lblHoraire;
        private Label lblLigne;
        private Label lblTitre;
        private PictureBox pbModifierLigne;
        private PictureBox pbModifierArret;
        private PictureBox pbModifierHorraire;
        private Label lblArret;
    }
}