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
    public partial class AjoutArret : Form
    {
        public AjoutArret()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int idArret = Convert.ToInt32(txtbNumeroArret.Text);
            string txtArret = txtbNomArret.Text;
            double Latitude = Convert.ToDouble(txtbLatitude.Text);
            double Longitude = Convert.ToDouble(txtbLongitude.Text);

            BD.AjoutArret(idArret, txtArret, Latitude, Longitude);

        }

        private void AjoutArret_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EspaceAdmin espaceAdmin = new EspaceAdmin();
            espaceAdmin.Show();
            this.Close();
        }
    }
}
