namespace SAE_IHM
{
    partial class RechercherTrajet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RechercherTrajet));
            lblTitre = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            textBoxArretDepart = new TextBox();
            textBoxArretArrivee = new TextBox();
            checkBoxHoraire = new CheckBox();
            pnlBackround = new Panel();
            pictureBox1 = new PictureBox();
            pnlBackround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(4, 24);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(491, 67);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Rechercher un trajet";
            lblTitre.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // textBoxArretDepart
            // 
            textBoxArretDepart.ForeColor = Color.Gray;
            textBoxArretDepart.Location = new Point(59, 137);
            textBoxArretDepart.Name = "textBoxArretDepart";
            textBoxArretDepart.PlaceholderText = "Arrêt de départ";
            textBoxArretDepart.Size = new Size(165, 27);
            textBoxArretDepart.TabIndex = 3;
            // 
            // textBoxArretArrivee
            // 
            textBoxArretArrivee.ForeColor = Color.Gray;
            textBoxArretArrivee.Location = new Point(280, 137);
            textBoxArretArrivee.Name = "textBoxArretArrivee";
            textBoxArretArrivee.PlaceholderText = "Arrêt d'arrivée";
            textBoxArretArrivee.Size = new Size(165, 27);
            textBoxArretArrivee.TabIndex = 4;
            textBoxArretArrivee.Tag = "";
            // 
            // checkBoxHoraire
            // 
            checkBoxHoraire.AutoSize = true;
            checkBoxHoraire.Location = new Point(59, 194);
            checkBoxHoraire.Name = "checkBoxHoraire";
            checkBoxHoraire.Size = new Size(277, 24);
            checkBoxHoraire.TabIndex = 5;
            checkBoxHoraire.Text = "Voulez-vous sélectionner un horaire ?";
            checkBoxHoraire.UseVisualStyleBackColor = true;
            checkBoxHoraire.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pnlBackround
            // 
            pnlBackround.BackColor = SystemColors.ControlLightLight;
            pnlBackround.Controls.Add(pictureBox1);
            pnlBackround.Controls.Add(lblTitre);
            pnlBackround.Controls.Add(checkBoxHoraire);
            pnlBackround.Controls.Add(textBoxArretDepart);
            pnlBackround.Controls.Add(textBoxArretArrivee);
            pnlBackround.Location = new Point(350, 200);
            pnlBackround.Name = "pnlBackround";
            pnlBackround.Size = new Size(498, 364);
            pnlBackround.TabIndex = 6;
            pnlBackround.Paint += pnlBackround_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(432, 303);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // RechercherTrajet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(pnlBackround);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Name = "RechercherTrajet";
            Text = "RechercherTrajet";
            FormClosing += RechercherTrajet_FormClosing;
            pnlBackround.ResumeLayout(false);
            pnlBackround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private LinkLabel linkLabel1;
        private Label label2;
        private TextBox textBoxArretDepart;
        private TextBox textBoxArretArrivee;
        private CheckBox checkBoxHoraire;
        private Panel pnlBackround;
        private PictureBox pictureBox1;
    }
}