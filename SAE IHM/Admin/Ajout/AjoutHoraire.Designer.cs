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
            cbSemaine = new CheckBox();
            cbJourFerie = new CheckBox();
            btnValider = new Button();
            pbEspaceAdmin = new PictureBox();
            pnlBackround = new Panel();
            lblAlerteHeure = new Label();
            gbPeriode = new GroupBox();
            lblHoraire = new Label();
            lblArret = new Label();
            nudMinute = new NumericUpDown();
            nudHeure = new NumericUpDown();
            lblMinute = new Label();
            lblHeure = new Label();
            cbArret = new ComboBox();
            lblLigne = new Label();
            cbLigne = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).BeginInit();
            pnlBackround.SuspendLayout();
            gbPeriode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHeure).BeginInit();
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
            // cbSemaine
            // 
            cbSemaine.AutoSize = true;
            cbSemaine.Location = new Point(15, 37);
            cbSemaine.Name = "cbSemaine";
            cbSemaine.Size = new Size(154, 24);
            cbSemaine.TabIndex = 12;
            cbSemaine.Text = "Jour de la semaine";
            cbSemaine.UseVisualStyleBackColor = true;
            cbSemaine.CheckedChanged += cbPeriode_Changed;
            // 
            // cbJourFerie
            // 
            cbJourFerie.AutoSize = true;
            cbJourFerie.Location = new Point(189, 37);
            cbJourFerie.Name = "cbJourFerie";
            cbJourFerie.Size = new Size(178, 24);
            cbJourFerie.TabIndex = 13;
            cbJourFerie.Text = "Jour férié et week-end";
            cbJourFerie.UseVisualStyleBackColor = true;
            cbJourFerie.CheckedChanged += cbPeriode_Changed;
            // 
            // btnValider
            // 
            btnValider.Enabled = false;
            btnValider.Location = new Point(122, 449);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(449, 58);
            btnValider.TabIndex = 14;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // pbEspaceAdmin
            // 
            pbEspaceAdmin.Image = (Image)resources.GetObject("pbEspaceAdmin.Image");
            pbEspaceAdmin.InitialImage = (Image)resources.GetObject("pbEspaceAdmin.InitialImage");
            pbEspaceAdmin.Location = new Point(38, 465);
            pbEspaceAdmin.Name = "pbEspaceAdmin";
            pbEspaceAdmin.Size = new Size(43, 42);
            pbEspaceAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pbEspaceAdmin.TabIndex = 15;
            pbEspaceAdmin.TabStop = false;
            pbEspaceAdmin.Click += pbEspaceAdmin_Click;
            // 
            // pnlBackround
            // 
            pnlBackround.BackColor = SystemColors.ControlLightLight;
            pnlBackround.Controls.Add(lblAlerteHeure);
            pnlBackround.Controls.Add(pbEspaceAdmin);
            pnlBackround.Controls.Add(gbPeriode);
            pnlBackround.Controls.Add(lblHoraire);
            pnlBackround.Controls.Add(lblArret);
            pnlBackround.Controls.Add(nudMinute);
            pnlBackround.Controls.Add(nudHeure);
            pnlBackround.Controls.Add(lblMinute);
            pnlBackround.Controls.Add(lblHeure);
            pnlBackround.Controls.Add(cbArret);
            pnlBackround.Controls.Add(lblLigne);
            pnlBackround.Controls.Add(cbLigne);
            pnlBackround.Controls.Add(btnValider);
            pnlBackround.Controls.Add(lblTitre);
            pnlBackround.Location = new Point(270, 101);
            pnlBackround.Name = "pnlBackround";
            pnlBackround.Size = new Size(671, 547);
            pnlBackround.TabIndex = 16;
            pnlBackround.Paint += panel1_Paint;
            // 
            // lblAlerteHeure
            // 
            lblAlerteHeure.AutoSize = true;
            lblAlerteHeure.ForeColor = Color.DarkRed;
            lblAlerteHeure.Location = new Point(128, 327);
            lblAlerteHeure.Name = "lblAlerteHeure";
            lblAlerteHeure.Size = new Size(0, 20);
            lblAlerteHeure.TabIndex = 22;
            // 
            // gbPeriode
            // 
            gbPeriode.Controls.Add(cbSemaine);
            gbPeriode.Controls.Add(cbJourFerie);
            gbPeriode.Location = new Point(122, 341);
            gbPeriode.Name = "gbPeriode";
            gbPeriode.Size = new Size(449, 89);
            gbPeriode.TabIndex = 21;
            gbPeriode.TabStop = false;
            gbPeriode.Text = "Choisissez la période :";
            // 
            // lblHoraire
            // 
            lblHoraire.AutoSize = true;
            lblHoraire.Location = new Point(122, 255);
            lblHoraire.Name = "lblHoraire";
            lblHoraire.Size = new Size(141, 20);
            lblHoraire.TabIndex = 4;
            lblHoraire.Text = "Choisissez l'horaire :";
            // 
            // lblArret
            // 
            lblArret.AutoSize = true;
            lblArret.Location = new Point(122, 180);
            lblArret.Name = "lblArret";
            lblArret.Size = new Size(129, 20);
            lblArret.TabIndex = 20;
            lblArret.Text = "Choisisser un arrêt";
            lblArret.Click += label2_Click;
            // 
            // nudMinute
            // 
            nudMinute.Location = new Point(234, 288);
            nudMinute.Name = "nudMinute";
            nudMinute.Size = new Size(47, 27);
            nudMinute.TabIndex = 7;
            nudMinute.ValueChanged += nud_ValueChanged;
            // 
            // nudHeure
            // 
            nudHeure.Location = new Point(122, 288);
            nudHeure.Name = "nudHeure";
            nudHeure.Size = new Size(47, 27);
            nudHeure.TabIndex = 5;
            nudHeure.ValueChanged += nud_ValueChanged;
            // 
            // lblMinute
            // 
            lblMinute.AutoSize = true;
            lblMinute.Location = new Point(287, 295);
            lblMinute.Name = "lblMinute";
            lblMinute.Size = new Size(61, 20);
            lblMinute.TabIndex = 8;
            lblMinute.Text = "Minutes";
            // 
            // lblHeure
            // 
            lblHeure.AutoSize = true;
            lblHeure.Location = new Point(173, 295);
            lblHeure.Name = "lblHeure";
            lblHeure.Size = new Size(55, 20);
            lblHeure.TabIndex = 6;
            lblHeure.Text = "Heures";
            // 
            // cbArret
            // 
            cbArret.FormattingEnabled = true;
            cbArret.Location = new Point(122, 203);
            cbArret.Name = "cbArret";
            cbArret.Size = new Size(449, 28);
            cbArret.TabIndex = 19;
            cbArret.SelectedIndexChanged += cbArret_SelectedIndexChanged_1;
            // 
            // lblLigne
            // 
            lblLigne.AutoSize = true;
            lblLigne.Location = new Point(122, 100);
            lblLigne.Name = "lblLigne";
            lblLigne.Size = new Size(139, 20);
            lblLigne.TabIndex = 18;
            lblLigne.Text = "Choisisser une ligne";
            // 
            // cbLigne
            // 
            cbLigne.FormattingEnabled = true;
            cbLigne.Location = new Point(122, 123);
            cbLigne.Name = "cbLigne";
            cbLigne.Size = new Size(449, 28);
            cbLigne.TabIndex = 17;
            cbLigne.SelectedIndexChanged += cbLigne_SelectedIndexChanged;
            // 
            // AjoutHoraire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(pnlBackround);
            Name = "AjoutHoraire";
            Text = "AjoutHoraire";
            FormClosing += AjoutHoraire_FormClosing;
            FormClosed += AjoutHoraire_FormClosed;
            Load += AjoutHoraire_Load;
            ((System.ComponentModel.ISupportInitialize)pbEspaceAdmin).EndInit();
            pnlBackround.ResumeLayout(false);
            pnlBackround.PerformLayout();
            gbPeriode.ResumeLayout(false);
            gbPeriode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHeure).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitre;
        private CheckBox cbSemaine;
        private CheckBox cbJourFerie;
        private Button btnValider;
        private PictureBox pbEspaceAdmin;
        private Panel pnlBackround;
        private ComboBox cbLigne;
        private Label lblLigne;
        private Label lblArret;
        private ComboBox cbArret;
        private Label lblHoraire;
        private NumericUpDown nudMinute;
        private NumericUpDown nudHeure;
        private Label lblMinute;
        private Label lblHeure;
        private GroupBox gbPeriode;
        private Label lblAlerteHeure;
    }
}