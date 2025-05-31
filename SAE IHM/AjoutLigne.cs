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

    public partial class AjoutLigne : Form
    {
        private AdminAjout parentForm;
        private ListeArret listeArret = new ListeArret();
        public List<Arret> listeArretAjouter = new List<Arret>();
        public int ordre = 1;
        public AjoutLigne(ListeArret L, AdminAjout Formparent)
        {
            InitializeComponent();
            this.parentForm = Formparent;
            lstBArret.DataSource = L.MesArret;
            lstBArret.DisplayMember = "Nom";
            lstBArret.ValueMember = "Id";
            listeArret = L;


        }

        private void AjoutLigne_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void txtBNom_TextChanged(object sender, EventArgs e)
        {
            string text = "Nom de la ligne : " + txtBNomLigne.Text;
            lblNomLigne.Text = text;
            NumeroLigne_TextChanged(sender, e);

        }


        private void btnAjoutArret_Click(object sender, EventArgs e)
        {

            if (lstBArret.SelectedItem is Arret selectedArret)
            {
                
                lbNomArretAjoute.Items.Add($"Arret {ordre}  : " + selectedArret.Nom.ToString());
                listeArretAjouter.Add(selectedArret);
                ordre++;
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un arret. ");
            }
            NumeroLigne_TextChanged(sender, e);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (listeArretAjouter.Count > 0)
            {
                lbNomArretAjoute.Items.RemoveAt(listeArretAjouter.Count - 1);
                listeArretAjouter.RemoveAt(listeArretAjouter.Count - 1);
                ordre--;
            }
            else
            {
                MessageBox.Show("Il n'y a aucun arrêt");
            }
            NumeroLigne_TextChanged(sender, e);
        }

        private void btnValiderAjoutLigne_Click(object sender, EventArgs e)
        {
            string nomLigne = txtBNomLigne.Text;
            try
            {
                int numeroLigne = Convert.ToInt32(txtbNumeroLigne.Text);

            }
            catch
            {
                MessageBox.Show("Veuillez entrer un nombre pour le numero de ligne.");
                txtbNumeroLigne.Text = "";
            }
        }

        private void lblNomLigne_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBNomLigne_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void NumeroLigne_TextChanged(object sender, EventArgs e)
        {
            if (txtBNomLigne.Text != "" && txtBNomLigne.Text != "" && txtbDestinationLigne.Text != "" && lbNomArretAjoute.Items.Count != 0)
            {
                btnValiderAjoutLigne.Enabled = true;
            }
            else
            {
                btnValiderAjoutLigne.Enabled = false;
            }
        }

        private void txtbDestinationLigne_TextChanged(object sender, EventArgs e)
        {
            NumeroLigne_TextChanged(sender, e);
        }

        private void button1_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void AjoutLigne_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void AjoutLigne_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            
        }

        private void pbRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
