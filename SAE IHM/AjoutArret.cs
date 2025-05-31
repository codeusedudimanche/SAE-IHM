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
        private AdminAjout parentForm;

        public AjoutArret(AdminAjout parent)
        {

            InitializeComponent();
            this.parentForm = parent;
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



        private void pbAcceuil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjoutArret_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void AjoutArret_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }
    }
}
