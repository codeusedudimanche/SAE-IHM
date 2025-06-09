namespace SAE_IHM.Admin.Modifier
{
    partial class ModifierLigne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierLigne));
            pnlBackround = new Panel();
            btnValider = new Button();
            pbEspaceAdmin = new PictureBox();
            lblTitre = new Label();
            lblDestination = new Label();
            txtDestination = new TextBox();
            txtNumero = new TextBox();
            lblNumero = new Label();
            gbLigne = new GroupBox();
            btnAnnuler = new Button();
            lbArret = new ListBox();
            lblLigneDeservie = new Label();
            lblChoisissez = new Label();
            cbLigne = new ComboBox();
            pnlBackround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).BeginInit();
            gbLigne.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBackround
            // 
            pnlBackround.Controls.Add(btnValider);
            pnlBackround.Controls.Add(pbEspaceAdmin);
            pnlBackround.Controls.Add(lblTitre);
            pnlBackround.Controls.Add(lblDestination);
            pnlBackround.Controls.Add(txtDestination);
            pnlBackround.Controls.Add(txtNumero);
            pnlBackround.Controls.Add(lblNumero);
            pnlBackround.Controls.Add(gbLigne);
            pnlBackround.Controls.Add(lblChoisissez);
            pnlBackround.Controls.Add(cbLigne);
            pnlBackround.Location = new Point(167, 12);
            pnlBackround.Name = "pnlBackround";
            pnlBackround.Size = new Size(827, 691);
            pnlBackround.TabIndex = 0;
            // 
            // btnValider
            // 
            btnValider.Enabled = false;
            btnValider.Location = new Point(153, 602);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(542, 56);
            btnValider.TabIndex = 34;
            btnValider.Text = "Valider les changements";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // pbEspaceAdmin
            // 
            pbEspaceAdmin.Image = (Image)resources.GetObject("pbEspaceAdmin.Image");
            pbEspaceAdmin.InitialImage = (Image)resources.GetObject("pbEspaceAdmin.InitialImage");
            pbEspaceAdmin.Location = new Point(31, 616);
            pbEspaceAdmin.Name = "pbEspaceAdmin";
            pbEspaceAdmin.Size = new Size(43, 42);
            pbEspaceAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pbEspaceAdmin.TabIndex = 33;
            pbEspaceAdmin.TabStop = false;
            pbEspaceAdmin.Click += pbEspaceAdmin_Click;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(282, 19);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(304, 46);
            lblTitre.TabIndex = 32;
            lblTitre.Text = "Modifier une ligne";
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Location = new Point(220, 238);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(159, 20);
            lblDestination.TabIndex = 31;
            lblDestination.Text = "Destination de la ligne";
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(214, 265);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(423, 27);
            txtDestination.TabIndex = 30;
            txtDestination.TextChanged += txtDestination_TextChanged;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(214, 194);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(423, 27);
            txtNumero.TabIndex = 29;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(214, 161);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(137, 20);
            lblNumero.TabIndex = 28;
            lblNumero.Text = "Numero de la ligne";
            // 
            // gbLigne
            // 
            gbLigne.Controls.Add(btnAnnuler);
            gbLigne.Controls.Add(lbArret);
            gbLigne.Controls.Add(lblLigneDeservie);
            gbLigne.Location = new Point(153, 298);
            gbLigne.Name = "gbLigne";
            gbLigne.Size = new Size(588, 298);
            gbLigne.TabIndex = 27;
            gbLigne.TabStop = false;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = Color.FromArgb(192, 64, 0);
            btnAnnuler.Location = new Point(6, 252);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(507, 29);
            btnAnnuler.TabIndex = 23;
            btnAnnuler.Text = "Annuler les changements";
            btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // lbArret
            // 
            lbArret.Font = new Font("Segoe UI", 10F);
            lbArret.FormattingEnabled = true;
            lbArret.ItemHeight = 23;
            lbArret.Location = new Point(6, 37);
            lbArret.Name = "lbArret";
            lbArret.Size = new Size(507, 211);
            lbArret.TabIndex = 21;
            lbArret.SelectedIndexChanged += lbArret_SelectedIndexChanged;
            // 
            // lblLigneDeservie
            // 
            lblLigneDeservie.AutoSize = true;
            lblLigneDeservie.Location = new Point(6, 14);
            lblLigneDeservie.Name = "lblLigneDeservie";
            lblLigneDeservie.Size = new Size(101, 20);
            lblLigneDeservie.TabIndex = 22;
            lblLigneDeservie.Text = "Arret deservie";
            // 
            // lblChoisissez
            // 
            lblChoisissez.AutoSize = true;
            lblChoisissez.Font = new Font("Segoe UI", 10F);
            lblChoisissez.Location = new Point(215, 88);
            lblChoisissez.Name = "lblChoisissez";
            lblChoisissez.Size = new Size(163, 23);
            lblChoisissez.TabIndex = 26;
            lblChoisissez.Text = "Choisissez une ligne";
            // 
            // cbLigne
            // 
            cbLigne.FormattingEnabled = true;
            cbLigne.Location = new Point(215, 114);
            cbLigne.Name = "cbLigne";
            cbLigne.Size = new Size(422, 28);
            cbLigne.TabIndex = 25;
            cbLigne.SelectedIndexChanged += cbLigne_SelectedIndexChanged;
            // 
            // ModifierLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(pnlBackround);
            Name = "ModifierLigne";
            Text = "ModifierLigne";
            FormClosing += ModifierLigne_FormClosing;
            pnlBackround.ResumeLayout(false);
            pnlBackround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).EndInit();
            gbLigne.ResumeLayout(false);
            gbLigne.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBackround;
        private GroupBox gbLigne;
        private Button btnAnnuler;
        private ListBox lbArret;
        private Label lblLigneDeservie;
        private Label lblChoisissez;
        private ComboBox cbLigne;
        private Label lblNumero;
        private Label lblDestination;
        private TextBox txtDestination;
        private TextBox txtNumero;
        private Label lblTitre;
        private Button btnValider;
        private PictureBox pbEspaceAdmin;
    }
}