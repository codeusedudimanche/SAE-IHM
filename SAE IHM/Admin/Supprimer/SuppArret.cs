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
    public partial class SuppArret : Form
    {
        private EspaceAdmin parentForm;
        private List<Arret> _listeDesArrets;
        public SuppArret(List<Arret> arrets, EspaceAdmin parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            _listeDesArrets = arrets;
            comboBoxArret.DataSource = _listeDesArrets;
            comboBoxArret.DisplayMember = "NomLigne";
            comboBoxArret.ValueMember = "NLigne";
        }

        private void SuppArret_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm.Show();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet arret ?", "Confirmation", MessageBoxButtons.YesNo))
            {
                Arret arretASupprimer = (Arret)comboBoxArret.SelectedItem;
                if (arretASupprimer != null)
                {
                    int Narret = arretASupprimer._NArret;
                    _listeDesArrets.Remove(arretASupprimer);
                    comboBoxArret.DataSource = null; // Réinitialiser la source de données
                    comboBoxArret.DataSource = _listeDesArrets; // Réaffecter la liste mise à jour
                    comboBoxArret.DisplayMember = "NomLigne";
                    comboBoxArret.ValueMember = "NLigne";
                    // Optionnel : Vous pouvez également mettre à jour la base de données ici si nécessaire
                    BD.DeleteLigne(Narret);

                }
                else
                {
                    MessageBox.Show("Aucun arret sélectionnée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pbEspaceAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


