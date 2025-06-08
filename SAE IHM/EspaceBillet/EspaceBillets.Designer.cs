namespace SAE_IHM
{
    partial class EspaceBillets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EspaceBillets));
            lblTitre = new Label();
            lblTarif = new Label();
            groupBox1 = new GroupBox();
            radioButtonSenior = new RadioButton();
            radioButtonEnfant = new RadioButton();
            radioButtonVeteran = new RadioButton();
            radioButtonAdulte = new RadioButton();
            radioButtonHandicape = new RadioButton();
            lblMoyendePaiement = new Label();
            checkBoxPaypal = new CheckBox();
            checkBoxCB = new CheckBox();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            btnValide = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(59, 23);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(333, 67);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Espace billets";
            lblTitre.Click += label1_Click;
            // 
            // lblTarif
            // 
            lblTarif.AutoSize = true;
            lblTarif.Location = new Point(41, 115);
            lblTarif.Name = "lblTarif";
            lblTarif.Size = new Size(142, 20);
            lblTarif.TabIndex = 1;
            lblTarif.Text = "Saisissez votre tarif :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonSenior);
            groupBox1.Controls.Add(radioButtonEnfant);
            groupBox1.Controls.Add(radioButtonVeteran);
            groupBox1.Controls.Add(radioButtonAdulte);
            groupBox1.Controls.Add(radioButtonHandicape);
            groupBox1.Location = new Point(13, 137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 44);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // radioButtonSenior
            // 
            radioButtonSenior.AutoSize = true;
            radioButtonSenior.Location = new Point(352, 13);
            radioButtonSenior.Name = "radioButtonSenior";
            radioButtonSenior.Size = new Size(72, 24);
            radioButtonSenior.TabIndex = 6;
            radioButtonSenior.TabStop = true;
            radioButtonSenior.Text = "Sénior";
            radioButtonSenior.UseVisualStyleBackColor = true;
            radioButtonSenior.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonEnfant
            // 
            radioButtonEnfant.AutoSize = true;
            radioButtonEnfant.Location = new Point(6, 13);
            radioButtonEnfant.Name = "radioButtonEnfant";
            radioButtonEnfant.Size = new Size(72, 24);
            radioButtonEnfant.TabIndex = 3;
            radioButtonEnfant.TabStop = true;
            radioButtonEnfant.Text = "Enfant";
            radioButtonEnfant.UseVisualStyleBackColor = true;
            radioButtonEnfant.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonVeteran
            // 
            radioButtonVeteran.AutoSize = true;
            radioButtonVeteran.Location = new Point(266, 13);
            radioButtonVeteran.Name = "radioButtonVeteran";
            radioButtonVeteran.Size = new Size(80, 24);
            radioButtonVeteran.TabIndex = 5;
            radioButtonVeteran.TabStop = true;
            radioButtonVeteran.Text = "Vétéran";
            radioButtonVeteran.UseVisualStyleBackColor = true;
            radioButtonVeteran.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonAdulte
            // 
            radioButtonAdulte.AutoSize = true;
            radioButtonAdulte.Location = new Point(85, 13);
            radioButtonAdulte.Name = "radioButtonAdulte";
            radioButtonAdulte.Size = new Size(74, 24);
            radioButtonAdulte.TabIndex = 3;
            radioButtonAdulte.TabStop = true;
            radioButtonAdulte.Text = "Adulte";
            radioButtonAdulte.UseVisualStyleBackColor = true;
            radioButtonAdulte.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonHandicape
            // 
            radioButtonHandicape.AutoSize = true;
            radioButtonHandicape.Location = new Point(158, 13);
            radioButtonHandicape.Name = "radioButtonHandicape";
            radioButtonHandicape.Size = new Size(102, 24);
            radioButtonHandicape.TabIndex = 4;
            radioButtonHandicape.TabStop = true;
            radioButtonHandicape.Text = "Handicapé";
            radioButtonHandicape.UseVisualStyleBackColor = true;
            radioButtonHandicape.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // lblMoyendePaiement
            // 
            lblMoyendePaiement.AutoSize = true;
            lblMoyendePaiement.BackColor = Color.Transparent;
            lblMoyendePaiement.ForeColor = Color.Silver;
            lblMoyendePaiement.Location = new Point(41, 213);
            lblMoyendePaiement.Name = "lblMoyendePaiement";
            lblMoyendePaiement.Size = new Size(315, 20);
            lblMoyendePaiement.TabIndex = 3;
            lblMoyendePaiement.Text = "Veuillez renseigner votre moyen de paiement :";
            // 
            // checkBoxPaypal
            // 
            checkBoxPaypal.AutoSize = true;
            checkBoxPaypal.ForeColor = Color.Silver;
            checkBoxPaypal.Location = new Point(466, 357);
            checkBoxPaypal.Name = "checkBoxPaypal";
            checkBoxPaypal.Size = new Size(74, 24);
            checkBoxPaypal.TabIndex = 4;
            checkBoxPaypal.Text = "Paypal";
            checkBoxPaypal.UseVisualStyleBackColor = true;
            // 
            // checkBoxCB
            // 
            checkBoxCB.AutoSize = true;
            checkBoxCB.ForeColor = Color.Silver;
            checkBoxCB.Location = new Point(87, 249);
            checkBoxCB.Name = "checkBoxCB";
            checkBoxCB.Size = new Size(127, 24);
            checkBoxCB.TabIndex = 5;
            checkBoxCB.Text = "Carte bancaire";
            checkBoxCB.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(11, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnValide);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitre);
            panel1.Controls.Add(lblTarif);
            panel1.Controls.Add(checkBoxCB);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lblMoyendePaiement);
            panel1.Location = new Point(375, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 379);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // btnValide
            // 
            btnValide.Location = new Point(178, 317);
            btnValide.Margin = new Padding(3, 4, 3, 4);
            btnValide.Name = "btnValide";
            btnValide.Size = new Size(86, 31);
            btnValide.TabIndex = 8;
            btnValide.Text = "Valider";
            btnValide.UseVisualStyleBackColor = true;
            btnValide.Click += btnValide_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(394, 317);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // EspaceBillets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Controls.Add(linkLabel1);
            Controls.Add(checkBoxPaypal);
            Name = "EspaceBillets";
            Text = "EspaceBillets";
            FormClosed += EspaceBillets_FormClosed;
            Load += EspaceBillets_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private Label lblTarif;
        private GroupBox groupBox1;
        private RadioButton radioButtonSenior;
        private RadioButton radioButtonEnfant;
        private RadioButton radioButtonVeteran;
        private RadioButton radioButtonAdulte;
        private RadioButton radioButtonHandicape;
        private Label lblMoyendePaiement;
        private CheckBox checkBoxPaypal;
        private CheckBox checkBoxCB;
        private LinkLabel linkLabel1;
        private Label label4;
        private Panel panel1;
        private Button btnRetour;
        private PictureBox pictureBox1;
        private Button btnValide;
    }
}