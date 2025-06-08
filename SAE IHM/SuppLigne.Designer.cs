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
            panel1 = new Panel();
            pbEspaceAdmin = new PictureBox();
            btnSupp = new Button();
            comboBoxLigne = new ComboBox();
            ligneBindingSource1 = new BindingSource(components);
            label1 = new Label();
            ligneBindingSource = new BindingSource(components);
            lblChoisir = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ligneBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ligneBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblChoisir);
            panel1.Controls.Add(pbEspaceAdmin);
            panel1.Controls.Add(btnSupp);
            panel1.Controls.Add(comboBoxLigne);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(293, 41);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 427);
            panel1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            label1.Location = new Point(95, 33);
            label1.Name = "label1";
            label1.Size = new Size(334, 46);
            label1.TabIndex = 0;
            label1.Text = "Supprimer une ligne";
            // 
            // ligneBindingSource
            // 
            ligneBindingSource.DataSource = typeof(Base.Ligne);
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
            // SuppLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 749);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SuppLigne";
            Text = "Supprimer une ligne";
            FormClosed += SuppLigne_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)ligneBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ligneBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox comboBoxLigne;
        private Button btnSupp;
        private BindingSource ligneBindingSource;
        private BindingSource ligneBindingSource1;
        private PictureBox pbEspaceAdmin;
        private Label lblChoisir;
    }
}