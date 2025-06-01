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
    public partial class EspaceBillets : Form
    {

        public EspaceBillets()
        {
            InitializeComponent();
            checkBoxCB.Enabled = false; // Désactive la case à cocher cb
            btnValide.Enabled = false; // Le bouton est désactivé au démarrage

            checkBoxCB.CheckedChanged += checkBoxCB_CheckedChanged;



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EspaceBillets_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0]!.Show();
            this.Close();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCB.Enabled = radioButtonEnfant.Checked ||
                                 radioButtonAdulte.Checked ||
                                 radioButtonHandicape.Checked ||
                                 radioButtonVeteran.Checked ||
                                 radioButtonSenior.Checked;

            var rb = (RadioButton)sender;
            if (rb.Checked)
            {
                label3.ForeColor = Color.Black;
                checkBoxCB.ForeColor = Color.Black;
            }

            UpdateBtnValideState(); // Met à jour l'état du bouton
        }


        private void UpdateBtnValideState()
        {
            bool radioSelected = radioButtonEnfant.Checked ||
                                 radioButtonAdulte.Checked ||
                                 radioButtonHandicape.Checked ||
                                 radioButtonVeteran.Checked ||
                                 radioButtonSenior.Checked;

            btnValide.Enabled = radioSelected && checkBoxCB.Checked;
        }

        private void checkBoxCB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBtnValideState(); // Met à jour l'état du bouton quand la checkbox est coché ou non
        }


    }
}
