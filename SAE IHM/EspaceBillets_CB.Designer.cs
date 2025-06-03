using System.Drawing;
using System.Windows.Forms;

namespace SAE_IHM
{
    partial class EspaceBillets_CB
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelContenu;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNumeroCarte;
        private System.Windows.Forms.TextBox txtNumeroCarte;
        private System.Windows.Forms.Label lblDateExpiration;
        private System.Windows.Forms.TextBox txtDateExpiration;
        private System.Windows.Forms.Label lblCodeSecurite;
        private System.Windows.Forms.TextBox txtCodeSecurite;
        private System.Windows.Forms.Button btnValider;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitre = new Label();
            lblNumeroCarte = new Label();
            txtNumeroCarte = new TextBox();
            lblDateExpiration = new Label();
            txtDateExpiration = new TextBox();
            lblCodeSecurite = new Label();
            txtCodeSecurite = new TextBox();
            btnValider = new Button();
            panelContenu = new Panel();
            panelContenu.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(56, 21);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(273, 46);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Renseignements";
            // 
            // lblNumeroCarte
            // 
            lblNumeroCarte.AutoSize = true;
            lblNumeroCarte.Location = new Point(23, 87);
            lblNumeroCarte.Name = "lblNumeroCarte";
            lblNumeroCarte.Size = new Size(182, 20);
            lblNumeroCarte.TabIndex = 1;
            lblNumeroCarte.Text = "Numéro de carte bancaire";
            // 
            // txtNumeroCarte
            // 
            txtNumeroCarte.Location = new Point(23, 113);
            txtNumeroCarte.Margin = new Padding(3, 4, 3, 4);
            txtNumeroCarte.MaxLength = 19;
            txtNumeroCarte.Name = "txtNumeroCarte";
            txtNumeroCarte.Size = new Size(322, 27);
            txtNumeroCarte.TabIndex = 2;
            // 
            // lblDateExpiration
            // 
            lblDateExpiration.AutoSize = true;
            lblDateExpiration.Location = new Point(23, 167);
            lblDateExpiration.Name = "lblDateExpiration";
            lblDateExpiration.Size = new Size(157, 20);
            lblDateExpiration.TabIndex = 3;
            lblDateExpiration.Text = "Date limite de validité";
            // 
            // txtDateExpiration
            // 
            txtDateExpiration.Location = new Point(23, 191);
            txtDateExpiration.Margin = new Padding(3, 4, 3, 4);
            txtDateExpiration.Name = "txtDateExpiration";
            txtDateExpiration.PlaceholderText = "MM/AA";
            txtDateExpiration.Size = new Size(114, 27);
            txtDateExpiration.TabIndex = 4;
            // 
            // lblCodeSecurite
            // 
            lblCodeSecurite.AutoSize = true;
            lblCodeSecurite.Location = new Point(23, 247);
            lblCodeSecurite.Name = "lblCodeSecurite";
            lblCodeSecurite.Size = new Size(218, 20);
            lblCodeSecurite.TabIndex = 5;
            lblCodeSecurite.Text = "Code de sécurité (2 à 3 chiffres)";
            // 
            // txtCodeSecurite
            // 
            txtCodeSecurite.Location = new Point(23, 273);
            txtCodeSecurite.Margin = new Padding(3, 4, 3, 4);
            txtCodeSecurite.MaxLength = 3;
            txtCodeSecurite.Name = "txtCodeSecurite";
            txtCodeSecurite.Size = new Size(57, 27);
            txtCodeSecurite.TabIndex = 6;
            // 
            // btnValider
            // 
            btnValider.Enabled = false;
            btnValider.Location = new Point(136, 332);
            btnValider.Margin = new Padding(3, 4, 3, 4);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(114, 40);
            btnValider.TabIndex = 7;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // panelContenu
            // 
            panelContenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenu.BackColor = SystemColors.ControlLightLight;
            panelContenu.Controls.Add(lblTitre);
            panelContenu.Controls.Add(lblNumeroCarte);
            panelContenu.Controls.Add(txtNumeroCarte);
            panelContenu.Controls.Add(lblDateExpiration);
            panelContenu.Controls.Add(txtDateExpiration);
            panelContenu.Controls.Add(lblCodeSecurite);
            panelContenu.Controls.Add(txtCodeSecurite);
            panelContenu.Controls.Add(btnValider);
            panelContenu.Location = new Point(420, 169);
            panelContenu.Margin = new Padding(3, 4, 3, 4);
            panelContenu.Name = "panelContenu";
            panelContenu.Size = new Size(377, 397);
            panelContenu.TabIndex = 8;
            // 
            // EspaceBillets_CB
            // 
            AcceptButton = btnValider;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(panelContenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EspaceBillets_CB";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paiement CB";
            FormClosed += EspaceBillets_CB_FormClosed;
            Load += EspaceBillets_CB_Load;
            panelContenu.ResumeLayout(false);
            panelContenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
