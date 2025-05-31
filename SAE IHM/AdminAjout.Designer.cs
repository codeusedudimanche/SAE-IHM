namespace SAE_IHM
{
    partial class AdminAjout
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
            pictureBox1 = new PictureBox();
            pbAjoutLigne = new PictureBox();
            pbAjoutArret = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAjoutLigne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAjoutArret).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Location = new Point(424, 159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pbAjoutLigne
            // 
            pbAjoutLigne.BackColor = SystemColors.AppWorkspace;
            pbAjoutLigne.Location = new Point(238, 159);
            pbAjoutLigne.Name = "pbAjoutLigne";
            pbAjoutLigne.Size = new Size(125, 62);
            pbAjoutLigne.TabIndex = 1;
            pbAjoutLigne.TabStop = false;
            pbAjoutLigne.Click += pbAjoutLigne_Click;
            // 
            // pbAjoutArret
            // 
            pbAjoutArret.BackColor = SystemColors.AppWorkspace;
            pbAjoutArret.Location = new Point(52, 159);
            pbAjoutArret.Name = "pbAjoutArret";
            pbAjoutArret.Size = new Size(125, 62);
            pbAjoutArret.TabIndex = 2;
            pbAjoutArret.TabStop = false;
            pbAjoutArret.Click += pbAjoutArret_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 26);
            label1.Name = "label1";
            label1.Size = new Size(199, 67);
            label1.TabIndex = 3;
            label1.Text = "Ajouter";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pbAjoutLigne);
            panel1.Controls.Add(pbAjoutArret);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(297, 191);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 372);
            panel1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(456, 245);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 6;
            label4.Text = "Horaire";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 245);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "Ligne";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 245);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "Arrêt";
            label2.Click += label2_Click;
            // 
            // AdminAjout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Name = "AdminAjout";
            Text = "AdminAjout";
            Load += AdminAjout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAjoutLigne).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAjoutArret).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pbAjoutLigne;
        private PictureBox pbAjoutArret;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}