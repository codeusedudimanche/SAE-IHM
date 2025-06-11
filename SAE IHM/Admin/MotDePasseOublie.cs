using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base;
using SAE_IHM.Admin.Modifier;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SAE_IHM.Admin
{
    public partial class MotDePasseOublie : Form
    {
        private AccesAdmin Parent;
        public MotDePasseOublie(AccesAdmin esParent)
        {
            InitializeComponent();
            Parent = esParent;
        }

        private void btnValiderEmail_Click(object sender, EventArgs e)
        {

            // Regex standard pour valider un e-mail
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txtMail.Text, pattern))
            {
                MessageBox.Show("Adresse e-mail invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BD.MotDePasseOubliee(txtMail.Text);
                btnValiderCode.Visible = true;
                lblCode.Visible = true;
                txtCode.Visible = true;
            }

        }

        private void btnValiderCode_Click(object sender, EventArgs e)
        {
            if (BD.VerifCode(txtCode.Text, txtMail.Text))
            {


                MessageBox.Show("Code vérifié avec succès. Vous pouvez maintenant réinitialiser votre mot de passe.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                this.Hide();
                ModifierMotDePasse modifMdp = new ModifierMotDePasse(txtMail.Text, this);
                modifMdp.Show();

            }
            else
            {
                MessageBox.Show("Code incorrect. Veuillez réessayer.","Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbAcceuil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MotDePasseOublie_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Show();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
