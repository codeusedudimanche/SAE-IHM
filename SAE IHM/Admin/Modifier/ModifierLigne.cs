using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base;

namespace SAE_IHM.Admin.Modifier
{
    public partial class ModifierLigne : Form
    {
        //Propriétés
        private List<Arret> _listeArretBackup = new List<Arret>();
        private List<PictureBox> boutonsSupprimer = new List<PictureBox>();
        private List<Ligne> _listeLigne;
        private AdminModifier _espaceParent;
        private List<Arret> _listeArrets = new List<Arret>();
        public ModifierLigne(List<Ligne> L, AdminModifier espaceParent)
        {
            InitializeComponent();
            _listeLigne = L;
            _espaceParent = espaceParent;
            cbLigne.DataSource = _listeLigne;
        }

        private void cbLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLigne.SelectedItem is Ligne selectedLigne)
            {
                txtNumero.Text = selectedLigne.NLigne.ToString();
                txtDestination.Text = selectedLigne.Destination;

                List<Arret> _listeArrets = BD.GetArretDuneLigne(selectedLigne.NLigne).MesArret;
                _listeArretBackup = new List<Arret>(_listeArrets); // Sauvegarde de la liste d'arrêts pour les modifications
                lbArret.DataSource = null; // Important pour forcer le refresh
                lbArret.DataSource = _listeArrets;
                CreerBoutonsPourChaqueLigne();
                VisibilitePoubelle(); // Met à jour la visibilité des boutons de suppression
            }

        }

        private bool VerifModif()
        {
            Ligne ligne = (Ligne)cbLigne.SelectedItem;
            // Vérification si les arrets ont été modifiés
            if (_listeArretBackup.Count() == _listeArrets.Count() 
                && ligne.NLigne.ToString() == txtNumero.Text 
                && ligne.Destination == txtDestination.Text)
            {
                btnValider.Enabled = false; // Désactive le bouton de validation si la ligne n'a pas été modifiée
                return false; // La ligne n'a pas été modifiée
            }
            btnValider.Enabled = true; // Active le bouton de validation si la ligne a été modifiée
            return true; // La ligne a été modifiée
        }
        private void CreerBoutonsPourChaqueLigne()
        {
            int y = 347; // Position verticale initiale pour les boutons
            foreach (var bouton in boutonsSupprimer)
            {
                this.Controls.Remove(bouton);
            }
            boutonsSupprimer.Clear(); // Important si on recrées les boutons
            for (int i = 0; i < lbArret.Items.Count; i++)
            {
                int index = i; // Copie pour éviter les problèmes de closure dans l'événement

                PictureBox btnSupprimer = new PictureBox();
                btnSupprimer.Image = Properties.Resources.poubelle;
                btnSupprimer.Size = new Size(25, 25);
                btnSupprimer.Location = new Point(840, y); // Change X et Y selon où les afficher
                btnSupprimer.Tag = index; // Stocke l'index dans le Tag (utile dans l'événement)
                btnSupprimer.SizeMode = PictureBoxSizeMode.Zoom; // Pour que l'image s'adapte au bouton
                btnSupprimer.Click += BtnSupprimer_Click;
                this.Controls.Add(btnSupprimer);
                btnSupprimer.BringToFront(); // Pour qu’il soit visible au-dessus des autres
                boutonsSupprimer.Add(btnSupprimer); // <-- On garde une référence ici
                y += 23; // Décale le bouton suivant vers le bas
            }
        }
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {

        }
        private void VisibilitePoubelle()
        {
            int selectedIndex = lbArret.SelectedIndex;

            for (int i = 0; i < boutonsSupprimer.Count; i++)
            {
                boutonsSupprimer[i].Visible = (i == selectedIndex);
            }
        }
        private void ModifierLigne_FormClosing(object sender, FormClosingEventArgs e)
        {
            _espaceParent.Close();
        }

        private void pbEspaceAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

        }

        private void lbArret_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisibilitePoubelle();
            VerifModif();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            VerifModif();
        }

        private void txtDestination_TextChanged(object sender, EventArgs e)
        {
            VerifModif();
        }
    }
}
