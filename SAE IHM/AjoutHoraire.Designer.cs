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
            lblTitre = new Label();
            lbLigne = new ListBox();
            lbArret = new ListBox();
            lblHoraire = new Label();
            nudHeure = new NumericUpDown();
            lblHeure = new Label();
            lblMinute = new Label();
            numericUpDown1 = new NumericUpDown();
            btnValiderLigne = new Button();
            lblTitreLigne = new Label();
            lblChoixArret = new Label();
            label1 = new Label();
            cbSemain = new CheckBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudHeure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            // lbLigne
            // 
            lbLigne.FormattingEnabled = true;
            lbLigne.Location = new Point(109, 95);
            lbLigne.Name = "lbLigne";
            lbLigne.Size = new Size(246, 104);
            lbLigne.TabIndex = 1;
            // 
            // lbArret
            // 
            lbArret.FormattingEnabled = true;
            lbArret.Location = new Point(106, 271);
            lbArret.Name = "lbArret";
            lbArret.Size = new Size(249, 104);
            lbArret.TabIndex = 2;
            // 
            // lblHoraire
            // 
            lblHoraire.AutoSize = true;
            lblHoraire.Location = new Point(525, 87);
            lblHoraire.Name = "lblHoraire";
            lblHoraire.Size = new Size(66, 20);
            lblHoraire.TabIndex = 4;
            lblHoraire.Text = "Horaire :";
            // 
            // nudHeure
            // 
            nudHeure.Location = new Point(486, 128);
            nudHeure.Name = "nudHeure";
            nudHeure.Size = new Size(47, 27);
            nudHeure.TabIndex = 5;
            // 
            // lblHeure
            // 
            lblHeure.AutoSize = true;
            lblHeure.Location = new Point(542, 130);
            lblHeure.Name = "lblHeure";
            lblHeure.Size = new Size(49, 20);
            lblHeure.TabIndex = 6;
            lblHeure.Text = "Heure";
            // 
            // lblMinute
            // 
            lblMinute.AutoSize = true;
            lblMinute.Location = new Point(671, 130);
            lblMinute.Name = "lblMinute";
            lblMinute.Size = new Size(55, 20);
            lblMinute.TabIndex = 8;
            lblMinute.Text = "Minute";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(615, 128);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(47, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // btnValiderLigne
            // 
            btnValiderLigne.Location = new Point(139, 205);
            btnValiderLigne.Name = "btnValiderLigne";
            btnValiderLigne.Size = new Size(172, 29);
            btnValiderLigne.TabIndex = 3;
            btnValiderLigne.Text = "Valider ligne";
            btnValiderLigne.UseVisualStyleBackColor = true;
            // 
            // lblTitreLigne
            // 
            lblTitreLigne.AutoSize = true;
            lblTitreLigne.Location = new Point(153, 72);
            lblTitreLigne.Name = "lblTitreLigne";
            lblTitreLigne.Size = new Size(141, 20);
            lblTitreLigne.TabIndex = 9;
            lblTitreLigne.Text = "Choisissez une ligne";
            // 
            // lblChoixArret
            // 
            lblChoixArret.AutoSize = true;
            lblChoixArret.Location = new Point(153, 248);
            lblChoixArret.Name = "lblChoixArret";
            lblChoixArret.Size = new Size(131, 20);
            lblChoixArret.TabIndex = 10;
            lblChoixArret.Text = "Choisissez un arret";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(476, 214);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 11;
            label1.Text = "Choisissez la période :";
            // 
            // cbSemain
            // 
            cbSemain.AutoSize = true;
            cbSemain.Location = new Point(477, 248);
            cbSemain.Name = "cbSemain";
            cbSemain.Size = new Size(154, 24);
            cbSemain.TabIndex = 12;
            cbSemain.Text = "Jour de la semaine";
            cbSemain.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(476, 287);
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
            // AjoutHoraire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(btnValiderLigne);
            Controls.Add(lbArret);
            Controls.Add(lbLigne);
            Controls.Add(lblTitre);
            Name = "AjoutHoraire";
            Text = "AjoutHoraire";
            ((System.ComponentModel.ISupportInitialize)nudHeure).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private ListBox lbLigne;
        private ListBox lbArret;
        private Label lblHoraire;
        private NumericUpDown nudHeure;
        private Label lblHeure;
        private Label lblMinute;
        private NumericUpDown numericUpDown1;
        private Button btnValiderLigne;
        private Label lblTitreLigne;
        private Label lblChoixArret;
        private Label label1;
        private CheckBox cbSemain;
        private CheckBox checkBox1;
        private Button button1;
    }
}