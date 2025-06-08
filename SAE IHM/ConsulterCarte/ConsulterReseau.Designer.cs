namespace SAE_IHM
{
    partial class ConsulterReseau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsulterReseau));
            panelCarte = new Panel();
            pbAccueil = new PictureBox();
            pbCarte = new PictureBox();
            lblNomLigne = new Label();
            panelCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAccueil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCarte).BeginInit();
            SuspendLayout();
            // 
            // panelCarte
            // 
            panelCarte.BackColor = SystemColors.ControlLightLight;
            panelCarte.Controls.Add(pbAccueil);
            panelCarte.Controls.Add(pbCarte);
            panelCarte.Controls.Add(lblNomLigne);
            panelCarte.Location = new Point(309, 66);
            panelCarte.Name = "panelCarte";
            panelCarte.Size = new Size(678, 684);
            panelCarte.TabIndex = 2;
            // 
            // pbAccueil
            // 
            pbAccueil.Image = (Image)resources.GetObject("pbAccueil.Image");
            pbAccueil.InitialImage = (Image)resources.GetObject("pbAccueil.InitialImage");
            pbAccueil.Location = new Point(34, 617);
            pbAccueil.Name = "pbAccueil";
            pbAccueil.Size = new Size(43, 43);
            pbAccueil.SizeMode = PictureBoxSizeMode.Zoom;
            pbAccueil.TabIndex = 8;
            pbAccueil.TabStop = false;
            pbAccueil.Click += pictureBox2_Click;
            // 
            // pbCarte
            // 
            pbCarte.BackgroundImage = Properties.Resources.Plan_Tulsa1;
            pbCarte.BackgroundImageLayout = ImageLayout.Zoom;
            pbCarte.Location = new Point(83, 101);
            pbCarte.Name = "pbCarte";
            pbCarte.Size = new Size(522, 515);
            pbCarte.TabIndex = 1;
            pbCarte.TabStop = false;
            pbCarte.Click += pictureBox1_Click_1;
            // 
            // lblNomLigne
            // 
            lblNomLigne.AutoSize = true;
            lblNomLigne.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomLigne.Location = new Point(179, 26);
            lblNomLigne.Name = "lblNomLigne";
            lblNomLigne.Size = new Size(322, 46);
            lblNomLigne.TabIndex = 0;
            lblNomLigne.Text = "Consulter le Réseau";
            // 
            // ConsulterReseau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(panelCarte);
            Name = "ConsulterReseau";
            Text = "Consulter le Reseau";
            panelCarte.ResumeLayout(false);
            panelCarte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAccueil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCarte).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCarte;
        private Label lblNomLigne;
        private PictureBox pbCarte;
        private PictureBox pbAccueil;
    }
}