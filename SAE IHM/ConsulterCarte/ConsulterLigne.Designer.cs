namespace SAE_IHM
{
    partial class ConsulterLigne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsulterLigne));
            pnlBackroundConsulter = new Panel();
            pictureBox2 = new PictureBox();
            cbLigne = new ComboBox();
            lblSelectionezLigne = new Label();
            lblConsulterLigne = new Label();
            panelCarte = new Panel();
            lblCliquez = new Label();
            pbCarte = new PictureBox();
            lblNomLigne = new Label();
            pnlBackroundConsulter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCarte).BeginInit();
            SuspendLayout();
            // 
            // pnlBackroundConsulter
            // 
            pnlBackroundConsulter.BackColor = SystemColors.ControlLightLight;
            pnlBackroundConsulter.Controls.Add(pictureBox2);
            pnlBackroundConsulter.Controls.Add(cbLigne);
            pnlBackroundConsulter.Controls.Add(lblSelectionezLigne);
            pnlBackroundConsulter.Controls.Add(lblConsulterLigne);
            pnlBackroundConsulter.Location = new Point(54, 103);
            pnlBackroundConsulter.Name = "pnlBackroundConsulter";
            pnlBackroundConsulter.Size = new Size(428, 289);
            pnlBackroundConsulter.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(45, 218);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // cbLigne
            // 
            cbLigne.FormattingEnabled = true;
            cbLigne.Location = new Point(45, 164);
            cbLigne.Name = "cbLigne";
            cbLigne.Size = new Size(345, 28);
            cbLigne.TabIndex = 3;
            cbLigne.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // lblSelectionezLigne
            // 
            lblSelectionezLigne.AutoSize = true;
            lblSelectionezLigne.Location = new Point(45, 113);
            lblSelectionezLigne.Name = "lblSelectionezLigne";
            lblSelectionezLigne.Size = new Size(347, 20);
            lblSelectionezLigne.TabIndex = 2;
            lblSelectionezLigne.Text = "Sélectionnez la ligne que vous souhaitez consulter :";
            // 
            // lblConsulterLigne
            // 
            lblConsulterLigne.AutoSize = true;
            lblConsulterLigne.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblConsulterLigne.Location = new Point(58, 31);
            lblConsulterLigne.Name = "lblConsulterLigne";
            lblConsulterLigne.Size = new Size(320, 46);
            lblConsulterLigne.TabIndex = 0;
            lblConsulterLigne.Text = "Consulter une ligne";
            lblConsulterLigne.Click += label1_Click;
            // 
            // panelCarte
            // 
            panelCarte.BackColor = SystemColors.ControlLightLight;
            panelCarte.Controls.Add(lblCliquez);
            panelCarte.Controls.Add(pbCarte);
            panelCarte.Controls.Add(lblNomLigne);
            panelCarte.Location = new Point(544, 103);
            panelCarte.Name = "panelCarte";
            panelCarte.Size = new Size(554, 481);
            panelCarte.TabIndex = 1;
            panelCarte.Visible = false;
            panelCarte.Paint += panelCarte_Paint;
            // 
            // lblCliquez
            // 
            lblCliquez.AutoSize = true;
            lblCliquez.Location = new Point(75, 167);
            lblCliquez.Name = "lblCliquez";
            lblCliquez.Size = new Size(403, 20);
            lblCliquez.TabIndex = 2;
            lblCliquez.Text = "Pour avoir accès à la carte et aux arrêts, cliquez ci-dessous : ";
            // 
            // pbCarte
            // 
            pbCarte.BackgroundImage = Properties.Resources.lien;
            pbCarte.BackgroundImageLayout = ImageLayout.Zoom;
            pbCarte.Location = new Point(68, 218);
            pbCarte.Name = "pbCarte";
            pbCarte.Size = new Size(414, 182);
            pbCarte.SizeMode = PictureBoxSizeMode.CenterImage;
            pbCarte.TabIndex = 1;
            pbCarte.TabStop = false;
            pbCarte.Click += pictureBox1_Click;
            // 
            // lblNomLigne
            // 
            lblNomLigne.AutoSize = true;
            lblNomLigne.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomLigne.Location = new Point(35, 31);
            lblNomLigne.Name = "lblNomLigne";
            lblNomLigne.Size = new Size(264, 46);
            lblNomLigne.TabIndex = 0;
            lblNomLigne.Text = "Nom de la ligne\r\n";
            lblNomLigne.Click += lblNomLigne_Click;
            // 
            // ConsulterLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(panelCarte);
            Controls.Add(pnlBackroundConsulter);
            Name = "ConsulterLigne";
            Text = "ConsulterLigne";
            Load += ConsulterLigne_Load;
            pnlBackroundConsulter.ResumeLayout(false);
            pnlBackroundConsulter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelCarte.ResumeLayout(false);
            panelCarte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCarte).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBackroundConsulter;
        private Label lblConsulterLigne;
        private ComboBox cbLigne;
        private Label lblSelectionezLigne;
        private Panel panelCarte;
        private Label lblNomLigne;
        private PictureBox pbCarte;
        private Label lblCliquez;
        private PictureBox pictureBox2;
    }
}