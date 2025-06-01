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
        private EspaceAdmin parentForm;
        public List<Arret> listeArretAjouter = new List<Arret>();
        public int ordre = 1;
        public AjoutLigne(ListeArret L, EspaceAdmin Formparent)
        {
            InitializeComponent();
            this.parentForm = Formparent;
            lstBArret.DataSource = L.MesArret;
            lstBArret.DisplayMember = "Nom";
            lstBArret.ValueMember = "Id";


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

                // Suppression de l'arrêt de la source de données
                var arrets = (List<Arret>)lstBArret.DataSource;
                arrets.Remove(selectedArret);

                // Rafraîchissement de la DataSource
                lstBArret.DataSource = null;
                lstBArret.DataSource = arrets;
                lstBArret.DisplayMember = "Nom";
                lstBArret.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un arret.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Il n'y a aucun arrêt", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            NumeroLigne_TextChanged(sender, e);
        }

        private void btnValiderAjoutLigne_Click(object sender, EventArgs e)
        {
            string nomLigne = txtBNomLigne.Text;
            string destinationLigne = listeArretAjouter[ordre - 2].Nom;


            try
            {
                int numeroLigne = Convert.ToInt32(txtbNumeroLigne.Text);
                try
                {
                    BD.AjoutLigne(numeroLigne, nomLigne, destinationLigne, listeArretAjouter);
                    MessageBox.Show("La ligne a été ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Erreur lors de l'ajout de la ligne. Veuillez vérifier les informations saisies.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Veuillez entrer un nombre pour le numero de ligne", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtbNumeroLigne.Text = "";
                NumeroLigne_TextChanged(sender, e);
            }





        }

        private void lblNomLigne_Click(object sender, EventArgs e)
        {

        }


        private void txtBNomLigne_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void NumeroLigne_TextChanged(object sender, EventArgs e)
        {
            if (txtBNomLigne.Text != "" && txtbNumeroLigne.Text != "" && lbNomArretAjoute.Items.Count != 0)
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

        private void lbNomArretAjoute_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
