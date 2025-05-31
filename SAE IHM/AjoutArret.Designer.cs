namespace SAE_IHM
{
    partial class AjoutArret
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutArret));
            pbAcceuil = new PictureBox();
            label1 = new Label();
            lblNomArret = new Label();
            txtbNomArret = new TextBox();
            txtbLatitude = new TextBox();
            lblLatitude = new Label();
            txtbLongitude = new TextBox();
            lblLongitude = new Label();
            btnValide = new Button();
            label2 = new Label();
            txtbNumeroArret = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).BeginInit();
            SuspendLayout();
            // 
            // pbAcceuil
            // 
            pbAcceuil.Image = (Image)resources.GetObject("pbAcceuil.Image");
            pbAcceuil.InitialImage = (Image)resources.GetObject("pbAcceuil.InitialImage");
            pbAcceuil.Location = new Point(28, 396);
            pbAcceuil.Name = "pbAcceuil";
            pbAcceuil.Size = new Size(43, 42);
            pbAcceuil.SizeMode = PictureBoxSizeMode.Zoom;
            pbAcceuil.TabIndex = 10;
            pbAcceuil.TabStop = false;
            pbAcceuil.Click += pbAcceuil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(289, 9);
            label1.Name = "label1";
            label1.Size = new Size(216, 46);
            label1.TabIndex = 11;
            label1.Text = "Ajouter Arrêt";
            label1.Click += label1_Click;
            // 
            // lblNomArret
            // 
            lblNomArret.AutoSize = true;
            lblNomArret.Location = new Point(163, 150);
            lblNomArret.Name = "lblNomArret";
            lblNomArret.Size = new Size(105, 20);
            lblNomArret.TabIndex = 12;
            lblNomArret.Text = "Nom de l'arrêt";
            lblNomArret.Click += label2_Click;
            // 
            // txtbNomArret
            // 
            txtbNomArret.Location = new Point(163, 185);
            txtbNomArret.Name = "txtbNomArret";
            txtbNomArret.PlaceholderText = "Exemple : 11th St & 129th E Ave WB";
            txtbNomArret.Size = new Size(454, 27);
            txtbNomArret.TabIndex = 13;
            // 
            // txtbLatitude
            // 
            txtbLatitude.Location = new Point(163, 261);
            txtbLatitude.Name = "txtbLatitude";
            txtbLatitude.PlaceholderText = "Exemple : -95,8357";
            txtbLatitude.Size = new Size(454, 27);
            txtbLatitude.TabIndex = 15;
            // 
            // lblLatitude
            // 
            lblLatitude.AutoSize = true;
            lblLatitude.Location = new Point(163, 227);
            lblLatitude.Name = "lblLatitude";
            lblLatitude.Size = new Size(63, 20);
            lblLatitude.TabIndex = 14;
            lblLatitude.Text = "Latitude";
            lblLatitude.Click += label2_Click_1;
            // 
            // txtbLongitude
            // 
            txtbLongitude.Location = new Point(163, 327);
            txtbLongitude.Name = "txtbLongitude";
            txtbLongitude.PlaceholderText = "Exemple :  36,1481";
            txtbLongitude.Size = new Size(454, 27);
            txtbLongitude.TabIndex = 17;
            // 
            // lblLongitude
            // 
            lblLongitude.AutoSize = true;
            lblLongitude.Location = new Point(163, 297);
            lblLongitude.Name = "lblLongitude";
            lblLongitude.Size = new Size(76, 20);
            lblLongitude.TabIndex = 16;
            lblLongitude.Text = "Longitude";
            // 
            // btnValide
            // 
            btnValide.Font = new Font("Segoe UI", 11F);
            btnValide.Location = new Point(160, 378);
            btnValide.Name = "btnValide";
            btnValide.Size = new Size(457, 40);
            btnValide.TabIndex = 18;
            btnValide.Text = "Valider";
            btnValide.UseVisualStyleBackColor = true;
            btnValide.Click += btnValider_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 77);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 19;
            label2.Text = "Numéro de l'arrêt";
            // 
            // txtbNumeroArret
            // 
            txtbNumeroArret.Location = new Point(163, 109);
            txtbNumeroArret.Name = "txtbNumeroArret";
            txtbNumeroArret.PlaceholderText = "Exemple : 6927";
            txtbNumeroArret.Size = new Size(454, 27);
            txtbNumeroArret.TabIndex = 20;
            // 
            // AjoutArret
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtbNumeroArret);
            Controls.Add(label2);
            Controls.Add(btnValide);
            Controls.Add(txtbLongitude);
            Controls.Add(lblLongitude);
            Controls.Add(txtbLatitude);
            Controls.Add(lblLatitude);
            Controls.Add(txtbNomArret);
            Controls.Add(lblNomArret);
            Controls.Add(label1);
            Controls.Add(pbAcceuil);
            Name = "AjoutArret";
            Text = "Form1";
            FormClosing += AjoutArret_FormClosing;
            FormClosed += AjoutArret_FormClosed;
            Load += AjoutArret_Load;
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbAcceuil;
        private Label label1;
        private Label lblNomArret;
        private TextBox txtbNomArret;
        private TextBox txtbLatitude;
        private Label lblLatitude;
        private TextBox txtbLongitude;
        private Label lblLongitude;
        private Button btnValide;
        private Label label2;
        private TextBox txtbNumeroArret;
    }
}