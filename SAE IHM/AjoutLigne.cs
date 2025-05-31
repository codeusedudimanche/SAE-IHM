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
        private ListeArret listeArret = new ListeArret();
        public List<Arret> listeArretAjouter = new List<Arret>();
        public int ordre = 1;
        public AjoutLigne(ListeArret L)
        {
            InitializeComponent();
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
                if (lblArret.Text == "Arret : Aucun")
                {
                    lblArret.Text = $"Arret {ordre}  : " + selectedArret.Nom.ToString();
                }
                else
                {
                    lblArret.Text = lblArret.Text + $"\nArret {ordre}  : " + selectedArret.Nom.ToString();

                }
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
            if (listeArretAjouter.Count > 1)
            {
                lblArret.Text = "";
                for (int i = 0; i < listeArretAjouter.Count - 1; i++)
                {
                    if (i == 0)
                    {
                        lblArret.Text = $"Arret {i + 1}  : " + listeArretAjouter[i].Nom.ToString();
                    }
                    else
                    {
                        lblArret.Text = lblArret.Text + $"\nArret {i + 1}  : " + listeArretAjouter[i].Nom.ToString();
                    }

                }
                listeArretAjouter.RemoveAt(listeArretAjouter.Count - 1);
                ordre--;
            }
            else if (listeArretAjouter.Count == 1)
            {
                lblArret.Text = "Arret : Aucun";
                listeArretAjouter.RemoveAt(listeArretAjouter.Count - 1);
                ordre--;
            }
            else
            {
                MessageBox.Show("Il n'y a aucun arrêt");
            }
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
            if (txtBNomLigne.Text != "" && txtBNomLigne.Text != "" && txtbDestinationLigne.Text != "" && lblArret.Text != "Arret : Aucun")
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
            EspaceAdmin espaceAdmin = new EspaceAdmin();
            espaceAdmin.Show();
        }

        private void AjoutLigne_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
