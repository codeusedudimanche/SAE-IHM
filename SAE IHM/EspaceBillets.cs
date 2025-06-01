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
            // Active la checkbox si un des RadioButtons est coché
            checkBoxCB.Enabled = radioButtonEnfant.Checked ||
                                 radioButtonAdulte.Checked ||
                                 radioButtonHandicape.Checked ||
                                 radioButtonVeteran.Checked ||
                                 radioButtonSenior.Checked;

            // Si c’est un RadioButton qui vient d’être coché, on passe le texte de label3 et celui de checkBoxCB en noir
            var rb = (RadioButton)sender;
            if (rb.Checked)
            {
                label3.ForeColor = Color.Black;
                checkBoxCB.ForeColor = Color.Black;
            }
        }
    }
}
