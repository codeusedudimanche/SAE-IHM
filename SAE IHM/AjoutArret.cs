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
        private EspaceAdmin parentForm;

        public AjoutArret(EspaceAdmin parent)
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
            txtbLatitude.Text = txtbLatitude.Text.Replace('.', ',');
            int idArret;
            double Longitude;
            double Latitude;
            
            try
            {
                idArret = Convert.ToInt32(txtbNumeroArret.Text);
            }
            catch
            {
                
                MessageBox.Show("Le numéro d'arrêt doit être un entier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            string txtArret = txtbNomArret.Text;
            try
            {
                Latitude = Convert.ToDouble(txtbLatitude.Text);
            }
            catch
            {
                MessageBox.Show("La latitude doit être un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Longitude = Convert.ToDouble(txtbLongitude.Text);
            }
            catch
            {
                MessageBox.Show("La longitude doit être un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                BD.AjoutArret(idArret, txtArret, Latitude, Longitude);
                MessageBox.Show("L'arrêt a été ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Une erreur s'est produite lors de l'ajout de l'arrêt. Veuillez vérifier les informations saisies.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void txtbLongitude_TextChanged(object sender, EventArgs e)
        {
            textBox_TextChanged(sender, e);
        }


        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (txtbNumeroArret.Text == "" || txtbNomArret.Text == "" || txtbLatitude.Text == "" || txtbLongitude.Text == "")
            {
                btnValide.Enabled = false;
            }
            else
            {
                btnValide.Enabled = true;
            }
        }

        private void txtbNomArret_TextChanged(object sender, EventArgs e)
        {
            textBox_TextChanged(sender, e);
        }

        private void txtbLatitude_TextChanged(object sender, EventArgs e)
        {
            textBox_TextChanged(sender, e);
        }
    }
}
