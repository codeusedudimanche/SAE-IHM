namespace SAE_IHM
{
    partial class AjoutHoraire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutHoraire));
            lblTitre = new Label();
            lbArret = new ListBox();
            lblHoraire = new Label();
            nudHeure = new NumericUpDown();
            lblHeure = new Label();
            lblMinute = new Label();
            numericUpDown1 = new NumericUpDown();
            lblTitreLigne = new Label();
            lblChoixArret = new Label();
            label1 = new Label();
            cbSemain = new CheckBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            pbEspaceAdmin = new PictureBox();
            lbLigne = new ListBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)nudHeure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(185, 26);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(304, 46);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Ajouter un horaire";
            // 
            // lbArret
            // 
            lbArret.FormattingEnabled = true;
            lbArret.Location = new Point(378, 306);
            lbArret.Name = "lbArret";
            lbArret.Size = new Size(249, 104);
            lbArret.TabIndex = 2;
            // 
            // lblHoraire
            // 
            lblHoraire.AutoSize = true;
            lblHoraire.Location = new Point(13, 10);
            lblHoraire.Name = "lblHoraire";
            lblHoraire.Size = new Size(141, 20);
            lblHoraire.TabIndex = 4;
            lblHoraire.Text = "Choisissez l'horaire :";
            // 
            // nudHeure
            // 
            nudHeure.Location = new Point(50, 72);
            nudHeure.Name = "nudHeure";
            nudHeure.Size = new Size(47, 27);
            nudHeure.TabIndex = 5;
            // 
            // lblHeure
            // 
            lblHeure.AutoSize = true;
            lblHeure.Location = new Point(44, 47);
            lblHeure.Name = "lblHeure";
            lblHeure.Size = new Size(55, 20);
            lblHeure.TabIndex = 6;
            lblHeure.Text = "Heures";
            // 
            // lblMinute
            // 
            lblMinute.AutoSize = true;
            lblMinute.Location = new Point(140, 47);
            lblMinute.Name = "lblMinute";
            lblMinute.Size = new Size(61, 20);
            lblMinute.TabIndex = 8;
            lblMinute.Text = "Minutes";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(147, 72);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(47, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // lblTitreLigne
            // 
            lblTitreLigne.AutoSize = true;
            lblTitreLigne.Location = new Point(35, 270);
            lblTitreLigne.Name = "lblTitreLigne";
            lblTitreLigne.Size = new Size(148, 20);
            lblTitreLigne.TabIndex = 9;
            lblTitreLigne.Text = "Choisissez une ligne :";
            // 
            // lblChoixArret
            // 
            lblChoixArret.AutoSize = true;
            lblChoixArret.Location = new Point(378, 270);
            lblChoixArret.Name = "lblChoixArret";
            lblChoixArret.Size = new Size(138, 20);
            lblChoixArret.TabIndex = 10;
            lblChoixArret.Text = "Choisissez un arrêt :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 11;
            label1.Text = "Choisissez la période :";
            // 
            // cbSemain
            // 
            cbSemain.AutoSize = true;
            cbSemain.Location = new Point(27, 52);
            cbSemain.Name = "cbSemain";
            cbSemain.Size = new Size(154, 24);
            cbSemain.TabIndex = 12;
            cbSemain.Text = "Jour de la semaine";
            cbSemain.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(27, 82);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(178, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Jour férié et week-end";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(183, 448);
            button1.Name = "button1";
            button1.Size = new Size(312, 46);
            button1.TabIndex = 14;
            button1.Text = "Valider";
            button1.UseVisualStyleBackColor = true;
            // 
            // pbEspaceAdmin
            // 
            pbEspaceAdmin.Image = (Image)resources.GetObject("pbEspaceAdmin.Image");
            pbEspaceAdmin.InitialImage = (Image)resources.GetObject("pbEspaceAdmin.InitialImage");
            pbEspaceAdmin.Location = new Point(32, 381);
            pbEspaceAdmin.Name = "pbEspaceAdmin";
            pbEspaceAdmin.Size = new Size(43, 42);
            pbEspaceAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pbEspaceAdmin.TabIndex = 15;
            pbEspaceAdmin.TabStop = false;
            pbEspaceAdmin.Click += pbEspaceAdmin_Click;
            // 
            // lbLigne
            // 
            lbLigne.FormattingEnabled = true;
            lbLigne.Location = new Point(35, 306);
            lbLigne.Name = "lbLigne";
            lbLigne.Size = new Size(246, 104);
            lbLigne.TabIndex = 1;
            lbLigne.SelectedIndexChanged += lbLigne_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lbArret);
            panel1.Controls.Add(lblTitre);
            panel1.Controls.Add(lblChoixArret);
            panel1.Controls.Add(lbLigne);
            panel1.Controls.Add(lblTitreLigne);
            panel1.Location = new Point(270, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 541);
            panel1.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cbSemain);
            panel3.Controls.Add(checkBox1);
            panel3.Location = new Point(378, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(246, 125);
            panel3.TabIndex = 16;
            panel3.Paint += panel3_Paint;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblHoraire);
            panel2.Controls.Add(lblHeure);
            panel2.Controls.Add(nudHeure);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(lblMinute);
            panel2.Location = new Point(35, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 125);
            panel2.TabIndex = 15;
            // 
            // AjoutHoraire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Controls.Add(pbEspaceAdmin);
            Name = "AjoutHoraire";
            Text = "AjoutHoraire";
            FormClosed += AjoutHoraire_FormClosed;
            Load += AjoutHoraire_Load;
            ((System.ComponentModel.ISupportInitialize)nudHeure).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitre;
        private ListBox lbArret;
        private Label lblHoraire;
        private NumericUpDown nudHeure;
        private Label lblHeure;
        private Label lblMinute;
        private NumericUpDown numericUpDown1;
        private Label lblTitreLigne;
        private Label lblChoixArret;
        private Label label1;
        private CheckBox cbSemain;
        private CheckBox checkBox1;
        private Button button1;
        private PictureBox pbEspaceAdmin;
        private ListBox lbLigne;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
    }
}