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

namespace SAE_IHM.Admin.Modifier
{
    public partial class ModifierArret : Form
    {
        //Propriétés
        private List<Arret> _lArret;
        private EspaceAdmin _espaceAdmin;

        //Constructeur
        public ModifierArret(List<Arret> lArret, EspaceAdmin espaceAdm)
        {
            InitializeComponent();
            _lArret = lArret;
            _espaceAdmin = espaceAdm;
            cbArret.DataSource = _lArret;
            cbArret.DisplayMember = "Nom";
            cbArret.ValueMember = "Id";
        }

        private void pbEspaceAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifierArret_FormClosed(object sender, FormClosedEventArgs e)
        {
            _espaceAdmin.Show();
        }

        private void cbArret_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbArret.SelectedItem is Arret selectedArret)
            {
                Arret arret = BD.InfoArret(selectedArret.Id);
                if (arret != null)
                {
                    txtNom.Text = arret.Nom;
                    txtLongitude.Text = arret.Longitude.ToString();
                    txtLatitude.Text = arret.Latitude.ToString();
                }
                ListeLigne lignes = BD.GetListeLigneArret(arret.Id);
                lbLigne.DataSource = lignes.MesLigne;
                lbLigne.DisplayMember = "NomLigne";
                lbLigne.ValueMember = "NLigne";

            }



        }
    }
}
