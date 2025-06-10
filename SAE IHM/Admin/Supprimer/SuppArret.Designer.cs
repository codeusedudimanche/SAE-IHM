namespace SAE_IHM
{
    partial class SuppArret
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppArret));
            pnlBackround = new Panel();
            lblChoisir = new Label();
            pbEspaceAdmin = new PictureBox();
            btnSupp = new Button();
            comboBoxArret = new ComboBox();
            lblTitre = new Label();
            pnlBackround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).BeginInit();
            SuspendLayout();
            // 
            // pnlBackround
            // 
            pnlBackround.Controls.Add(lblChoisir);
            pnlBackround.Controls.Add(pbEspaceAdmin);
            pnlBackround.Controls.Add(btnSupp);
            pnlBackround.Controls.Add(comboBoxArret);
            pnlBackround.Controls.Add(lblTitre);
            pnlBackround.Location = new Point(266, 31);
            pnlBackround.Name = "pnlBackround";
            pnlBackround.Size = new Size(427, 320);
            pnlBackround.TabIndex = 1;
            // 
            // lblChoisir
            // 
            lblChoisir.AutoSize = true;
            lblChoisir.Location = new Point(83, 124);
            lblChoisir.Name = "lblChoisir";
            lblChoisir.Size = new Size(104, 15);
            lblChoisir.TabIndex = 13;
            lblChoisir.Text = "Choisisser un arret";
            // 
            // pbEspaceAdmin
            // 
            pbEspaceAdmin.Image = (Image)resources.GetObject("pbEspaceAdmin.Image");
            pbEspaceAdmin.InitialImage = (Image)resources.GetObject("pbEspaceAdmin.InitialImage");
            pbEspaceAdmin.Location = new Point(27, 272);
            pbEspaceAdmin.Margin = new Padding(3, 2, 3, 2);
            pbEspaceAdmin.Name = "pbEspaceAdmin";
            pbEspaceAdmin.Size = new Size(38, 32);
            pbEspaceAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pbEspaceAdmin.TabIndex = 12;
            pbEspaceAdmin.TabStop = false;
            pbEspaceAdmin.Click += pbEspaceAdmin_Click;
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
            comboBoxArret.Location = new Point(83, 142);
            comboBoxArret.Name = "comboBoxArret";
            comboBoxArret.Size = new Size(265, 23);
            comboBoxArret.TabIndex = 1;
            comboBoxArret.SelectedIndexChanged += comboBoxArret_SelectedIndexChanged;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblTitre.Location = new Point(83, 25);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(249, 37);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Supprimer un arret";
            // 
            // SuppArret
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1034, 562);
            Controls.Add(pnlBackround);
            Name = "SuppArret";
            Text = "Supprimer un arrêt";
            FormClosed += SuppArret_FormClosed;
            pnlBackround.ResumeLayout(false);
            pnlBackround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBackround;
        private Label lblChoisir;
        private PictureBox pbEspaceAdmin;
        private Button btnSupp;
        private ComboBox comboBoxArret;
        private Label lblTitre;
    }
}