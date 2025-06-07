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
    public partial class AjoutHoraire : Form
    {
        private EspaceAdmin parentForm;
        private List<Ligne> _listeDesLignes;
        public AjoutHoraire(List<Ligne> lLigne, EspaceAdmin parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            // Initialisation de la liste des lignes de la combobox
            _listeDesLignes = lLigne;
            cbLigne.DataSource = _listeDesLignes;
            cbLigne.DisplayMember = "NomLigne";
            cbLigne.ValueMember = "NLigne";
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



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbArret_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cbLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ligne selectedLigne = (Ligne)cbLigne.SelectedItem;
            if (selectedLigne != null)
            {
                ListeArret listeArret = BD.listeArretDeLigne(selectedLigne);
                cbArret.DataSource = listeArret?.MesArret; // On recupère les arrêts de la ligne sélectionnée
                cbArret.DisplayMember = "Nom";
                cbArret.ValueMember = "Id";
            }
        }


        private void nud_ValueChanged(object sender, EventArgs e)
        {
            if ((nudHeure.Value < 0 || nudHeure.Value > 23) && (nudMinute.Value < 0 || nudMinute.Value > 60))
            {

                nudHeure.Value = 0; // Réinitialiser à 0 si la valeur est invalide
                nudMinute.Value = 0; // Réinitialiser à 0 si la valeur est invalide
                lblAlerteHeure.Text = "Veuillez entrer une heure (0-23) et une minute (0-60) valide.";
            }
            if (nudHeure.Value < 0 || nudHeure.Value > 23)
            {

                nudHeure.Value = 0; // Réinitialiser à 0 si la valeur est invalide
                lblAlerteHeure.Text = "Veuillez entrer une heure valide (0-23).";
            }
            else if (nudMinute.Value < 0 || nudMinute.Value > 59)
            {

                nudMinute.Value = 0; // Réinitialiser à 0 si la valeur est invalide
                lblAlerteHeure.Text = "Veuillez entrer une minute valide (0-59).";
            }
            else
            {
                lblAlerteHeure.Text = ""; // Effacer le message d'alerte si les valeurs sont valides
            }
        }

        private void AjoutHoraire_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int jourSemaine = 0;
            bool succes; // Variable pour vérifier si l'ajout a réussi
            if (cbSemaine.Checked && cbJourFerie.Checked)
            {
                jourSemaine = 3; // On considére que 3 vaut pour tous le temps
            }
            else if (cbSemaine.Checked)
            {
                jourSemaine = 1; // On considére que 1 vaut pour les jours de la semaine
            }
            else if (cbJourFerie.Checked) // Correction: Added 'if' keyword
            {
                jourSemaine = 2; // On considére que 2 vaut pour les jours fériés uniquement
            }

            int nLigne = ((Ligne)cbLigne.SelectedItem).NLigne; // Récupération du numéro de la ligne sélectionnée
            int nArret = ((Arret)cbArret.SelectedItem).Id; // Récupération de l'ID de l'arrêt sélectionné
            string horaire = $"{(int)nudHeure.Value:D2}:{(int)nudMinute.Value:D2}:00"; // Formatage de l'heure et des minutes
            succes = BD.AjoutHorraire(jourSemaine, nLigne, nArret, horaire); // Appel de la méthode pour ajouter l'horaire
            if (succes)
            {
                MessageBox.Show("Horaire ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Fermer le formulaire après l'ajout réussi
            }
            else
            {
                MessageBox.Show("Échec de l'ajout de l'horaire. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbPeriode_Changed(object sender, EventArgs e)
        {
            if (cbSemaine.Checked || cbJourFerie.Checked)
            {
                btnValider.Enabled = true; // Activer le bouton de validation si au moins une case est cochée
            }
            else
            {
                btnValider.Enabled = false; // Désactiver le bouton de validation si aucune case n'est cochée
            }
        }
    }
}
