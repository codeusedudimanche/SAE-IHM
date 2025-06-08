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
            panel1 = new Panel();
            pbAcceuil = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblTitre = new Label();
            pbAjoutLigne = new PictureBox();
            pbAjoutArret = new PictureBox();
            pbHorraire = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAjoutLigne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAjoutArret).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHorraire).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(pbAcceuil);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTitre);
            panel1.Controls.Add(pbAjoutLigne);
            panel1.Controls.Add(pbAjoutArret);
            panel1.Controls.Add(pbHorraire);
            panel1.Location = new Point(233, 275);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 372);
            panel1.TabIndex = 5;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(456, 245);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 6;
            label4.Text = "Horaire";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 245);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "Ligne";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 245);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "Arrêt";
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
            // AdminModifier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Name = "AdminModifier";
            Text = "AdminModifier";
            Load += AdminModifier_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAjoutLigne).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAjoutArret).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHorraire).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbAcceuil;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblTitre;
        private PictureBox pbAjoutLigne;
        private PictureBox pbAjoutArret;
        private PictureBox pbHorraire;
    }
}