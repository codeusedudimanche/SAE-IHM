namespace SAE_IHM
{
    partial class SuppLigne
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppLigne));
            pnlBackround = new Panel();
            lblChoisir = new Label();
            pbEspaceAdmin = new PictureBox();
            btnSupp = new Button();
            comboBoxLigne = new ComboBox();
            ligneBindingSource1 = new BindingSource(components);
            lblTitre = new Label();
            ligneBindingSource = new BindingSource(components);
            pnlBackround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ligneBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ligneBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnlBackround
            // 
            pnlBackround.Controls.Add(lblChoisir);
            pnlBackround.Controls.Add(pbEspaceAdmin);
            pnlBackround.Controls.Add(btnSupp);
            pnlBackround.Controls.Add(comboBoxLigne);
            pnlBackround.Controls.Add(lblTitre);
            pnlBackround.Location = new Point(293, 41);
            pnlBackround.Margin = new Padding(3, 4, 3, 4);
            pnlBackround.Name = "pnlBackround";
            pnlBackround.Size = new Size(488, 427);
            pnlBackround.TabIndex = 0;
            // 
            // lblChoisir
            // 
            lblChoisir.AutoSize = true;
            lblChoisir.Location = new Point(95, 165);
            lblChoisir.Name = "lblChoisir";
            lblChoisir.Size = new Size(139, 20);
            lblChoisir.TabIndex = 13;
            lblChoisir.Text = "Choisisser une ligne";
            // 
            // pbEspaceAdmin
            // 
            pbEspaceAdmin.Image = (Image)resources.GetObject("pbEspaceAdmin.Image");
            pbEspaceAdmin.InitialImage = (Image)resources.GetObject("pbEspaceAdmin.InitialImage");
            pbEspaceAdmin.Location = new Point(31, 362);
            pbEspaceAdmin.Name = "pbEspaceAdmin";
            pbEspaceAdmin.Size = new Size(43, 42);
            pbEspaceAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pbEspaceAdmin.TabIndex = 12;
            pbEspaceAdmin.TabStop = false;
            pbEspaceAdmin.Click += pbEspaceAdmin_Click;
            // 
            // btnSupp
            // 
            btnSupp.Location = new Point(95, 289);
            btnSupp.Margin = new Padding(3, 4, 3, 4);
            btnSupp.Name = "btnSupp";
            btnSupp.Size = new Size(303, 45);
            btnSupp.TabIndex = 2;
            btnSupp.Text = "Supprimer";
            btnSupp.UseVisualStyleBackColor = true;
            btnSupp.Click += btnSupp_Click;
            // 
            // comboBoxLigne
            // 
            comboBoxLigne.DataSource = ligneBindingSource1;
            comboBoxLigne.FormattingEnabled = true;
            comboBoxLigne.Location = new Point(95, 189);
            comboBoxLigne.Margin = new Padding(3, 4, 3, 4);
            comboBoxLigne.Name = "comboBoxLigne";
            comboBoxLigne.Size = new Size(302, 28);
            comboBoxLigne.TabIndex = 1;
            comboBoxLigne.SelectedIndexChanged += comboBoxLigne_SelectedIndexChanged;
            // 
            // ligneBindingSource1
            // 
            ligneBindingSource1.DataSource = typeof(Base.Ligne);
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblTitre.Location = new Point(95, 33);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(334, 46);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Supprimer une ligne";
            // 
            // ligneBindingSource
            // 
            ligneBindingSource.DataSource = typeof(Base.Ligne);
            // 
            // SuppLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 749);
            Controls.Add(pnlBackround);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SuppLigne";
            Text = "Supprimer une ligne";
            FormClosed += SuppLigne_FormClosed;
            pnlBackround.ResumeLayout(false);
            pnlBackround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)ligneBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ligneBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBackround;
        private Label lblTitre;
        private ComboBox comboBoxLigne;
        private Button btnSupp;
        private BindingSource ligneBindingSource;
        private BindingSource ligneBindingSource1;
        private PictureBox pbEspaceAdmin;
        private Label lblChoisir;
    }
}