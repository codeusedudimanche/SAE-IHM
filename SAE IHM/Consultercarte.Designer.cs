namespace SAE_IHM
{
    partial class Consultercarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultercarte));
            label1 = new Label();
            btnReseauComplet = new Button();
            btnLigne = new Button();
            btnHoraires = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 30F);
            label1.Location = new Point(0, 31);
            label1.Name = "label1";
            label1.Size = new Size(429, 67);
            label1.TabIndex = 0;
            label1.Text = "Consulter la carte";
            label1.Click += label1_Click;
            // 
            // btnReseauComplet
            // 
            btnReseauComplet.Location = new Point(112, 236);
            btnReseauComplet.Name = "btnReseauComplet";
            btnReseauComplet.Size = new Size(198, 29);
            btnReseauComplet.TabIndex = 1;
            btnReseauComplet.Text = "Le réseau complet";
            btnReseauComplet.UseVisualStyleBackColor = true;
            // 
            // btnLigne
            // 
            btnLigne.Location = new Point(112, 136);
            btnLigne.Name = "btnLigne";
            btnLigne.Size = new Size(198, 29);
            btnLigne.TabIndex = 2;
            btnLigne.Text = "Une ligne particulière";
            btnLigne.UseVisualStyleBackColor = true;
            btnLigne.Click += btnLigne_Click;
            // 
            // btnHoraires
            // 
            btnHoraires.Location = new Point(112, 185);
            btnHoraires.Name = "btnHoraires";
            btnHoraires.Size = new Size(198, 29);
            btnHoraires.TabIndex = 3;
            btnHoraires.Text = "Les horaires";
            btnHoraires.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLigne);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnReseauComplet);
            panel1.Controls.Add(btnHoraires);
            panel1.Location = new Point(402, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 379);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(361, 318);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Consultercarte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Name = "Consultercarte";
            FormClosing += Consultercarte_FormClosing;
            FormClosed += Consultercarte_FormClosed;
            Load += Consultercarte_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnReseauComplet;
        private Button btnLigne;
        private Button btnHoraires;
        private LinkLabel linkLabel1;
        private Label label2;
        private Button btnRetour;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}