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
            buttonAjouter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(240, 40);
            label1.Name = "label1";
            label1.Size = new Size(357, 67);
            label1.TabIndex = 0;
            label1.Text = "Espace Admin";
            // 
            // buttonAjouter
            // 
            buttonAjouter.Location = new Point(357, 139);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(94, 29);
            buttonAjouter.TabIndex = 1;
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.UseVisualStyleBackColor = true;
            // 
            // EspaceAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAjouter);
            Controls.Add(label1);
            Name = "EspaceAdmin";
            Text = "EspaceAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAjouter;
    }
}