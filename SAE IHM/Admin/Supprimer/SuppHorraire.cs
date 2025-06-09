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
    public partial class SuppHorraire : Form
    {
        private EspaceAdmin parentForm;
        private List<Arret> _listeDesArrets;
        private ListeHoraire _listeHorairesWrapper;

        public SuppHorraire(List<Arret> arrets, EspaceAdmin parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            _listeDesArrets = arrets;
            comboBoxArret.DataSource = _listeDesArrets;
            comboBoxArret.DisplayMember = "Nom";
            comboBoxArret.ValueMember = "Id";

            _listeHorairesWrapper = new ListeHoraire();
            comboBoxHorraire.DataSource = _listeHorairesWrapper.MesHoraires;

            comboBoxArret.SelectedIndexChanged += ComboBoxArret_SelectedIndexChanged;

            if (_listeDesArrets != null && _listeDesArrets.Count > 0)
            {
                comboBoxArret.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Aucun arrêt trouvé dans la base de données.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxHorraire.DataSource = null;
                comboBoxHorraire.Text = "";
            }
        }

        private void ComboBoxArret_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxHorraire.Enabled = true;
            if (comboBoxArret.SelectedItem != null)
            {
                Arret arretSelectionne = comboBoxArret.SelectedItem as Arret;

                if (arretSelectionne != null)
                {
                    _listeHorairesWrapper = BD.GetHorairesPourArret(arretSelectionne.Id);

                    comboBoxHorraire.DataSource = null;
                    comboBoxHorraire.DataSource = _listeHorairesWrapper.MesHoraires;

                    if (_listeHorairesWrapper.MesHoraires.Count > 0)
                    {
                        comboBoxHorraire.SelectedIndex = 0;
                    }
                    else
                    {
                        comboBoxHorraire.Text = "";
                        MessageBox.Show("Aucun horaire trouvé pour cet arrêt.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                comboBoxHorraire.DataSource = null;
                if (_listeHorairesWrapper != null)
                {
                    _listeHorairesWrapper.MesHoraires.Clear();
                }
                comboBoxHorraire.Text = "";
            }
        }

        private void SuppHorraire_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet horaire ?", "Confirmation", MessageBoxButtons.YesNo))
            {
                Horaire horaireASupprimer = comboBoxHorraire.SelectedItem as Horaire;
                if (horaireASupprimer != null)
                {
                    _listeHorairesWrapper.MesHoraires.Remove(horaireASupprimer);
                    comboBoxHorraire.DataSource = null;
                    comboBoxHorraire.DataSource = _listeHorairesWrapper.MesHoraires;
                    BD.DeleteHoraire(horaireASupprimer);
                }
                else
                {
                    MessageBox.Show("Aucun horaire sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pbEspaceAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}