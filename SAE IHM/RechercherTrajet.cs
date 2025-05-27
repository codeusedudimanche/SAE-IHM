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
    public partial class RechercherTrajet : Form
    { 
        public RechercherTrajet()
        {
            InitializeComponent();
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            accueil Home = new accueil();
            Home.Show();
            this.Hide();
        }
    }
}
