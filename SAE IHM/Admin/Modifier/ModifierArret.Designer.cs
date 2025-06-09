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
            button1 = new Button();
            gbLigne = new GroupBox();
            btnAnnuler = new Button();
            lbLigne = new ListBox();
            lblLigneDeservie = new Label();
            btnValider = new Button();
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
            gbLigne.SuspendLayout();
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
            pnlBackround.Controls.Add(button1);
            pnlBackround.Controls.Add(gbLigne);
            pnlBackround.Controls.Add(btnValider);
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
            pnlBackround.Paint += pnlBackround_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(172, 370);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 25;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // gbLigne
            // 
            gbLigne.Controls.Add(btnAnnuler);
            gbLigne.Controls.Add(lbLigne);
            gbLigne.Controls.Add(lblLigneDeservie);
            gbLigne.Location = new Point(538, 144);
            gbLigne.Name = "gbLigne";
            gbLigne.Size = new Size(412, 259);
            gbLigne.TabIndex = 24;
            gbLigne.TabStop = false;
            gbLigne.Enter += gbLigne_Enter;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = Color.FromArgb(192, 64, 0);
            btnAnnuler.Location = new Point(6, 224);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(309, 29);
            btnAnnuler.TabIndex = 23;
            btnAnnuler.Text = "Annuler les changements";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnRetour_Click;
            // 
            // lbLigne
            // 
            lbLigne.Font = new Font("Segoe UI", 11F);
            lbLigne.FormattingEnabled = true;
            lbLigne.ItemHeight = 25;
            lbLigne.Location = new Point(6, 37);
            lbLigne.Name = "lbLigne";
            lbLigne.Size = new Size(309, 179);
            lbLigne.TabIndex = 21;
            lbLigne.SelectedIndexChanged += lbLigne_SelectedIndexChanged;
            // 
            // lblLigneDeservie
            // 
            lblLigneDeservie.AutoSize = true;
            lblLigneDeservie.Location = new Point(6, 14);
            lblLigneDeservie.Name = "lblLigneDeservie";
            lblLigneDeservie.Size = new Size(104, 20);
            lblLigneDeservie.TabIndex = 22;
            lblLigneDeservie.Text = "Ligne deservie";
            // 
            // btnValider
            // 
            btnValider.Enabled = false;
            btnValider.Location = new Point(234, 422);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(518, 55);
            btnValider.TabIndex = 23;
            btnValider.Text = "Valider les modification";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // lblLongitude
            // 
            lblLongitude.AutoSize = true;
            lblLongitude.Location = new Point(336, 305);
            lblLongitude.Name = "lblLongitude";
            lblLongitude.Size = new Size(76, 20);
            lblLongitude.TabIndex = 20;
            lblLongitude.Text = "Longitude";
            lblLongitude.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLongitude
            // 
            txtLongitude.Location = new Point(326, 331);
            txtLongitude.Name = "txtLongitude";
            txtLongitude.Size = new Size(163, 27);
            txtLongitude.TabIndex = 19;
            txtLongitude.TextChanged += txtLongitude_TextChanged;
            // 
            // lblLatitude
            // 
            lblLatitude.AutoSize = true;
            lblLatitude.Location = new Point(148, 305);
            lblLatitude.Name = "lblLatitude";
            lblLatitude.Size = new Size(63, 20);
            lblLatitude.TabIndex = 18;
            lblLatitude.Text = "Latitude";
            lblLatitude.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLatitude
            // 
            txtLatitude.Location = new Point(143, 331);
            txtLatitude.Name = "txtLatitude";
            txtLatitude.Size = new Size(163, 27);
            txtLatitude.TabIndex = 17;
            txtLatitude.TextChanged += txtLatitude_TextChanged;
            // 
            // lblArret
            // 
            lblArret.AutoSize = true;
            lblArret.Location = new Point(148, 207);
            lblArret.Name = "lblArret";
            lblArret.Size = new Size(105, 20);
            lblArret.TabIndex = 16;
            lblArret.Text = "Nom de l'arrêt";
            lblArret.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(143, 233);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(346, 27);
            txtNom.TabIndex = 15;
            txtNom.TextChanged += VerifModification;
            // 
            // lblChoisissez
            // 
            lblChoisissez.AutoSize = true;
            lblChoisissez.Font = new Font("Segoe UI", 10F);
            lblChoisissez.Location = new Point(400, 84);
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
            cbArret.Location = new Point(270, 110);
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
            Load += ModifierArret_Load;
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).EndInit();
            pnlBackround.ResumeLayout(false);
            pnlBackround.PerformLayout();
            gbLigne.ResumeLayout(false);
            gbLigne.PerformLayout();
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
        private Button btnValider;
        private GroupBox gbLigne;
        private Button btnAnnuler;
        private Button button1;
    }
}