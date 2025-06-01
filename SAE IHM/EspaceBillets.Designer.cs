namespace SAE_IHM
{
    partial class EspaceBillets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EspaceBillets));
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            radioButtonSenior = new RadioButton();
            radioButtonEnfant = new RadioButton();
            radioButtonVeteran = new RadioButton();
            radioButtonAdulte = new RadioButton();
            radioButtonHandicape = new RadioButton();
            label3 = new Label();
            checkBoxPaypal = new CheckBox();
            checkBoxCB = new CheckBox();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnValide = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 17);
            label1.Name = "label1";
            label1.Size = new Size(263, 54);
            label1.TabIndex = 0;
            label1.Text = "Espace billets";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 86);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Saisissez votre tarif :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonSenior);
            groupBox1.Controls.Add(radioButtonEnfant);
            groupBox1.Controls.Add(radioButtonVeteran);
            groupBox1.Controls.Add(radioButtonAdulte);
            groupBox1.Controls.Add(radioButtonHandicape);
            groupBox1.Location = new Point(11, 103);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(381, 33);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // radioButtonSenior
            // 
            radioButtonSenior.AutoSize = true;
            radioButtonSenior.Location = new Point(308, 10);
            radioButtonSenior.Margin = new Padding(3, 2, 3, 2);
            radioButtonSenior.Name = "radioButtonSenior";
            radioButtonSenior.Size = new Size(58, 19);
            radioButtonSenior.TabIndex = 6;
            radioButtonSenior.TabStop = true;
            radioButtonSenior.Text = "Sénior";
            radioButtonSenior.UseVisualStyleBackColor = true;
            radioButtonSenior.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonEnfant
            // 
            radioButtonEnfant.AutoSize = true;
            radioButtonEnfant.Location = new Point(5, 10);
            radioButtonEnfant.Margin = new Padding(3, 2, 3, 2);
            radioButtonEnfant.Name = "radioButtonEnfant";
            radioButtonEnfant.Size = new Size(59, 19);
            radioButtonEnfant.TabIndex = 3;
            radioButtonEnfant.TabStop = true;
            radioButtonEnfant.Text = "Enfant";
            radioButtonEnfant.UseVisualStyleBackColor = true;
            radioButtonEnfant.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonVeteran
            // 
            radioButtonVeteran.AutoSize = true;
            radioButtonVeteran.Location = new Point(233, 10);
            radioButtonVeteran.Margin = new Padding(3, 2, 3, 2);
            radioButtonVeteran.Name = "radioButtonVeteran";
            radioButtonVeteran.Size = new Size(64, 19);
            radioButtonVeteran.TabIndex = 5;
            radioButtonVeteran.TabStop = true;
            radioButtonVeteran.Text = "Vétéran";
            radioButtonVeteran.UseVisualStyleBackColor = true;
            radioButtonVeteran.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonAdulte
            // 
            radioButtonAdulte.AutoSize = true;
            radioButtonAdulte.Location = new Point(74, 10);
            radioButtonAdulte.Margin = new Padding(3, 2, 3, 2);
            radioButtonAdulte.Name = "radioButtonAdulte";
            radioButtonAdulte.Size = new Size(60, 19);
            radioButtonAdulte.TabIndex = 3;
            radioButtonAdulte.TabStop = true;
            radioButtonAdulte.Text = "Adulte";
            radioButtonAdulte.UseVisualStyleBackColor = true;
            radioButtonAdulte.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonHandicape
            // 
            radioButtonHandicape.AutoSize = true;
            radioButtonHandicape.Location = new Point(138, 10);
            radioButtonHandicape.Margin = new Padding(3, 2, 3, 2);
            radioButtonHandicape.Name = "radioButtonHandicape";
            radioButtonHandicape.Size = new Size(82, 19);
            radioButtonHandicape.TabIndex = 4;
            radioButtonHandicape.TabStop = true;
            radioButtonHandicape.Text = "Handicapé";
            radioButtonHandicape.UseVisualStyleBackColor = true;
            radioButtonHandicape.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(36, 160);
            label3.Name = "label3";
            label3.Size = new Size(249, 15);
            label3.TabIndex = 3;
            label3.Text = "Veuillez renseigner votre moyen de paiement :";
            // 
            // checkBoxPaypal
            // 
            checkBoxPaypal.AutoSize = true;
            checkBoxPaypal.ForeColor = Color.Silver;
            checkBoxPaypal.Location = new Point(408, 268);
            checkBoxPaypal.Margin = new Padding(3, 2, 3, 2);
            checkBoxPaypal.Name = "checkBoxPaypal";
            checkBoxPaypal.Size = new Size(61, 19);
            checkBoxPaypal.TabIndex = 4;
            checkBoxPaypal.Text = "Paypal";
            checkBoxPaypal.UseVisualStyleBackColor = true;
            // 
            // checkBoxCB
            // 
            checkBoxCB.AutoSize = true;
            checkBoxCB.ForeColor = Color.Silver;
            checkBoxCB.Location = new Point(76, 187);
            checkBoxCB.Margin = new Padding(3, 2, 3, 2);
            checkBoxCB.Name = "checkBoxCB";
            checkBoxCB.Size = new Size(102, 19);
            checkBoxCB.TabIndex = 5;
            checkBoxCB.Text = "Carte bancaire";
            checkBoxCB.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(10, 7);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnValide);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(checkBoxCB);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(328, 131);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 284);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(345, 238);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnValide
            // 
            btnValide.Location = new Point(156, 238);
            btnValide.Name = "btnValide";
            btnValide.Size = new Size(75, 23);
            btnValide.TabIndex = 8;
            btnValide.Text = "Valider";
            btnValide.UseVisualStyleBackColor = true;
            // 
            // EspaceBillets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1034, 565);
            Controls.Add(panel1);
            Controls.Add(linkLabel1);
            Controls.Add(checkBoxPaypal);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EspaceBillets";
            Text = "EspaceBillets";
            Load += EspaceBillets_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioButtonSenior;
        private RadioButton radioButtonEnfant;
        private RadioButton radioButtonVeteran;
        private RadioButton radioButtonAdulte;
        private RadioButton radioButtonHandicape;
        private Label label3;
        private CheckBox checkBoxPaypal;
        private CheckBox checkBoxCB;
        private LinkLabel linkLabel1;
        private Label label4;
        private Panel panel1;
        private Button btnRetour;
        private PictureBox pictureBox1;
        private Button btnValide;
    }
}