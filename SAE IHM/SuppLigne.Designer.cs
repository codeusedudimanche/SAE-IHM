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
            panel1 = new Panel();
            btnSupp = new Button();
            comboBoxLigne = new ComboBox();
            ligneBindingSource1 = new BindingSource(components);
            label1 = new Label();
            ligneBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ligneBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ligneBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSupp);
            panel1.Controls.Add(comboBoxLigne);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(256, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 320);
            panel1.TabIndex = 0;
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
            // comboBoxLigne
            // 
            comboBoxLigne.DataSource = ligneBindingSource1;
            comboBoxLigne.FormattingEnabled = true;
            comboBoxLigne.Location = new Point(83, 142);
            comboBoxLigne.Name = "comboBoxLigne";
            comboBoxLigne.Size = new Size(265, 23);
            comboBoxLigne.TabIndex = 1;
            // 
            // ligneBindingSource1
            // 
            ligneBindingSource1.DataSource = typeof(Base.Ligne);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            label1.Location = new Point(83, 25);
            label1.Name = "label1";
            label1.Size = new Size(265, 37);
            label1.TabIndex = 0;
            label1.Text = "Supprimer une ligne";
            // 
            // ligneBindingSource
            // 
            ligneBindingSource.DataSource = typeof(Base.Ligne);
            // 
            // SuppLigne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1034, 562);
            Controls.Add(panel1);
            Name = "SuppLigne";
            Text = "Supprimer une ligne";
            FormClosed += SuppLigne_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}