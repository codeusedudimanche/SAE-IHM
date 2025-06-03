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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbAcceuil
            // 
            pbAcceuil.Image = (Image)resources.GetObject("pbAcceuil.Image");
            pbAcceuil.InitialImage = (Image)resources.GetObject("pbAcceuil.InitialImage");
            pbAcceuil.Location = new Point(42, 459);
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
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 29);
            label1.Name = "label1";
            label1.Size = new Size(223, 46);
            label1.TabIndex = 11;
            label1.Text = "Ajouter Arrêt";
            label1.Click += label1_Click;
            // 
            // lblNomArret
            // 
            lblNomArret.AutoSize = true;
            lblNomArret.Location = new Point(45, 170);
            lblNomArret.Name = "lblNomArret";
            lblNomArret.Size = new Size(105, 20);
            lblNomArret.TabIndex = 12;
            lblNomArret.Text = "Nom de l'arrêt";
            lblNomArret.Click += label2_Click;
            // 
            // txtbNomArret
            // 
            txtbNomArret.Location = new Point(45, 205);
            txtbNomArret.Name = "txtbNomArret";
            txtbNomArret.PlaceholderText = "Exemple : 11th St & 129th E Ave WB";
            txtbNomArret.Size = new Size(454, 27);
            txtbNomArret.TabIndex = 13;
            txtbNomArret.TextChanged += txtbNomArret_TextChanged;
            // 
            // txtbLatitude
            // 
            txtbLatitude.Location = new Point(45, 281);
            txtbLatitude.Name = "txtbLatitude";
            txtbLatitude.PlaceholderText = "Exemple : -95,8357";
            txtbLatitude.Size = new Size(454, 27);
            txtbLatitude.TabIndex = 15;
            txtbLatitude.TextChanged += txtbLatitude_TextChanged;
            // 
            // lblLatitude
            // 
            lblLatitude.AutoSize = true;
            lblLatitude.Location = new Point(45, 247);
            lblLatitude.Name = "lblLatitude";
            lblLatitude.Size = new Size(63, 20);
            lblLatitude.TabIndex = 14;
            lblLatitude.Text = "Latitude";
            lblLatitude.Click += label2_Click_1;
            // 
            // txtbLongitude
            // 
            txtbLongitude.Location = new Point(45, 347);
            txtbLongitude.Name = "txtbLongitude";
            txtbLongitude.PlaceholderText = "Exemple :  36,1481";
            txtbLongitude.Size = new Size(454, 27);
            txtbLongitude.TabIndex = 17;
            txtbLongitude.TextChanged += txtbLongitude_TextChanged;
            // 
            // lblLongitude
            // 
            lblLongitude.AutoSize = true;
            lblLongitude.Location = new Point(45, 317);
            lblLongitude.Name = "lblLongitude";
            lblLongitude.Size = new Size(76, 20);
            lblLongitude.TabIndex = 16;
            lblLongitude.Text = "Longitude";
            // 
            // btnValide
            // 
            btnValide.Enabled = false;
            btnValide.Font = new Font("Segoe UI", 11F);
            btnValide.Location = new Point(42, 398);
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
            label2.Location = new Point(45, 97);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 19;
            label2.Text = "Numéro de l'arrêt";
            // 
            // txtbNumeroArret
            // 
            txtbNumeroArret.Location = new Point(45, 129);
            txtbNumeroArret.Name = "txtbNumeroArret";
            txtbNumeroArret.PlaceholderText = "Exemple : 6927";
            txtbNumeroArret.Size = new Size(454, 27);
            txtbNumeroArret.TabIndex = 20;
            txtbNumeroArret.TextChanged += textBox_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pbAcceuil);
            panel1.Controls.Add(txtbNumeroArret);
            panel1.Controls.Add(lblNomArret);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtbNomArret);
            panel1.Controls.Add(btnValide);
            panel1.Controls.Add(lblLatitude);
            panel1.Controls.Add(txtbLongitude);
            panel1.Controls.Add(txtbLatitude);
            panel1.Controls.Add(lblLongitude);
            panel1.Location = new Point(360, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(547, 530);
            panel1.TabIndex = 21;
            // 
            // AjoutArret
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Name = "AjoutArret";
            Text = "Form1";
            FormClosing += AjoutArret_FormClosing;
            FormClosed += AjoutArret_FormClosed;
            Load += AjoutArret_Load;
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
    }
}