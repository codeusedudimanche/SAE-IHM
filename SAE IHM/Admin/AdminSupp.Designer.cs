namespace SAE_IHM
{
    partial class AdminSupp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSupp));
            panel1 = new Panel();
            pbAcceuil = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pbSuppLigne = new PictureBox();
            pbSuppArret = new PictureBox();
            pbSuppHorraire = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSuppLigne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSuppArret).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSuppHorraire).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(pbAcceuil);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pbSuppLigne);
            panel1.Controls.Add(pbSuppArret);
            panel1.Controls.Add(pbSuppHorraire);
            panel1.Location = new Point(256, 142);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 279);
            panel1.TabIndex = 5;
            // 
            // pbAcceuil
            // 
            pbAcceuil.Image = (Image)resources.GetObject("pbAcceuil.Image");
            pbAcceuil.InitialImage = (Image)resources.GetObject("pbAcceuil.InitialImage");
            pbAcceuil.Location = new Point(23, 236);
            pbAcceuil.Margin = new Padding(3, 2, 3, 2);
            pbAcceuil.Name = "pbAcceuil";
            pbAcceuil.Size = new Size(38, 32);
            pbAcceuil.SizeMode = PictureBoxSizeMode.Zoom;
            pbAcceuil.TabIndex = 11;
            pbAcceuil.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 184);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 6;
            label4.Text = "Horaire";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 184);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Ligne";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 184);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "Arrêt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 15);
            label1.Name = "label1";
            label1.Size = new Size(212, 54);
            label1.TabIndex = 3;
            label1.Text = "Supprimer";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pbSuppLigne
            // 
            pbSuppLigne.BackColor = SystemColors.AppWorkspace;
            pbSuppLigne.Location = new Point(208, 119);
            pbSuppLigne.Margin = new Padding(3, 2, 3, 2);
            pbSuppLigne.Name = "pbSuppLigne";
            pbSuppLigne.Size = new Size(109, 46);
            pbSuppLigne.TabIndex = 1;
            pbSuppLigne.TabStop = false;
            pbSuppLigne.Click += pbSuppLigne_Click;
            // 
            // pbSuppArret
            // 
            pbSuppArret.BackColor = SystemColors.AppWorkspace;
            pbSuppArret.Location = new Point(46, 119);
            pbSuppArret.Margin = new Padding(3, 2, 3, 2);
            pbSuppArret.Name = "pbSuppArret";
            pbSuppArret.Size = new Size(109, 46);
            pbSuppArret.TabIndex = 2;
            pbSuppArret.TabStop = false;
            pbSuppArret.Click += pbSuppArret_Click;
            // 
            // pbSuppHorraire
            // 
            pbSuppHorraire.BackColor = SystemColors.AppWorkspace;
            pbSuppHorraire.Location = new Point(371, 119);
            pbSuppHorraire.Margin = new Padding(3, 2, 3, 2);
            pbSuppHorraire.Name = "pbSuppHorraire";
            pbSuppHorraire.Size = new Size(109, 46);
            pbSuppHorraire.TabIndex = 0;
            pbSuppHorraire.TabStop = false;
            pbSuppHorraire.Click += pbSuppHorraire_Click;
            // 
            // AdminSupp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1034, 562);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminSupp";
            Text = "Supprimer";
            FormClosed += AdminSupp_FormClosed;
            Load += AdminSupp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSuppLigne).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSuppArret).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSuppHorraire).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbAcceuil;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pbSuppLigne;
        private PictureBox pbSuppArret;
        private PictureBox pbSuppHorraire;
    }
}