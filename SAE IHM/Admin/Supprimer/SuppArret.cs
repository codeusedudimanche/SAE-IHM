﻿using System;
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
            comboBoxArret.DisplayMember = "Nom";
            comboBoxArret.ValueMember = "Id";
        }

        private void SuppArret_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
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
                    comboBoxArret.DisplayMember = "Nom";
                    comboBoxArret.ValueMember = "Id";
                    // Optionnel : Vous pouvez également mettre à jour la base de données ici si nécessaire
                    BD.DeleteArret(Narret);

                }
                else
                {
                    MessageBox.Show("Aucun arret sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pbEspaceAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxArret_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


