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
            btnRetour = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 23);
            label1.Name = "label1";
            label1.Size = new Size(333, 67);
            label1.TabIndex = 0;
            label1.Text = "Espace billets";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 114);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
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
            groupBox1.Location = new Point(3, 137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 44);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // radioButtonSenior
            // 
            radioButtonSenior.AutoSize = true;
            radioButtonSenior.Location = new Point(352, 14);
            radioButtonSenior.Name = "radioButtonSenior";
            radioButtonSenior.Size = new Size(72, 24);
            radioButtonSenior.TabIndex = 6;
            radioButtonSenior.TabStop = true;
            radioButtonSenior.Text = "Sénior";
            radioButtonSenior.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnfant
            // 
            radioButtonEnfant.AutoSize = true;
            radioButtonEnfant.Location = new Point(6, 14);
            radioButtonEnfant.Name = "radioButtonEnfant";
            radioButtonEnfant.Size = new Size(72, 24);
            radioButtonEnfant.TabIndex = 3;
            radioButtonEnfant.TabStop = true;
            radioButtonEnfant.Text = "Enfant";
            radioButtonEnfant.UseVisualStyleBackColor = true;
            radioButtonEnfant.CheckedChanged += radioButtonEnfant_CheckedChanged;
            // 
            // radioButtonVeteran
            // 
            radioButtonVeteran.AutoSize = true;
            radioButtonVeteran.Location = new Point(266, 14);
            radioButtonVeteran.Name = "radioButtonVeteran";
            radioButtonVeteran.Size = new Size(80, 24);
            radioButtonVeteran.TabIndex = 5;
            radioButtonVeteran.TabStop = true;
            radioButtonVeteran.Text = "Vétéran";
            radioButtonVeteran.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdulte
            // 
            radioButtonAdulte.AutoSize = true;
            radioButtonAdulte.Location = new Point(84, 14);
            radioButtonAdulte.Name = "radioButtonAdulte";
            radioButtonAdulte.Size = new Size(74, 24);
            radioButtonAdulte.TabIndex = 3;
            radioButtonAdulte.TabStop = true;
            radioButtonAdulte.Text = "Adulte";
            radioButtonAdulte.UseVisualStyleBackColor = true;
            // 
            // radioButtonHandicape
            // 
            radioButtonHandicape.AutoSize = true;
            radioButtonHandicape.Location = new Point(158, 14);
            radioButtonHandicape.Name = "radioButtonHandicape";
            radioButtonHandicape.Size = new Size(102, 24);
            radioButtonHandicape.TabIndex = 4;
            radioButtonHandicape.TabStop = true;
            radioButtonHandicape.Text = "Handicapé";
            radioButtonHandicape.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(41, 213);
            label3.Name = "label3";
            label3.Size = new Size(315, 20);
            label3.TabIndex = 3;
            label3.Text = "Veuillez renseigner votre moyen de paiement :";
            // 
            // checkBoxPaypal
            // 
            checkBoxPaypal.AutoSize = true;
            checkBoxPaypal.ForeColor = Color.Silver;
            checkBoxPaypal.Location = new Point(466, 357);
            checkBoxPaypal.Name = "checkBoxPaypal";
            checkBoxPaypal.Size = new Size(74, 24);
            checkBoxPaypal.TabIndex = 4;
            checkBoxPaypal.Text = "Paypal";
            checkBoxPaypal.UseVisualStyleBackColor = true;
            // 
            // checkBoxCB
            // 
            checkBoxCB.AutoSize = true;
            checkBoxCB.ForeColor = Color.Silver;
            checkBoxCB.Location = new Point(87, 249);
            checkBoxCB.Name = "checkBoxCB";
            checkBoxCB.Size = new Size(127, 24);
            checkBoxCB.TabIndex = 5;
            checkBoxCB.Text = "Carte bancaire";
            checkBoxCB.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnRetour);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(checkBoxCB);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(207, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 379);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
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
            // EspaceBillets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(linkLabel1);
            Controls.Add(checkBoxPaypal);
            Name = "EspaceBillets";
            Text = "EspaceBillets";
            Load += EspaceBillets_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}