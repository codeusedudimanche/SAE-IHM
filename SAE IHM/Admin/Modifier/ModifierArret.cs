using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base; 
using Org.BouncyCastle.Pkix;

namespace SAE_IHM.Admin.Modifier
{
    public partial class ModifierArret : Form
    {
        //Propriétés
        private bool _formCharge = false;
        private bool _modificationcbLatLong = false;
        private bool _modificationInterneLatitudeLong = false;
        private bool miseAJourEnCours = false;
        private List<Arret> _lArret;
        private AdminModifier _espaceModifier;
        private List<PictureBox> boutonsSupprimer = new List<PictureBox>();
        private List<Ligne> _listeDesLignes = new List<Ligne>();
        private List<Ligne> _listeDesLignesBackup = new List<Ligne>();
        private Arret arretBackup;
        private Arret arretChoisie;


        //Constructeur
        public ModifierArret(List<Arret> lArret, AdminModifier admnModifier)
        {
            InitializeComponent();
            _lArret = lArret;
            _espaceModifier = admnModifier;
            cbArret.DataSource = _lArret;
            cbArret.DisplayMember = "Nom";
            cbArret.ValueMember = "Id";
            txtLatitude.TextChanged += VerifModification;
            txtLongitude.TextChanged += VerifModification;
            txtNom.TextChanged += VerifModification;
            cbArret.SelectedIndexChanged += VerifModification;

            lbLigne.SelectedIndexChanged += lbLigne_SelectedIndexChanged;
        }

        private void pbEspaceAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifierArret_FormClosed(object sender, FormClosedEventArgs e)
        {
            _espaceModifier.Close();
        }

        private void cbArret_SelectedIndexChanged(object sender, EventArgs e)
        {
            _modificationcbLatLong = true; // Indique qu'il y a une modification classique de la combobox
            if (cbArret.SelectedItem is Arret selectedArret)
            {
                Arret arret = BD.InfoArret(selectedArret.Id);
                arretBackup = arret; // Garde une copie de l'arret pour les modifications
                arretChoisie = arret; // Garde une référence à l'arret choisi
                if (arret != null)
                {
                    txtNom.Text = arret.Nom;
                    txtLongitude.Text = arret.Longitude.ToString();
                    txtLatitude.Text = arret.Latitude.ToString();
                    // Constructeur copie
                    arretBackup = new Arret(arret.Id, arret.Nom, arret.Longitude, arret.Latitude);
                }
                ListeLigne lignes = BD.GetListeLigneArret(arret.Id);
                _listeDesLignes = lignes.MesLigne; // Convertit en liste pour la manipulation
                // Garde une copie de la liste originale pour les modifications
                _listeDesLignesBackup = new List<Ligne>(_listeDesLignes);
                lbLigne.DataSource = null;
                lbLigne.DataSource = _listeDesLignes;

                CreerBoutonsPourChaqueLigne();
                lbLigne_SelectedIndexChanged(sender, e);
            }
            _modificationcbLatLong = false; // Réinitialise après la modification
        }

        private void gbLigne_Enter(object sender, EventArgs e)
        {

        }


        private void CreerBoutonsPourChaqueLigne()
        {
            int y = 288; // Position verticale initiale pour les boutons
            foreach (var bouton in boutonsSupprimer)
            {
                this.Controls.Remove(bouton);
            }
            boutonsSupprimer.Clear(); // Important si on recrées les boutons
            for (int i = 0; i < lbLigne.Items.Count; i++)
            {
                int index = i; // Copie pour éviter les problèmes de closure dans l'événement

                PictureBox btnSupprimer = new PictureBox();
                btnSupprimer.Image = Properties.Resources.poubelle;
                btnSupprimer.Size = new Size(20, 20);
                btnSupprimer.Location = new Point(980, y); // Change X et Y selon où tu veux les afficher
                btnSupprimer.Tag = index; // Stocke l'index dans le Tag (utile dans l'événement)
                btnSupprimer.SizeMode = PictureBoxSizeMode.Zoom; // Pour que l'image s'adapte au bouton
                btnSupprimer.Click += BtnSupprimer_Click;
                this.Controls.Add(btnSupprimer);
                btnSupprimer.BringToFront(); // Pour qu’il soit visible au-dessus des autres
                boutonsSupprimer.Add(btnSupprimer); // <-- On garde une référence ici
                y += 26; // Décale le bouton suivant vers le bas
            }
        }
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            if (btn != null && btn.Tag is int index)
            {
                // Récupère l'ID de la ligne à supprimer
                Ligne ligneASupprimer = lbLigne.Items[index] as Ligne;
                Arret arret = cbArret.SelectedItem as Arret;
                if (ligneASupprimer != null)
                {
                    // Supprime dans la source de données 
                    _listeDesLignes.Remove(ligneASupprimer); // liste liée à lbLigne.DataSource

                    // Met à jour l'affichage en réassignant la DataSource
                    lbLigne.DataSource = null;
                    lbLigne.DataSource = _listeDesLignes;
                    // Supprime le bouton correspondant
                    this.Controls.Remove(btn);
                    // Met à jour la liste des boutons
                    boutonsSupprimer.Remove(btn);
                }
            }
            // Met à jour l'affichage des boutons de suppression
            CreerBoutonsPourChaqueLigne();

