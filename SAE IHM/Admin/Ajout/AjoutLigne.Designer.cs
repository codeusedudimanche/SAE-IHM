namespace SAE_IHM
{
    partial class AjoutLigne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutLigne));
            txtBNomLigne = new TextBox();
            lblTitre = new Label();
            lblNom = new Label();
            lstBArret = new ListBox();
            btnValiderArret = new Button();
            lblNomLigne = new Label();
            btnValiderAjoutLigne = new Button();
            pbEspaceAdmin = new PictureBox();
            btnRetour = new Button();
            lblNumeroLigne = new Label();
            txtbNumeroLigne = new TextBox();
            lbNomArretAjoute = new ListBox();
            pnlBackround = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).BeginInit();
            pnlBackround.SuspendLayout();
            SuspendLayout();
            // 
            // txtBNomLigne
            // 
            txtBNomLigne.Location = new Point(419, 123);
            txtBNomLigne.Name = "txtBNomLigne";
            txtBNomLigne.Size = new Size(348, 27);
            txtBNomLigne.TabIndex = 0;
            txtBNomLigne.TextChanged += txtBNom_TextChanged;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(255, 26);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(287, 46);
            lblTitre.TabIndex = 1;
            lblTitre.Text = "Ajouter une ligne";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(419, 98);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(123, 20);
            lblNom.TabIndex = 2;
            lblNom.Text = "Nom de la ligne :";
            // 
            // lstBArret
            // 
            lstBArret.FormattingEnabled = true;
            lstBArret.Location = new Point(28, 98);
            lstBArret.Name = "lstBArret";
            lstBArret.Size = new Size(316, 184);
            lstBArret.TabIndex = 3;
            lstBArret.SelectedIndexChanged += lstBArret_SelectedIndexChanged;
            // 
            // btnValiderArret
            // 
            btnValiderArret.Location = new Point(28, 288);
            btnValiderArret.Name = "btnValiderArret";
            btnValiderArret.Size = new Size(316, 40);
            btnValiderArret.TabIndex = 4;
            btnValiderArret.Text = "Valider l'ajout de l'arret à la ligne";
            btnValiderArret.UseVisualStyleBackColor = true;
            btnValiderArret.Click += btnAjoutArret_Click;
            // 
            // lblNomLigne
            // 
            lblNomLigne.AutoSize = true;
            lblNomLigne.Location = new Point(419, 233);
            lblNomLigne.Name = "lblNomLigne";
            lblNomLigne.Size = new Size(121, 20);
            lblNomLigne.TabIndex = 5;
            lblNomLigne.Text = "Nom des arrêts : ";
            // 
            // btnValiderAjoutLigne
            // 
            btnValiderAjoutLigne.Enabled = false;
            btnValiderAjoutLigne.Location = new Point(136, 396);
            btnValiderAjoutLigne.Name = "btnValiderAjoutLigne";
            btnValiderAjoutLigne.Size = new Size(503, 62);
            btnValiderAjoutLigne.TabIndex = 7;
            btnValiderAjoutLigne.Text = "Valider";
            btnValiderAjoutLigne.UseVisualStyleBackColor = true;
            btnValiderAjoutLigne.Click += btnValiderAjoutLigne_Click;
            // 
            // pbEspaceAdmin
            // 
            pbEspaceAdmin.Image = (Image)resources.GetObject("pbEspaceAdmin.Image");
            pbEspaceAdmin.InitialImage = (Image)resources.GetObject("pbEspaceAdmin.InitialImage");
            pbEspaceAdmin.Location = new Point(28, 416);
            pbEspaceAdmin.Name = "pbEspaceAdmin";
            pbEspaceAdmin.Size = new Size(43, 42);
            pbEspaceAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pbEspaceAdmin.TabIndex = 11;
            pbEspaceAdmin.TabStop = false;
            pbEspaceAdmin.Click += pbRetour_Click;
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.Red;
            btnRetour.Location = new Point(28, 334);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(316, 37);
            btnRetour.TabIndex = 12;
            btnRetour.Text = "Retour en arrière";
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnAnnuler_Click;
            // 
            // lblNumeroLigne
            // 
            lblNumeroLigne.AutoSize = true;
            lblNumeroLigne.Location = new Point(419, 164);
            lblNumeroLigne.Name = "lblNumeroLigne";
            lblNumeroLigne.Size = new Size(144, 20);
            lblNumeroLigne.TabIndex = 14;
            lblNumeroLigne.Text = "Numéro de la ligne :";
            // 
            // txtbNumeroLigne
            // 
            txtbNumeroLigne.Location = new Point(419, 187);
            txtbNumeroLigne.Name = "txtbNumeroLigne";
            txtbNumeroLigne.Size = new Size(348, 27);
            txtbNumeroLigne.TabIndex = 13;
            txtbNumeroLigne.TextChanged += NumeroLigne_TextChanged;
            // 
            // lbNomArretAjoute
            // 
            lbNomArretAjoute.FormattingEnabled = true;
            lbNomArretAjoute.Location = new Point(419, 267);
            lbNomArretAjoute.Name = "lbNomArretAjoute";
            lbNomArretAjoute.Size = new Size(348, 104);
            lbNomArretAjoute.TabIndex = 17;
            // 
            // pnlBackround
            // 
            pnlBackround.Controls.Add(lstBArret);
            pnlBackround.Controls.Add(pbEspaceAdmin);
            pnlBackround.Controls.Add(lbNomArretAjoute);
            pnlBackround.Controls.Add(txtBNomLigne);
            pnlBackround.Controls.Add(lblNumeroLigne);
            pnlBackround.Controls.Add(lblTitre);
            pnlBackround.Controls.Add(txtbNumeroLigne);
            pnlBackround.Controls.Add(lblNom);
            pnlBackround.Controls.Add(btnRetour);
            pnlBackround.Controls.Add(btnValiderArret);
            pnlBackround.Controls.Add(lblNomLigne);
            pnlBackround.Controls.Add(btnValiderAjoutLigne);
            pnlBackround.Location = new Point(190, 34);
            pnlBackround.Name = "pnlBackround";
            pnlBackround.Size = new Size(801, 476);
            pnlBackround.TabIndex = 18;
            pnlBackround.Paint += panel1_Paint;
            // 
            // AjoutLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(pnlBackround);
            Name = "AjoutLigne";
            Text = "AjoutLigne";
            FormClosing += AjoutLigne_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).EndInit();
            pnlBackround.ResumeLayout(false);
            pnlBackround.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBNomLigne;
        private Label lblTitre;
        private Label lblNom;
        private ListBox lstBArret;
        private Button btnValiderArret;
        private Label lblNomLigne;
        private Button btnValiderAjoutLigne;
        private PictureBox pbEspaceAdmin;
        private Button btnRetour;
        private Label lblNumeroLigne;
        private TextBox txtbNumeroLigne;
        private ListBox lbNomArretAjoute;
        private Panel pnlBackround;
    }
}