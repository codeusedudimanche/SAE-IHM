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
using SAE_IHM.Admin.Modifier;

namespace SAE_IHM
{

    public partial class AdminModifier : Form
    {
        private EspaceAdmin Parent;
        public AdminModifier(EspaceAdmin parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void AdminModifier_Load(object sender, EventArgs e)
        {

        }

        private void pbAcceuil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AdminModifier_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void AdminModifier_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Show();
        }

        private void pbModifierArret_Click(object sender, EventArgs e)
        {

            // Ouvre la fenêtre de modification des arrêts
            ModifierArret modifierArret = new ModifierArret(BD.GetArret().MesArret, Parent);
            modifierArret.Show();
            this.Hide();
        }

        private void pbModifierLigne_Click(object sender, EventArgs e)
        {

        }
    }
}
