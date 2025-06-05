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
            label1 = new Label();
            lblNom = new Label();
            lstBArret = new ListBox();
            button1 = new Button();
            lblNomLigne = new Label();
            btnValiderAjoutLigne = new Button();
            pbEspaceAdmin = new PictureBox();
            button2 = new Button();
            lblNumeroLigne = new Label();
            txtbNumeroLigne = new TextBox();
            lbNomArretAjoute = new ListBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).BeginInit();
            panel1.SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 26);
            label1.Name = "label1";
            label1.Size = new Size(287, 46);
            label1.TabIndex = 1;
            label1.Text = "Ajouter une ligne";
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
            // 
            // button1
            // 
            button1.Location = new Point(28, 288);
            button1.Name = "button1";
            button1.Size = new Size(316, 40);
            button1.TabIndex = 4;
            button1.Text = "Valider l'ajout de l'arret à la ligne";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAjoutArret_Click;
            // 
            // lblNomLigne
            // 
            lblNomLigne.AutoSize = true;
            lblNomLigne.Location = new Point(421, 229);
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
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(28, 334);
            button2.Name = "button2";
            button2.Size = new Size(316, 37);
            button2.TabIndex = 12;
            button2.Text = "Retour en arrière";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnAnnuler_Click;
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
            // panel1
            // 
            panel1.Controls.Add(lstBArret);
            panel1.Controls.Add(pbEspaceAdmin);
            panel1.Controls.Add(lbNomArretAjoute);
            panel1.Controls.Add(txtBNomLigne);
            panel1.Controls.Add(lblNumeroLigne);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtbNumeroLigne);
            panel1.Controls.Add(lblNom);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblNomLigne);
            panel1.Controls.Add(btnValiderAjoutLigne);
            panel1.Location = new Point(190, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 476);
            panel1.TabIndex = 18;
            // 
            // AjoutLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Name = "AjoutLigne";
            Text = "Form1";
            FormClosing += AjoutLigne_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBNomLigne;
        private Label label1;
        private Label lblNom;
        private ListBox lstBArret;
        private Button button1;
        private Label lblNomLigne;
        private Button btnValiderAjoutLigne;
        private PictureBox pbEspaceAdmin;
        private Button button2;
        private Label lblNumeroLigne;
        private TextBox txtbNumeroLigne;
        private ListBox lbNomArretAjoute;
        private Panel panel1;
    }
}