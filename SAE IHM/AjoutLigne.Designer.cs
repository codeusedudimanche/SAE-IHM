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
            lblDestination = new Label();
            txtbDestinationLigne = new TextBox();
            lbNomArretAjoute = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).BeginInit();
            SuspendLayout();
            // 
            // txtBNomLigne
            // 
            txtBNomLigne.Location = new Point(396, 95);
            txtBNomLigne.Name = "txtBNomLigne";
            txtBNomLigne.Size = new Size(379, 27);
            txtBNomLigne.TabIndex = 0;
            txtBNomLigne.TextAlignChanged += txtBNomLigne_TextAlignChanged;
            txtBNomLigne.TextChanged += txtBNom_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(295, 14);
            label1.Name = "label1";
            label1.Size = new Size(224, 46);
            label1.TabIndex = 1;
            label1.Text = "Ajoutez Ligne";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(396, 65);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(116, 20);
            lblNom.TabIndex = 2;
            lblNom.Text = "Nom de la ligne";
            // 
            // lstBArret
            // 
            lstBArret.FormattingEnabled = true;
            lstBArret.Location = new Point(38, 84);
            lstBArret.Name = "lstBArret";
            lstBArret.Size = new Size(316, 184);
            lstBArret.TabIndex = 3;
            lstBArret.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(38, 274);
            button1.Name = "button1";
            button1.Size = new Size(316, 40);
            button1.TabIndex = 4;
            button1.Text = "Valider l'ajout de l'arret à la ligne";
            button1.UseVisualStyleBackColor = true;
            button1.ClientSizeChanged += button1_ClientSizeChanged;
            button1.Click += btnAjoutArret_Click;
            // 
            // lblNomLigne
            // 
            lblNomLigne.AutoSize = true;
            lblNomLigne.Location = new Point(396, 248);
            lblNomLigne.Name = "lblNomLigne";
            lblNomLigne.Size = new Size(123, 20);
            lblNomLigne.TabIndex = 5;
            lblNomLigne.Text = "Nom des Arrets : ";
            lblNomLigne.Click += lblNomLigne_Click;
            // 
            // btnValiderAjoutLigne
            // 
            btnValiderAjoutLigne.Enabled = false;
            btnValiderAjoutLigne.Location = new Point(122, 367);
            btnValiderAjoutLigne.Name = "btnValiderAjoutLigne";
            btnValiderAjoutLigne.Size = new Size(588, 62);
            btnValiderAjoutLigne.TabIndex = 7;
            btnValiderAjoutLigne.Text = "Valider l'ajout de la ligne";
            btnValiderAjoutLigne.UseVisualStyleBackColor = true;
            btnValiderAjoutLigne.Click += btnValiderAjoutLigne_Click;
            // 
            // pbEspaceAdmin
            // 
            pbEspaceAdmin.Image = (Image)resources.GetObject("pbEspaceAdmin.Image");
            pbEspaceAdmin.InitialImage = (Image)resources.GetObject("pbEspaceAdmin.InitialImage");
            pbEspaceAdmin.Location = new Point(28, 387);
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
            button2.Location = new Point(38, 320);
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
            lblNumeroLigne.Location = new Point(396, 136);
            lblNumeroLigne.Name = "lblNumeroLigne";
            lblNumeroLigne.Size = new Size(137, 20);
            lblNumeroLigne.TabIndex = 14;
            lblNumeroLigne.Text = "Numero de la ligne";
            // 
            // txtbNumeroLigne
            // 
            txtbNumeroLigne.Location = new Point(396, 159);
            txtbNumeroLigne.Name = "txtbNumeroLigne";
            txtbNumeroLigne.Size = new Size(379, 27);
            txtbNumeroLigne.TabIndex = 13;
            txtbNumeroLigne.TextChanged += NumeroLigne_TextChanged;
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Location = new Point(396, 189);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(159, 20);
            lblDestination.TabIndex = 16;
            lblDestination.Text = "Destination de la ligne";
            // 
            // txtbDestinationLigne
            // 
            txtbDestinationLigne.Location = new Point(396, 212);
            txtbDestinationLigne.Name = "txtbDestinationLigne";
            txtbDestinationLigne.Size = new Size(379, 27);
            txtbDestinationLigne.TabIndex = 15;
            txtbDestinationLigne.TextChanged += txtbDestinationLigne_TextChanged;
            // 
            // lbNomArretAjoute
            // 
            lbNomArretAjoute.FormattingEnabled = true;
            lbNomArretAjoute.Location = new Point(396, 274);
            lbNomArretAjoute.Name = "lbNomArretAjoute";
            lbNomArretAjoute.Size = new Size(368, 84);
            lbNomArretAjoute.TabIndex = 17;
            // 
            // AjoutLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbNomArretAjoute);
            Controls.Add(lblDestination);
            Controls.Add(txtbDestinationLigne);
            Controls.Add(lblNumeroLigne);
            Controls.Add(txtbNumeroLigne);
            Controls.Add(button2);
            Controls.Add(pbEspaceAdmin);
            Controls.Add(btnValiderAjoutLigne);
            Controls.Add(lblNomLigne);
            Controls.Add(button1);
            Controls.Add(lstBArret);
            Controls.Add(lblNom);
            Controls.Add(label1);
            Controls.Add(txtBNomLigne);
            Name = "AjoutLigne";
            Text = "Form1";
            FormClosing += AjoutLigne_FormClosing;
            FormClosed += AjoutLigne_FormClosed;
            Load += AjoutLigne_Load;
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblDestination;
        private TextBox txtbDestinationLigne;
        private ListBox lbNomArretAjoute;
    }
}