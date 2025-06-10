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
            panel1.Location = new Point(293, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 372);
            panel1.TabIndex = 5;
            // 
            // pbAcceuil
            // 
            pbAcceuil.Image = (Image)resources.GetObject("pbAcceuil.Image");
            pbAcceuil.InitialImage = (Image)resources.GetObject("pbAcceuil.InitialImage");
            pbAcceuil.Location = new Point(26, 315);
            pbAcceuil.Name = "pbAcceuil";
            pbAcceuil.Size = new Size(43, 43);
            pbAcceuil.SizeMode = PictureBoxSizeMode.Zoom;
            pbAcceuil.TabIndex = 11;
            pbAcceuil.TabStop = false;
            pbAcceuil.Click += pbAcceuil_Click;
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 245);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "Arrêt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 20);
            label1.Name = "label1";
            label1.Size = new Size(267, 67);
            label1.TabIndex = 3;
            label1.Text = "Supprimer";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pbSuppLigne
            // 
            pbSuppLigne.BackColor = Color.White;
            pbSuppLigne.Image = (Image)resources.GetObject("pbSuppLigne.Image");
            pbSuppLigne.Location = new Point(238, 159);
            pbSuppLigne.Name = "pbSuppLigne";
            pbSuppLigne.Size = new Size(125, 61);
            pbSuppLigne.SizeMode = PictureBoxSizeMode.Zoom;
            pbSuppLigne.TabIndex = 1;
            pbSuppLigne.TabStop = false;
            pbSuppLigne.Click += pbSuppLigne_Click;
            // 
            // pbSuppArret
            // 
            pbSuppArret.BackColor = Color.White;
            pbSuppArret.Image = (Image)resources.GetObject("pbSuppArret.Image");
            pbSuppArret.Location = new Point(53, 159);
            pbSuppArret.Name = "pbSuppArret";
            pbSuppArret.Size = new Size(125, 61);
            pbSuppArret.SizeMode = PictureBoxSizeMode.Zoom;
            pbSuppArret.TabIndex = 2;
            pbSuppArret.TabStop = false;
            pbSuppArret.Click += pbSuppArret_Click;
            // 
            // pbSuppHorraire
            // 
            pbSuppHorraire.BackColor = Color.White;
            pbSuppHorraire.Image = (Image)resources.GetObject("pbSuppHorraire.Image");
            pbSuppHorraire.Location = new Point(424, 159);
            pbSuppHorraire.Name = "pbSuppHorraire";
            pbSuppHorraire.Size = new Size(125, 61);
            pbSuppHorraire.SizeMode = PictureBoxSizeMode.Zoom;
            pbSuppHorraire.TabIndex = 0;
            pbSuppHorraire.TabStop = false;
            pbSuppHorraire.Click += pbSuppHorraire_Click;
            // 
            // AdminSupp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 749);
            Controls.Add(panel1);
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