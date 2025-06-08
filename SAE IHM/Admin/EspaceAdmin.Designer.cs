namespace SAE_IHM
{
    partial class EspaceAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EspaceAdmin));
            lblTitre = new Label();
            btnAjouter = new Button();
            pnlBackround = new Panel();
            pbAcceuil = new PictureBox();
            btnSupprimer = new Button();
            btnModifier = new Button();
            pnlBackround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(22, 18);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(347, 67);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Espace Admin";
            lblTitre.Click += label1_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(147, 141);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 29);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // pnlBackround
            // 
            pnlBackround.BackColor = SystemColors.ControlLightLight;
            pnlBackround.Controls.Add(pbAcceuil);
            pnlBackround.Controls.Add(btnSupprimer);
            pnlBackround.Controls.Add(btnModifier);
            pnlBackround.Controls.Add(lblTitre);
            pnlBackround.Controls.Add(btnAjouter);
            pnlBackround.Location = new Point(400, 200);
            pnlBackround.Name = "pnlBackround";
            pnlBackround.Size = new Size(389, 350);
            pnlBackround.TabIndex = 2;
            pnlBackround.Paint += panel1_Paint;
            // 
            // pbAcceuil
            // 
            pbAcceuil.Image = (Image)resources.GetObject("pbAcceuil.Image");
            pbAcceuil.InitialImage = (Image)resources.GetObject("pbAcceuil.InitialImage");
            pbAcceuil.Location = new Point(37, 290);
            pbAcceuil.Name = "pbAcceuil";
            pbAcceuil.Size = new Size(43, 42);
            pbAcceuil.SizeMode = PictureBoxSizeMode.Zoom;
            pbAcceuil.TabIndex = 9;
            pbAcceuil.TabStop = false;
            pbAcceuil.Click += pbAcceuil_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(147, 239);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(94, 29);
            btnSupprimer.TabIndex = 3;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(147, 190);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(94, 29);
            btnModifier.TabIndex = 2;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += button1_Click;
            // 
            // EspaceAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(pnlBackround);
            Name = "EspaceAdmin";
            Text = "EspaceAdmin";
            FormClosed += EspaceAdmin_FormClosed;
            Load += EspaceAdmin_Load;
            pnlBackround.ResumeLayout(false);
            pnlBackround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAcceuil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitre;
        private Button btnAjouter;
        private Panel pnlBackround;
        private Button btnSupprimer;
        private Button btnModifier;
        private PictureBox pbAcceuil;
    }
}