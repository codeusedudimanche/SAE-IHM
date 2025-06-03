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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblNomLigne = new Label();
            panelCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelCarte
            // 
            panelCarte.BackColor = SystemColors.ControlLightLight;
            panelCarte.Controls.Add(pictureBox2);
            panelCarte.Controls.Add(pictureBox1);
            panelCarte.Controls.Add(lblNomLigne);
            panelCarte.Location = new Point(309, 66);
            panelCarte.Name = "panelCarte";
            panelCarte.Size = new Size(678, 684);
            panelCarte.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(34, 617);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Plan_Tulsa1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(83, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(522, 515);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
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
            Text = "ConsulterReseau";
            panelCarte.ResumeLayout(false);
            panelCarte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCarte;
        private Label lblNomLigne;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}