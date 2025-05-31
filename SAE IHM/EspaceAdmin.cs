using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_IHM
{
    public partial class EspaceAdmin : Form
    {
        public EspaceAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminModifier Formmodif = new AdminModifier();
            Formmodif.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EspaceAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AdminAjout Formajout = new AdminAjout(this);
            Formajout.Show();
            this.Hide();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            AdminSupp Formsupp = new AdminSupp();
            Formsupp.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EspaceAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0]!.Show();
        }

        private void pbAcceuil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
