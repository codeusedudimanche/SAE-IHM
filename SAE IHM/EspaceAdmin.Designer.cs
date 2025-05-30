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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EspaceAdmin));
            label1 = new Label();
            btnAjouter = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnSupprimer = new Button();
            btnModifier = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(347, 67);
            label1.TabIndex = 0;
            label1.Text = "Espace Admin";
            label1.Click += label1_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(147, 141);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 29);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSupprimer);
            panel1.Controls.Add(btnModifier);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAjouter);
            panel1.Location = new Point(400, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 350);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(326, 292);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(147, 239);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(94, 29);
            btnSupprimer.TabIndex = 3;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(147, 190);
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
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Name = "EspaceAdmin";
            Text = "EspaceAdmin";
            Load += EspaceAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAjouter;
        private Panel panel1;
        private Button btnSupprimer;
        private Button btnModifier;
        private PictureBox pictureBox1;
    }
}