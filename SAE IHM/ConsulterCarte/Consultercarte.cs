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
using MySql.Data.MySqlClient;

namespace SAE_IHM
{
    public partial class Consultercarte : Form
    {
        public Consultercarte()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0]!.Show();
        }


        private void Consultercarte_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0]!.Show();
        }

        private void btnLigne_Click(object sender, EventArgs e)
        {
            ConsulterLigne FormConsulLigne = new ConsulterLigne();
            FormConsulLigne.Show();
            this.Hide();
        }

        private void btnReseauComplet_Click(object sender, EventArgs e)
        {
            ConsulterReseau FormConsulRes = new ConsulterReseau();
            FormConsulRes.Show();
            this.Hide();
        }

        private void btnHoraires_Click(object sender, EventArgs e)
        {
            ConsulterHoraire FormConsulHor = new ConsulterHoraire();
            FormConsulHor.Show();
            this.Hide();
        }
    }
}
