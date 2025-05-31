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
        private EspaceAdmin parentEspace;
        private ListeArret L;
        public AdminAjout(EspaceAdmin parent)
        {
            InitializeComponent();
            L = new ListeArret();
            L = BD.GetArret();
            parentEspace = parent;
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
            AjoutArret formAjoutArret = new AjoutArret(this);
            formAjoutArret.Show();
            this.Hide();
        }

        private void pbAjoutLigne_Click(object sender, EventArgs e)
        {
            AjoutLigne formAjoutLigne = new AjoutLigne(L, this);
            formAjoutLigne.Show();
            this.Hide();
        }

        private void AdminAjout_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentEspace.Show();
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
