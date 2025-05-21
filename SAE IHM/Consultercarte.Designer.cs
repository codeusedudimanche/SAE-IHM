namespace SAE_IHM
{
    partial class Consultercarte
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
            btnReseauComplet = new Button();
            btnLigne = new Button();
            btnHoraires = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            btnRetour = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 30F);
            label1.Location = new Point(0, 31);
            label1.Name = "label1";
            label1.Size = new Size(429, 67);
            label1.TabIndex = 0;
            label1.Text = "Consulter la carte";
            label1.Click += label1_Click;
            // 
            // btnReseauComplet
            // 
            btnReseauComplet.Location = new Point(112, 236);
            btnReseauComplet.Name = "btnReseauComplet";
            btnReseauComplet.Size = new Size(198, 29);
            btnReseauComplet.TabIndex = 1;
            btnReseauComplet.Text = "Le réseau complet";
            btnReseauComplet.UseVisualStyleBackColor = true;
            // 
            // btnLigne
            // 
            btnLigne.Location = new Point(112, 136);
            btnLigne.Name = "btnLigne";
            btnLigne.Size = new Size(198, 29);
            btnLigne.TabIndex = 2;
            btnLigne.Text = "Une ligne particulière";
            btnLigne.UseVisualStyleBackColor = true;
            // 
            // btnHoraires
            // 
            btnHoraires.Location = new Point(112, 185);
            btnHoraires.Name = "btnHoraires";
            btnHoraires.Size = new Size(198, 29);
            btnHoraires.TabIndex = 3;
            btnHoraires.Text = "Les horaires";
            btnHoraires.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 5;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(21, 331);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(127, 29);
            btnRetour.TabIndex = 6;
            btnRetour.Text = "<   Retour";
            btnRetour.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnRetour);
            panel1.Controls.Add(btnLigne);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnReseauComplet);
            panel1.Controls.Add(btnHoraires);
            panel1.Location = new Point(209, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 379);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Location = new Point(342, 313);
            panel2.Name = "panel2";
            panel2.Size = new Size(64, 47);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // Consultercarte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Name = "Consultercarte";
            Load += Consultercarte_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnReseauComplet;
        private Button btnLigne;
        private Button btnHoraires;
        private LinkLabel linkLabel1;
        private Label label2;
        private Button btnRetour;
        private Panel panel1;
        private Panel panel2;
    }
}