            VerifModification(sender, e); // Vérifie si des modifications ont été faites
        }
        private void pnlBackround_Paint(object sender, PaintEventArgs e)
        {

        }

        private List<Ligne> GetLignesASupprimer()
        {
            if ((_listeDesLignes?.Count() ?? 0) == (_listeDesLignesBackup?.Count() ?? 0))
            {

                if (_listeDesLignes?.Count() == _listeDesLignesBackup?.Count())
                    return null; // Aucune ligne n'a été supprimée, retourne null
            }
            List<Ligne> lignes = new List<Ligne>();
            foreach (Ligne ligne in _listeDesLignesBackup)
            {
                if (!_listeDesLignes.Contains(ligne))
                {
                    lignes.Add(ligne); // Ajoute la ligne à supprimer
                }


            }
            return lignes;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Êtes-vous sûr de vouloir modifier cette arret ?", "Confirmation", MessageBoxButtons.YesNo)){
                _listeDesLignes = GetLignesASupprimer(); // Récupère les lignes restantes après suppression
                if (!AreArretEqual())
                    BD.ModifArret(arretChoisie.Id, txtNom.Text, Convert.ToDouble(txtLongitude.Text), Convert.ToDouble(txtLatitude.Text));
                if (_listeDesLignes != null && _listeDesLignes.Count > 0)
                {
                    foreach (Ligne ligne in _listeDesLignes)
                    {
                        BD.SupprimerLigneDunArret(arretChoisie.Id, ligne.NLigne);
                    }

                }
            }
            
        }

        private bool AreArretEqual()
        {
            if (arretBackup == null || txtNom.Text == null || txtLongitude.Text == null || txtLatitude.Text == null)
                return false;
            return arretBackup.Nom == txtNom.Text &&
                   arretBackup.Longitude.ToString() == txtLongitude.Text &&
                   arretBackup.Latitude.ToString() == txtLatitude.Text;
        }

        private void txtLatitude_TextChanged(object sender, EventArgs e)
        {

            // Empêche d'exécuter le code si on modifie le champ par code ou au lancement de la fenêtre
            if (!_formCharge || _modificationInterneLatitudeLong || _modificationcbLatLong)
                return;

            if (string.IsNullOrWhiteSpace(txtLatitude.Text))
                return; // Ne rien faire si le champ est vide

            bool estUnNombre = double.TryParse(txtLatitude.Text.Replace('.', ','), out double resultat);
            if (!estUnNombre)
            {
                MessageBox.Show("La latitude doit être un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Empêche la relance de l'événement
                _modificationInterneLatitudeLong = true;
                txtLatitude.Text = arretBackup.Latitude.ToString();
                _modificationInterneLatitudeLong = false;
            }
        }
        private void txtLongitude_TextChanged(object sender, EventArgs e)
        {

            // Empêche d'exécuter le code si on modifie le champ par code ou au lancement de la fenêtre
            if (!_formCharge || _modificationInterneLatitudeLong || _modificationcbLatLong)
                return;

            if (string.IsNullOrWhiteSpace(txtLatitude.Text))
                return; // Ne rien faire si le champ est vide

            bool estUnNombre = double.TryParse(txtLongitude.Text.Replace('.', ','), out double resultat);
            if (!estUnNombre)
            {
                MessageBox.Show("La longitude doit être un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Empêche la relance de l'événement
                _modificationInterneLatitudeLong = true;
                txtLongitude.Text = arretBackup.Longitude.ToString();
                _modificationInterneLatitudeLong = false;
            }
        }

        private void VerifModification(object sender, EventArgs e)
        {
            bool areArretsEqual = AreArretEqual();
            bool areListsEqual = (_listeDesLignes?.Count() ?? 0) == (_listeDesLignesBackup?.Count() ?? 0);

            if (areListsEqual && areArretsEqual)
            {
                btnValider.Enabled = false; // Aucune modification, désactive le bouton
            }
            else
            {
                if (txtNom.Text == "" || txtLongitude.Text == "" || txtLatitude.Text == "")
                {
                    btnValider.Enabled = false; // Désactive le bouton si les champs sont vides
                }
                else if (cbArret.SelectedItem == null)
                {
                    btnValider.Enabled = false; // Désactive le bouton si aucun arrêt n'est sélectionné
                }
                else
                    // Si des modifications ont été faites, active le bouton
                    btnValider.Enabled = true; // Des modifications ont été faites, active le bouton
            }
        }


        private void lbLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (miseAJourEnCours) return;
            int selectedIndex = lbLigne.SelectedIndex;

            for (int i = 0; i < boutonsSupprimer.Count; i++)
            {
                boutonsSupprimer[i].Visible = (i == selectedIndex);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            if (_listeDesLignesBackup.Count() == _listeDesLignes.Count())
            {
                MessageBox.Show("Les lignes deservies sont deja réinitialisée. ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _listeDesLignes = new List<Ligne>(_listeDesLignesBackup); // Restaure la liste originale
                lbLigne.DataSource = null;
                lbLigne.DataSource = _listeDesLignes; // Met à jour l'affichage
                CreerBoutonsPourChaqueLigne(); // Recrée les boutons de suppression
                lbLigne_SelectedIndexChanged(sender, e);// Met à jour la visibilité des boutons de suppression
                VerifModification(sender,e);
            }
        }

        private void ModifierArret_Load(object sender, EventArgs e)
        {
            _formCharge = true;
            VerifModification(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
