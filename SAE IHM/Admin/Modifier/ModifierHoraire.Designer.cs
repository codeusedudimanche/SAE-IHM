namespace SAE_IHM.Admin.Modifier
{
    partial class ModifierHoraire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierHoraire));
            panel1 = new Panel();
            lblHoraire = new Label();
            pbEspaceAdmin = new PictureBox();
            flpHoraire = new FlowLayoutPanel();
            lblArret = new Label();
            cbArret = new ComboBox();
            lblLigne = new Label();
            cbLigne = new ComboBox();
            lblTitre = new Label();
            btnValider = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnValider);
            panel1.Controls.Add(lblHoraire);
            panel1.Controls.Add(pbEspaceAdmin);
            panel1.Controls.Add(flpHoraire);
            panel1.Controls.Add(lblArret);
            panel1.Controls.Add(cbArret);
            panel1.Controls.Add(lblLigne);
            panel1.Controls.Add(cbLigne);
            panel1.Controls.Add(lblTitre);
            panel1.Location = new Point(202, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(729, 611);
            panel1.TabIndex = 0;
            // 
            // lblHoraire
            // 
            lblHoraire.AutoSize = true;
            lblHoraire.Location = new Point(114, 259);
            lblHoraire.Name = "lblHoraire";
            lblHoraire.Size = new Size(145, 20);
            lblHoraire.TabIndex = 21;
            lblHoraire.Text = "Horaire de passage :";
            // 
            // pbEspaceAdmin
            // 
            pbEspaceAdmin.Image = (Image)resources.GetObject("pbEspaceAdmin.Image");
            pbEspaceAdmin.InitialImage = (Image)resources.GetObject("pbEspaceAdmin.InitialImage");
            pbEspaceAdmin.Location = new Point(34, 535);
            pbEspaceAdmin.Name = "pbEspaceAdmin";
            pbEspaceAdmin.Size = new Size(43, 42);
            pbEspaceAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pbEspaceAdmin.TabIndex = 20;
            pbEspaceAdmin.TabStop = false;
            pbEspaceAdmin.Click += pbEspaceAdmin_Click;
            // 
            // flpHoraire
            // 
            flpHoraire.Location = new Point(114, 292);
            flpHoraire.Name = "flpHoraire";
            flpHoraire.Size = new Size(501, 220);
            flpHoraire.TabIndex = 19;
            // 
            // lblArret
            // 
            lblArret.AutoSize = true;
            lblArret.Location = new Point(114, 171);
            lblArret.Name = "lblArret";
            lblArret.Size = new Size(131, 20);
            lblArret.TabIndex = 18;
            lblArret.Text = "Choissisez un arret";
            // 
            // cbArret
            // 
            cbArret.FormattingEnabled = true;
            cbArret.Location = new Point(114, 194);
            cbArret.Name = "cbArret";
            cbArret.Size = new Size(501, 28);
            cbArret.TabIndex = 17;
            cbArret.SelectedIndexChanged += cbArret_SelectedIndexChanged;
            // 
            // lblLigne
            // 
            lblLigne.AutoSize = true;
            lblLigne.Location = new Point(114, 97);
            lblLigne.Name = "lblLigne";
            lblLigne.Size = new Size(141, 20);
            lblLigne.TabIndex = 16;
            lblLigne.Text = "Choissisez une ligne";
            // 
            // cbLigne
            // 
            cbLigne.FormattingEnabled = true;
            cbLigne.Location = new Point(114, 120);
            cbLigne.Name = "cbLigne";
            cbLigne.Size = new Size(501, 28);
            cbLigne.TabIndex = 15;
            cbLigne.SelectedIndexChanged += cbLigne_SelectedIndexChanged;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(213, 29);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(321, 46);
            lblTitre.TabIndex = 14;
            lblTitre.Text = "Modifier un horaire";
            // 
            // btnValider
            // 
            btnValider.Location = new Point(114, 526);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(501, 40);
            btnValider.TabIndex = 22;
            btnValider.Text = "Valider les modifications";
            btnValider.UseVisualStyleBackColor = true;
            // 
            // ModifierHoraire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Name = "ModifierHoraire";
            Text = "ModifierHoraire";
            FormClosing += ModifierHoraire_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblArret;
        private ComboBox cbArret;
        private Label lblLigne;
        private ComboBox cbLigne;
        private Label lblTitre;
        private FlowLayoutPanel flpHoraire;
        private PictureBox pbEspaceAdmin;
        private Label lblHoraire;
        private Button btnValider;
    }
}