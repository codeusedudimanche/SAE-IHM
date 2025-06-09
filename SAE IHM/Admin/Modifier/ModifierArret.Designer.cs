namespace SAE_IHM.Admin.Modifier
{
    partial class ModifierArret
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierArret));
            pbEspaceAdmin = new PictureBox();
            pnlBackround = new Panel();
            lblLigneDeservie = new Label();
            lbLigne = new ListBox();
            lblLongitude = new Label();
            txtLongitude = new TextBox();
            lblLatitude = new Label();
            txtLatitude = new TextBox();
            lblArret = new Label();
            txtNom = new TextBox();
            lblChoisissez = new Label();
            lblTitre = new Label();
            cbArret = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).BeginInit();
            pnlBackround.SuspendLayout();
            SuspendLayout();
            // 
            // pbEspaceAdmin
            // 
            pbEspaceAdmin.Image = (Image)resources.GetObject("pbEspaceAdmin.Image");
            pbEspaceAdmin.InitialImage = (Image)resources.GetObject("pbEspaceAdmin.InitialImage");
            pbEspaceAdmin.Location = new Point(44, 441);
            pbEspaceAdmin.Name = "pbEspaceAdmin";
            pbEspaceAdmin.Size = new Size(43, 42);
            pbEspaceAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pbEspaceAdmin.TabIndex = 11;
            pbEspaceAdmin.TabStop = false;
            pbEspaceAdmin.Click += pbEspaceAdmin_Click;
            // 
            // pnlBackround
            // 
            pnlBackround.Controls.Add(lblLigneDeservie);
            pnlBackround.Controls.Add(lbLigne);
            pnlBackround.Controls.Add(lblLongitude);
            pnlBackround.Controls.Add(txtLongitude);
            pnlBackround.Controls.Add(lblLatitude);
            pnlBackround.Controls.Add(txtLatitude);
            pnlBackround.Controls.Add(lblArret);
            pnlBackround.Controls.Add(txtNom);
            pnlBackround.Controls.Add(lblChoisissez);
            pnlBackround.Controls.Add(lblTitre);
            pnlBackround.Controls.Add(cbArret);
            pnlBackround.Controls.Add(pbEspaceAdmin);
            pnlBackround.Location = new Point(122, 103);
            pnlBackround.Name = "pnlBackround";
            pnlBackround.Size = new Size(975, 518);
            pnlBackround.TabIndex = 19;
            // 
            // lblLigneDeservie
            // 
            lblLigneDeservie.AutoSize = true;
            lblLigneDeservie.Location = new Point(579, 197);
            lblLigneDeservie.Name = "lblLigneDeservie";
            lblLigneDeservie.Size = new Size(104, 20);
            lblLigneDeservie.TabIndex = 22;
            lblLigneDeservie.Text = "Ligne deservie";
            // 
            // lbLigne
            // 
            lbLigne.FormattingEnabled = true;
            lbLigne.Location = new Point(577, 220);
            lbLigne.Name = "lbLigne";
            lbLigne.Size = new Size(340, 244);
            lbLigne.TabIndex = 21;
            // 
            // lblLongitude
            // 
            lblLongitude.AutoSize = true;
            lblLongitude.Location = new Point(329, 331);
            lblLongitude.Name = "lblLongitude";
            lblLongitude.Size = new Size(76, 20);
            lblLongitude.TabIndex = 20;
            lblLongitude.Text = "Longitude";
            lblLongitude.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLongitude
            // 
            txtLongitude.Location = new Point(319, 357);
            txtLongitude.Name = "txtLongitude";
            txtLongitude.Size = new Size(163, 27);
            txtLongitude.TabIndex = 19;
            // 
            // lblLatitude
            // 
            lblLatitude.AutoSize = true;
            lblLatitude.Location = new Point(141, 331);
            lblLatitude.Name = "lblLatitude";
            lblLatitude.Size = new Size(63, 20);
            lblLatitude.TabIndex = 18;
            lblLatitude.Text = "Latitude";
            lblLatitude.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLatitude
            // 
            txtLatitude.Location = new Point(136, 357);
            txtLatitude.Name = "txtLatitude";
            txtLatitude.Size = new Size(163, 27);
            txtLatitude.TabIndex = 17;
            // 
            // lblArret
            // 
            lblArret.AutoSize = true;
            lblArret.Location = new Point(141, 233);
            lblArret.Name = "lblArret";
            lblArret.Size = new Size(105, 20);
            lblArret.TabIndex = 16;
            lblArret.Text = "Nom de l'arrêt";
            lblArret.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(136, 259);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(346, 27);
            txtNom.TabIndex = 15;
            // 
            // lblChoisissez
            // 
            lblChoisissez.AutoSize = true;
            lblChoisissez.Font = new Font("Segoe UI", 10F);
            lblChoisissez.Location = new Point(393, 99);
            lblChoisissez.Name = "lblChoisissez";
            lblChoisissez.Size = new Size(153, 23);
            lblChoisissez.TabIndex = 14;
            lblChoisissez.Text = "Choisissez un arrêt";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(358, 21);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(284, 46);
            lblTitre.TabIndex = 13;
            lblTitre.Text = "Modifier un arret";
            // 
            // cbArret
            // 
            cbArret.FormattingEnabled = true;
            cbArret.Location = new Point(261, 125);
            cbArret.Name = "cbArret";
            cbArret.Size = new Size(422, 28);
            cbArret.TabIndex = 12;
            cbArret.SelectedIndexChanged += cbArret_SelectedIndexChanged;
            // 
            // ModifierArret
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(pnlBackround);
            Name = "ModifierArret";
            Text = "ModifierArret";
            FormClosed += ModifierArret_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).EndInit();
            pnlBackround.ResumeLayout(false);
            pnlBackround.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbEspaceAdmin;
        private Panel pnlBackround;
        private ComboBox cbArret;
        private Label lblTitre;
        private Label lblChoisissez;
        private TextBox txtNom;
        private Label lblLongitude;
        private TextBox txtLongitude;
        private Label lblLatitude;
        private TextBox txtLatitude;
        private Label lblArret;
        private ListBox lbLigne;
        private Label lblLigneDeservie;
    }
}