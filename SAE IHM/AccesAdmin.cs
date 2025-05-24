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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Titre_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxIdentifiant_TextChanged(object sender, EventArgs e)
        {

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
    }
}
