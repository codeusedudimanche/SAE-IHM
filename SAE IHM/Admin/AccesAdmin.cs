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

namespace SAE_IHM
{
    public partial class AccesAdmin : Form
    {
        public AccesAdmin()
        {
            InitializeComponent();

        }




        private void textBoxIdentifiant_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxIdentifiant.Text) && !string.IsNullOrEmpty(textBoxMdp.Text))
            {
                buttonValider.Enabled = true;
            }
            else
            {
                buttonValider.Enabled = false;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string identifiant = textBoxIdentifiant.Text;
            string motDePasse = textBoxMdp.Text;
            if (BD.VerificationConnexion(identifiant, motDePasse))
            {
                MessageBox.Show("Connexion réussie !");
                this.Hide();
                EspaceAdmin espaceA = new EspaceAdmin();
                espaceA.Show();
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect.");
            }
        }

        private void textBoxMdp_TextChanged(object sender, EventArgs e)
        {
            textBoxIdentifiant_TextChanged(sender, e);
        }

        private void pbAccueil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccesAdmin_Load(object sender, EventArgs e)
        {

        }

        private void AccesAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0]!.Show();
        }
    }
}
