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
    public partial class AjoutHoraire : Form
    {
        private EspaceAdmin parentForm;
        public AjoutHoraire(EspaceAdmin parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void lbLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ligne sélectionnée : " + lbLigne.SelectedItem.ToString());
        }

        private void AjoutHoraire_Load(object sender, EventArgs e)
        {

        }

        private void pbEspaceAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjoutHoraire_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
