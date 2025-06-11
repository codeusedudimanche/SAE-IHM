using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base;

namespace SAE_IHM.Admin.Modifier
{
    public partial class ModifierMotDePasse : Form
    {
        private string mail;
        private MotDePasseOublie parent;
        public ModifierMotDePasse(string email, MotDePasseOublie espParent)
        {
            InitializeComponent();
            mail = email;
            parent = espParent;
        }

        private void btnValiderEmail_Click(object sender, EventArgs e)
        {

            if (BD.ModiferLeMotDePasse(mail, txtMDP.Text))
            {
                MessageBox.Show("Mot de passe modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification du mot de passe. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pbAcceuil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifierMotDePasse_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMDP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
