namespace SAE_IHM
{
    partial class AccesAdmin
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
            textBoxIdentifiant = new TextBox();
            textBoxMdp = new TextBox();
            buttonValider = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(245, 39);
            label1.Name = "label1";
            label1.Size = new Size(323, 67);
            label1.TabIndex = 0;
            label1.Text = "Accès admin";
            // 
            // textBoxIdentifiant
            // 
            textBoxIdentifiant.Location = new Point(325, 158);
            textBoxIdentifiant.Name = "textBoxIdentifiant";
            textBoxIdentifiant.Size = new Size(160, 27);
            textBoxIdentifiant.TabIndex = 1;
            textBoxIdentifiant.Text = "Identifiant";
            // 
            // textBoxMdp
            // 
            textBoxMdp.Location = new Point(326, 220);
            textBoxMdp.Name = "textBoxMdp";
            textBoxMdp.Size = new Size(159, 27);
            textBoxMdp.TabIndex = 2;
            textBoxMdp.Text = "Mot de passe";
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(359, 293);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(83, 29);
            buttonValider.TabIndex = 3;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(57, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Acceuil";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 9);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 5;
            label2.Text = "> Accès Admin";
            // 
            // AccesAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(buttonValider);
            Controls.Add(textBoxMdp);
            Controls.Add(textBoxIdentifiant);
            Controls.Add(label1);
            Name = "AccesAdmin";
            Text = "AccesAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxIdentifiant;
        private TextBox textBoxMdp;
        private Button buttonValider;
        private LinkLabel linkLabel1;
        private Label label2;
    }
}