using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Base;

namespace SAE_IHM
{
    public partial class SuppLigne : Form
    {
        private EspaceAdmin parentForm;
        private List<Ligne> _listeDesLignes;

        public SuppLigne(List<Ligne> lignes, EspaceAdmin parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            _listeDesLignes = lignes;
            comboBoxLigne.DataSource = _listeDesLignes;
            comboBoxLigne.DisplayMember = "NomLigne";
            comboBoxLigne.ValueMember = "NLigne";
        }

        private void SuppLigne_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette ligne ?", "Confirmation", MessageBoxButtons.YesNo))
            {
                Ligne ligneASupprimer = (Ligne)comboBoxLigne.SelectedItem;
                if (ligneASupprimer != null)
                {
                    int Nligne = ligneASupprimer.NLigne;
                    _listeDesLignes.Remove(ligneASupprimer);
                    comboBoxLigne.DataSource = null; // Réinitialiser la source de données
                    comboBoxLigne.DataSource = _listeDesLignes; // Réaffecter la liste mise à jour
                    comboBoxLigne.DisplayMember = "NomLigne";
                    comboBoxLigne.ValueMember = "NLigne";
                    // Optionnel : Vous pouvez également mettre à jour la base de données ici si nécessaire
                    BD.DeleteLigne(Nligne);
                }
                else
                {
                    MessageBox.Show("Aucune ligne sélectionnée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxLigne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
