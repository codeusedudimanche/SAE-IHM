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
            ((System.ComponentModel.ISupportInitialize)nudHeure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 20F);
            lblTitre.Location = new Point(273, 9);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(293, 46);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Ajouter un horaire";
            // 
            // lbArret
            // 
            lbArret.FormattingEnabled = true;
            lbArret.Location = new Point(449, 229);
            lbArret.Name = "lbArret";
            lbArret.Size = new Size(249, 104);
            lbArret.TabIndex = 2;
            // 
            // lblHoraire
            // 
            lblHoraire.AutoSize = true;
            lblHoraire.Location = new Point(189, 83);
            lblHoraire.Name = "lblHoraire";
            lblHoraire.Size = new Size(66, 20);
            lblHoraire.TabIndex = 4;
            lblHoraire.Text = "Horaire :";
            // 
            // nudHeure
            // 
            nudHeure.Location = new Point(133, 124);
            nudHeure.Name = "nudHeure";
            nudHeure.Size = new Size(47, 27);
            nudHeure.TabIndex = 5;
            // 
            // lblHeure
            // 
            lblHeure.AutoSize = true;
            lblHeure.Location = new Point(189, 126);
            lblHeure.Name = "lblHeure";
            lblHeure.Size = new Size(49, 20);
            lblHeure.TabIndex = 6;
            lblHeure.Text = "Heure";
            // 
            // lblMinute
            // 
            lblMinute.AutoSize = true;
            lblMinute.Location = new Point(318, 126);
            lblMinute.Name = "lblMinute";
            lblMinute.Size = new Size(55, 20);
            lblMinute.TabIndex = 8;
            lblMinute.Text = "Minute";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(262, 124);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(47, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // lblTitreLigne
            // 
            lblTitreLigne.AutoSize = true;
            lblTitreLigne.Location = new Point(118, 198);
            lblTitreLigne.Name = "lblTitreLigne";
            lblTitreLigne.Size = new Size(141, 20);
            lblTitreLigne.TabIndex = 9;
            lblTitreLigne.Text = "Choisissez une ligne";
            // 
            // lblChoixArret
            // 
            lblChoixArret.AutoSize = true;
            lblChoixArret.Location = new Point(449, 198);
            lblChoixArret.Name = "lblChoixArret";
            lblChoixArret.Size = new Size(131, 20);
            lblChoixArret.TabIndex = 10;
            lblChoixArret.Text = "Choisissez un arret";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 83);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 11;
            label1.Text = "Choisissez la période :";
            // 
            // cbSemain
            // 
            cbSemain.AutoSize = true;
            cbSemain.Location = new Point(435, 128);
            cbSemain.Name = "cbSemain";
            cbSemain.Size = new Size(154, 24);
            cbSemain.TabIndex = 12;
            cbSemain.Text = "Jour de la semaine";
            cbSemain.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(604, 129);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(184, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Jour fériée et week end";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(93, 381);
            button1.Name = "button1";
            button1.Size = new Size(620, 46);
            button1.TabIndex = 14;
            button1.Text = "Valider l'ajout de l'horraire";
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
            lbLigne.Location = new Point(118, 229);
            lbLigne.Name = "lbLigne";
            lbLigne.Size = new Size(246, 104);
            lbLigne.TabIndex = 1;
            lbLigne.SelectedIndexChanged += lbLigne_SelectedIndexChanged;
            // 
            // AjoutHoraire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbEspaceAdmin);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(cbSemain);
            Controls.Add(label1);
            Controls.Add(lblChoixArret);
            Controls.Add(lblTitreLigne);
            Controls.Add(lblMinute);
            Controls.Add(numericUpDown1);
            Controls.Add(lblHeure);
            Controls.Add(nudHeure);
            Controls.Add(lblHoraire);
            Controls.Add(lbArret);
            Controls.Add(lbLigne);
            Controls.Add(lblTitre);
            Name = "AjoutHoraire";
            Text = "AjoutHoraire";
            FormClosed += AjoutHoraire_FormClosed;
            Load += AjoutHoraire_Load;
            ((System.ComponentModel.ISupportInitialize)nudHeure).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}