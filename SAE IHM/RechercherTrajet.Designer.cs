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
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            textBoxArretDepart = new TextBox();
            textBoxArretArrivee = new TextBox();
            checkBoxHoraire = new CheckBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(296, 194);
            label1.Name = "label1";
            label1.Size = new Size(504, 67);
            label1.TabIndex = 0;
            label1.Text = "Rechercher un trajet";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(57, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Accueil";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 9);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 2;
            label2.Text = "> Rechercher un trajet";
            // 
            // textBoxArretDepart
            // 
            textBoxArretDepart.Location = new Point(327, 344);
            textBoxArretDepart.Name = "textBoxArretDepart";
            textBoxArretDepart.Size = new Size(165, 27);
            textBoxArretDepart.TabIndex = 3;
            textBoxArretDepart.Text = "Entrer l'arrêt de départ";
            // 
            // textBoxArretArrivee
            // 
            textBoxArretArrivee.Location = new Point(573, 344);
            textBoxArretArrivee.Name = "textBoxArretArrivee";
            textBoxArretArrivee.Size = new Size(165, 27);
            textBoxArretArrivee.TabIndex = 4;
            textBoxArretArrivee.Text = "Entrer l'arrêt d'arrivée";
            // 
            // checkBoxHoraire
            // 
            checkBoxHoraire.AutoSize = true;
            checkBoxHoraire.Location = new Point(394, 433);
            checkBoxHoraire.Name = "checkBoxHoraire";
            checkBoxHoraire.Size = new Size(277, 24);
            checkBoxHoraire.TabIndex = 5;
            checkBoxHoraire.Text = "Voulez-vous sélectionner un horaire ?";
            checkBoxHoraire.UseVisualStyleBackColor = true;
            checkBoxHoraire.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Location = new Point(140, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 159);
            panel1.TabIndex = 6;
            // 
            // RechercherTrajet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(checkBoxHoraire);
            Controls.Add(textBoxArretArrivee);
            Controls.Add(textBoxArretDepart);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Name = "RechercherTrajet";
            Text = "RechercherTrajet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private Label label2;
        private TextBox textBoxArretDepart;
        private TextBox textBoxArretArrivee;
        private CheckBox checkBoxHoraire;
        private Panel panel1;
    }
}