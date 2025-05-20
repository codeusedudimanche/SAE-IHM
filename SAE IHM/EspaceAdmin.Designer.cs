namespace SAE_IHM
{
    partial class EspaceAdmin
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
            btnAjouter = new Button();
            panel1 = new Panel();
            btnSupprimer = new Button();
            btnModifier = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(15, 17);
            label1.Name = "label1";
            label1.Size = new Size(357, 67);
            label1.TabIndex = 0;
            label1.Text = "Espace Admin";
            label1.Click += label1_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(145, 87);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 29);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSupprimer);
            panel1.Controls.Add(btnModifier);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAjouter);
            panel1.Location = new Point(223, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 257);
            panel1.TabIndex = 2;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(145, 182);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(94, 29);
            btnSupprimer.TabIndex = 3;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(145, 132);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(94, 29);
            btnModifier.TabIndex = 2;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += button1_Click;
            // 
            // EspaceAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "EspaceAdmin";
            Text = "EspaceAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAjouter;
        private Panel panel1;
        private Button btnSupprimer;
        private Button btnModifier;
    }
}