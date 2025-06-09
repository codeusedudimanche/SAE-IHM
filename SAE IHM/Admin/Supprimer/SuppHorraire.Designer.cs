namespace SAE_IHM
{
    partial class SuppHorraire
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
            pnlBackround = new Panel();
            lblHorraire = new Label();
            comboBoxHorraire = new ComboBox();
            lblArret = new Label();
            btnSupp = new Button();
            comboBoxArret = new ComboBox();
            lblTitre = new Label();
            pbEspaceAdmin = new PictureBox();
            pnlBackround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).BeginInit();
            SuspendLayout();
            // 
            // pnlBackround
            // 
            pnlBackround.Controls.Add(lblHorraire);
            pnlBackround.Controls.Add(comboBoxHorraire);
            pnlBackround.Controls.Add(lblArret);
            pnlBackround.Controls.Add(pbEspaceAdmin);
            pnlBackround.Controls.Add(btnSupp);
            pnlBackround.Controls.Add(comboBoxArret);
            pnlBackround.Controls.Add(lblTitre);
            pnlBackround.Location = new Point(304, 121);
            pnlBackround.Name = "pnlBackround";
            pnlBackround.Size = new Size(427, 320);
            pnlBackround.TabIndex = 2;
            // 
            // lblHorraire
            // 
            lblHorraire.AutoSize = true;
            lblHorraire.Location = new Point(81, 146);
            lblHorraire.Name = "lblHorraire";
            lblHorraire.Size = new Size(122, 15);
            lblHorraire.TabIndex = 15;
            lblHorraire.Text = "Choisissez un horraire";
            // 
            // comboBoxHorraire
            // 
            comboBoxHorraire.Enabled = false;
            comboBoxHorraire.FormattingEnabled = true;
            comboBoxHorraire.Location = new Point(81, 164);
            comboBoxHorraire.Name = "comboBoxHorraire";
            comboBoxHorraire.Size = new Size(265, 23);
            comboBoxHorraire.TabIndex = 14;
            // 
            // lblArret
            // 
            lblArret.AutoSize = true;
            lblArret.Location = new Point(83, 91);
            lblArret.Name = "lblArret";
            lblArret.Size = new Size(105, 15);
            lblArret.TabIndex = 13;
            lblArret.Text = "Choisissez un arret";
            // 
            // btnSupp
            // 
            btnSupp.Location = new Point(83, 217);
            btnSupp.Name = "btnSupp";
            btnSupp.Size = new Size(265, 34);
            btnSupp.TabIndex = 2;
            btnSupp.Text = "Supprimer";
            btnSupp.UseVisualStyleBackColor = true;
            btnSupp.Click += btnSupp_Click;
            // 
            // comboBoxArret
            // 
            comboBoxArret.FormattingEnabled = true;
            comboBoxArret.Location = new Point(83, 109);
            comboBoxArret.Name = "comboBoxArret";
            comboBoxArret.Size = new Size(265, 23);
            comboBoxArret.TabIndex = 1;
            comboBoxArret.SelectedIndexChanged += ComboBoxArret_SelectedIndexChanged;
            comboBoxArret.SelectionChangeCommitted += ComboBoxArret_SelectedIndexChanged;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblTitre.Location = new Point(71, 23);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(288, 37);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Supprimer un horraire";
            // 
            // pbEspaceAdmin
            // 
            pbEspaceAdmin.Image = Properties.Resources.bouton_daccueil;
            pbEspaceAdmin.InitialImage = null;
            pbEspaceAdmin.Location = new Point(27, 272);
            pbEspaceAdmin.Margin = new Padding(3, 2, 3, 2);
            pbEspaceAdmin.Name = "pbEspaceAdmin";
            pbEspaceAdmin.Size = new Size(38, 32);
            pbEspaceAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pbEspaceAdmin.TabIndex = 12;
            pbEspaceAdmin.TabStop = false;
            pbEspaceAdmin.Click += pbEspaceAdmin_Click;
            // 
            // SuppHorraire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1034, 562);
            Controls.Add(pnlBackround);
            Name = "SuppHorraire";
            Text = "Supprimer une horraire";
            FormClosed += SuppHorraire_FormClosed;
            pnlBackround.ResumeLayout(false);
            pnlBackround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBackround;
        private Label lblArret;
        private Button btnSupp;
        private ComboBox comboBoxArret;
        private Label lblTitre;
        private Label lblHorraire;
        private ComboBox comboBoxHorraire;
        private PictureBox pbEspaceAdmin;
    }
}