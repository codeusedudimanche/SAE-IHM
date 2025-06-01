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
            // Active le checkbox si un des RadioButtons est coché
            checkBoxCB.Enabled = radioButtonEnfant.Checked ||
                                 radioButtonAdulte.Checked ||
                                 radioButtonHandicape.Checked ||
                                 radioButtonVeteran.Checked ||
                                 radioButtonSenior.Checked;
        }
    }
}
