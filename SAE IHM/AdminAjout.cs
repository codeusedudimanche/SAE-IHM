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
    public partial class AdminAjout : Form
    {
        private ListeArret L;
        public AdminAjout()
        {
            InitializeComponent();
            L = new ListeArret();
            L = BD.GetArret();

        }

        private void AdminAjout_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void pbAjoutArret_Click(object sender, EventArgs e)
        {
            AjoutArret formAjoutArret = new AjoutArret();
            formAjoutArret.Show();
            this.Close();
        }

        private void pbAjoutLigne_Click(object sender, EventArgs e)
        {
            AjoutLigne formAjoutLigne = new AjoutLigne(L);
            formAjoutLigne.Show();
            this.Close();
        }
    }
}
