namespace SAE_IHM
{
    partial class accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            btnRechercherTrajet = new Button();
            btnEspaceBillets = new Button();
            btnConsulterCarte = new Button();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(291, 74);
            label3.Name = "label3";
            label3.Size = new Size(246, 67);
            label3.TabIndex = 2;
            label3.Text = "Tulsa Bus";
            label3.Click += label3_Click;
            // 
            // btnRechercherTrajet
            // 
            btnRechercherTrajet.Location = new Point(282, 214);
            btnRechercherTrajet.Name = "btnRechercherTrajet";
            btnRechercherTrajet.Size = new Size(265, 29);
            btnRechercherTrajet.TabIndex = 3;
            btnRechercherTrajet.Text = "Rechercher mon Trajet";
            btnRechercherTrajet.UseVisualStyleBackColor = true;
            // 
            // btnEspaceBillets
            // 
            btnEspaceBillets.Location = new Point(282, 265);
            btnEspaceBillets.Name = "btnEspaceBillets";
            btnEspaceBillets.Size = new Size(265, 29);
            btnEspaceBillets.TabIndex = 4;
            btnEspaceBillets.Text = "Espace Billets";
            btnEspaceBillets.UseVisualStyleBackColor = true;
            // 
            // btnConsulterCarte
            // 
            btnConsulterCarte.Location = new Point(282, 163);
            btnConsulterCarte.Name = "btnConsulterCarte";
            btnConsulterCarte.Size = new Size(265, 29);
            btnConsulterCarte.TabIndex = 5;
            btnConsulterCarte.Text = "Consulter la Carte";
            btnConsulterCarte.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 19);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 8;
            label1.Text = "Accueil";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 19);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 9;
            label2.Text = ">";
            label2.Click += label2_Click;
            // 
            // accueil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(btnConsulterCarte);
            Controls.Add(btnEspaceBillets);
            Controls.Add(btnRechercherTrajet);
            Controls.Add(label3);
            Name = "accueil";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Button btnRechercherTrajet;
        private Button btnEspaceBillets;
        private Button btnConsulterCarte;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label2;
    }
}
