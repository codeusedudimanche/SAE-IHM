namespace SAE_IHM
{
    partial class ConsulterLigne
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
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panelCarte = new Panel();
            pictureBox1 = new PictureBox();
            lblNomLigne = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panelCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(54, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 248);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(45, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(345, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 113);
            label2.Name = "label2";
            label2.Size = new Size(347, 20);
            label2.TabIndex = 2;
            label2.Text = "Sélectionnez la ligne que vous souhaitez consulter :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.Location = new Point(58, 31);
            label1.Name = "label1";
            label1.Size = new Size(320, 46);
            label1.TabIndex = 0;
            label1.Text = "Consulter une ligne";
            label1.Click += label1_Click;
            // 
            // panelCarte
            // 
            panelCarte.BackColor = SystemColors.ControlLightLight;
            panelCarte.Controls.Add(label3);
            panelCarte.Controls.Add(pictureBox1);
            panelCarte.Controls.Add(lblNomLigne);
            panelCarte.Location = new Point(544, 103);
            panelCarte.Name = "panelCarte";
            panelCarte.Size = new Size(554, 533);
            panelCarte.TabIndex = 1;
            panelCarte.Visible = false;
            panelCarte.Paint += panelCarte_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Plan_Tulsa;
            pictureBox1.Location = new Point(47, 194);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(467, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblNomLigne
            // 
            lblNomLigne.AutoSize = true;
            lblNomLigne.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomLigne.Location = new Point(35, 31);
            lblNomLigne.Name = "lblNomLigne";
            lblNomLigne.Size = new Size(264, 46);
            lblNomLigne.TabIndex = 0;
            lblNomLigne.Text = "Nom de la ligne\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 133);
            label3.Name = "label3";
            label3.Size = new Size(207, 20);
            label3.TabIndex = 2;
            label3.Text = "Cliquez sur l'image ci-dessous";
            // 
            // ConsulterLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(panelCarte);
            Controls.Add(panel1);
            Name = "ConsulterLigne";
            Text = "ConsulterLigne";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelCarte.ResumeLayout(false);
            panelCarte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Panel panelCarte;
        private Label lblNomLigne;
        private PictureBox pictureBox1;
        private Label label3;
    }
}