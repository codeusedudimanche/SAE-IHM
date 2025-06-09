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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SAE_IHM
{
    public partial class AdminSupp : Form
    {
        private EspaceAdmin parentEspace;
        private ListeLigne listeLignes;
        private ListeArret listeArrets;

        public AdminSupp(EspaceAdmin parent)
        {
            InitializeComponent();
            listeLignes = BD.GetLigne();
            listeArrets = BD.GetArret();
            parentEspace = parent;
        }

        private void AdminSupp_Load(object sender, EventArgs e)
        {

        }

        private void pbSuppArret_Click(object sender, EventArgs e)
        {
            SuppArret formSuppArret = new SuppArret(listeArrets.MesArret ,parentEspace);
            formSuppArret.Show();
            this.Hide();
        }

        private void pbSuppLigne_Click(object sender, EventArgs e)
        {
            SuppLigne formSuppLigne = new SuppLigne(listeLignes.MesLigne ,parentEspace);
            formSuppLigne.Show();
            this.Hide();
        }

        private void pbSuppHorraire_Click(object sender, EventArgs e)
        {
            SuppHorraire formSuppHorraire = new SuppHorraire(listeArrets.MesArret, parentEspace);
            formSuppHorraire.Show();
            this.Hide();
        }

        private void AdminSupp_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentEspace.Show();
        }
    }
}
