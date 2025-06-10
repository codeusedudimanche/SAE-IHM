namespace SAE_IHM.Admin
{
    partial class MotDePasseOublie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotDePasseOublie));
            panel1 = new Panel();
            pbAcceuil = new PictureBox();
            btnValiderCode = new Button();
            txtCode = new TextBox();
            lblCode = new Label();
            btnValiderEmail = new Button();
            lblTitre = new Label();
            txtMail = new TextBox();
            lblEmail = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pbAcceuil);
            panel1.Controls.Add(btnValiderCode);
            panel1.Controls.Add(txtCode);
            panel1.Controls.Add(lblCode);
            panel1.Controls.Add(btnValiderEmail);
            panel1.Controls.Add(lblTitre);
            panel1.Controls.Add(txtMail);
            panel1.Controls.Add(lblEmail);
            panel1.Location = new Point(219, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(607, 499);
            panel1.TabIndex = 0;
            // 
            // pbAcceuil
            // 
            pbAcceuil.Image = (Image)resources.GetObject("pbAcceuil.Image");
            pbAcceuil.InitialImage = (Image)resources.GetObject("pbAcceuil.InitialImage");
            pbAcceuil.Location = new Point(22, 437);
            pbAcceuil.Name = "pbAcceuil";
            pbAcceuil.Size = new Size(43, 42);
            pbAcceuil.SizeMode = PictureBoxSizeMode.Zoom;
            pbAcceuil.TabIndex = 10;
            pbAcceuil.TabStop = false;
            pbAcceuil.Click += pbAcceuil_Click;
            // 
            // btnValiderCode
            // 
            btnValiderCode.Location = new Point(117, 333);
            btnValiderCode.Name = "btnValiderCode";
            btnValiderCode.Size = new Size(385, 29);
            btnValiderCode.TabIndex = 6;
            btnValiderCode.Text = "Valider";
            btnValiderCode.UseVisualStyleBackColor = true;
            btnValiderCode.Visible = false;
            btnValiderCode.Click += btnValiderCode_Click;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(117, 300);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(385, 27);
            txtCode.TabIndex = 5;
            txtCode.Visible = false;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(117, 277);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(188, 20);
            lblCode.TabIndex = 4;
            lblCode.Text = "Saisir le code recu par mail";
            lblCode.Visible = false;
            // 
            // btnValiderEmail
            // 
            btnValiderEmail.Location = new Point(117, 150);
            btnValiderEmail.Name = "btnValiderEmail";
            btnValiderEmail.Size = new Size(385, 29);
            btnValiderEmail.TabIndex = 3;
            btnValiderEmail.Text = "Valider";
            btnValiderEmail.UseVisualStyleBackColor = true;
            btnValiderEmail.Click += btnValiderEmail_Click;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblTitre.Location = new Point(162, 20);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(330, 46);
            lblTitre.TabIndex = 2;
            lblTitre.Text = "Mot de passe oublie";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(117, 117);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(385, 27);
            txtMail.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(117, 94);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(115, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Saisir votre mail";
            // 
            // MotDePasseOublie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Name = "MotDePasseOublie";
            Text = "MotDePasseOublie";
            FormClosed += MotDePasseOublie_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitre;
        private TextBox txtMail;
        private Label lblEmail;
        private Button btnValiderEmail;
        private TextBox txtCode;
        private Label lblCode;
        private Button btnValiderCode;
        private PictureBox pbAcceuil;
    }
}