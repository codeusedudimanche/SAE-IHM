namespace SAE_IHM
{
    partial class ConsulterHoraire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsulterHoraire));
            pnlHoraire = new Panel();
            label2 = new Label();
            lstvHoraire = new ListView();
            lblNomLigne = new Label();
            lblNomArrêt = new Label();
            pnlBackroundConsulter = new Panel();
            cbArret = new ComboBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            cbLigne = new ComboBox();
            lblSelectionezLigne = new Label();
            lblConsulterLigne = new Label();
            pnlHoraire.SuspendLayout();
            pnlBackroundConsulter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlHoraire
            // 
            pnlHoraire.BackColor = SystemColors.ControlLightLight;
            pnlHoraire.Controls.Add(label2);
            pnlHoraire.Controls.Add(lstvHoraire);
            pnlHoraire.Controls.Add(lblNomLigne);
            pnlHoraire.Controls.Add(lblNomArrêt);
            pnlHoraire.Location = new Point(559, 136);
            pnlHoraire.Name = "pnlHoraire";
            pnlHoraire.Size = new Size(554, 481);
            pnlHoraire.TabIndex = 3;
            pnlHoraire.Visible = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(317, 133);
            label2.MaximumSize = new Size(800, 200);
            label2.Name = "label2";
            label2.Size = new Size(176, 46);
            label2.TabIndex = 5;
            label2.Text = "Horaires";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lstvHoraire
            // 
            lstvHoraire.Location = new Point(57, 192);
            lstvHoraire.Name = "lstvHoraire";
            lstvHoraire.Size = new Size(436, 230);
            lstvHoraire.TabIndex = 4;
            lstvHoraire.UseCompatibleStateImageBehavior = false;
            // 
            // lblNomLigne
            // 
            lblNomLigne.AutoSize = true;
            lblNomLigne.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomLigne.Location = new Point(57, 143);
            lblNomLigne.Name = "lblNomLigne";
            lblNomLigne.Size = new Size(182, 31);
            lblNomLigne.TabIndex = 3;
            lblNomLigne.Text = "Nom de la Ligne";
            lblNomLigne.Visible = false;
            // 
            // lblNomArrêt
            // 
            lblNomArrêt.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomArrêt.Location = new Point(57, 31);
            lblNomArrêt.MaximumSize = new Size(458, 400);
            lblNomArrêt.Name = "lblNomArrêt";
            lblNomArrêt.Size = new Size(436, 143);
            lblNomArrêt.TabIndex = 0;
            lblNomArrêt.Text = "Nom de l'Arrêt";
            lblNomArrêt.TextAlign = ContentAlignment.TopCenter;
            lblNomArrêt.Visible = false;
            lblNomArrêt.Click += lblNomArrêt_Click;
            // 
            // pnlBackroundConsulter
            // 
            pnlBackroundConsulter.BackColor = SystemColors.ControlLightLight;
            pnlBackroundConsulter.Controls.Add(cbArret);
            pnlBackroundConsulter.Controls.Add(label1);
            pnlBackroundConsulter.Controls.Add(pictureBox2);
            pnlBackroundConsulter.Controls.Add(cbLigne);
            pnlBackroundConsulter.Controls.Add(lblSelectionezLigne);
            pnlBackroundConsulter.Controls.Add(lblConsulterLigne);
            pnlBackroundConsulter.Location = new Point(69, 136);
            pnlBackroundConsulter.Name = "pnlBackroundConsulter";
            pnlBackroundConsulter.Size = new Size(428, 376);
            pnlBackroundConsulter.TabIndex = 2;
            // 
            // cbArret
            // 
            cbArret.Enabled = false;
            cbArret.FormattingEnabled = true;
            cbArret.Location = new Point(45, 260);
            cbArret.Name = "cbArret";
            cbArret.Size = new Size(345, 28);
            cbArret.TabIndex = 10;
            cbArret.SelectedIndexChanged += cbArret_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 211);
            label1.Name = "label1";
            label1.Size = new Size(242, 20);
            label1.TabIndex = 9;
            label1.Text = "Sélectionnez l'arrêt correspondant :\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(33, 305);
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
            cbLigne.Location = new Point(45, 162);
            cbLigne.Name = "cbLigne";
            cbLigne.Size = new Size(345, 28);
            cbLigne.TabIndex = 3;
            cbLigne.SelectedIndexChanged += cbLigne_SelectedIndexChanged;
            // 
            // lblSelectionezLigne
            // 
            lblSelectionezLigne.AutoSize = true;
            lblSelectionezLigne.Location = new Point(45, 113);
            lblSelectionezLigne.Name = "lblSelectionezLigne";
            lblSelectionezLigne.Size = new Size(165, 20);
            lblSelectionezLigne.TabIndex = 2;
            lblSelectionezLigne.Text = "Sélectionnez une ligne :\r\n";
            // 
            // lblConsulterLigne
            // 
            lblConsulterLigne.AutoSize = true;
            lblConsulterLigne.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblConsulterLigne.Location = new Point(33, 31);
            lblConsulterLigne.Name = "lblConsulterLigne";
            lblConsulterLigne.Size = new Size(365, 46);
            lblConsulterLigne.TabIndex = 0;
            lblConsulterLigne.Text = "Consulter des horaires";
            // 
            // ConsulterHoraire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(pnlHoraire);
            Controls.Add(pnlBackroundConsulter);
            Name = "ConsulterHoraire";
            Text = "ConsulterHoraire";
            Load += ConsulterHoraire_Load;
            pnlHoraire.ResumeLayout(false);
            pnlHoraire.PerformLayout();
            pnlBackroundConsulter.ResumeLayout(false);
            pnlBackroundConsulter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHoraire;
        private Label lblNomLigne;
        private Label lblNomArrêt;
        private Panel pnlBackroundConsulter;
        private ComboBox cbArret;
        private Label label1;
        private PictureBox pictureBox2;
        private ComboBox cbLigne;
        private Label lblSelectionezLigne;
        private Label lblConsulterLigne;
        private ListView lstvHoraire;
        private Label label2;
    }
}