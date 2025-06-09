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
        private bool miseAJourEnCours = false;
        private List<Arret> _lArret;
        private EspaceAdmin _espaceAdmin;
        private List<PictureBox> boutonsSupprimer = new List<PictureBox>();
        private List<Ligne> _listeDesLignes = new List<Ligne>();


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
                miseAJourEnCours = true;
                Arret arret = BD.InfoArret(selectedArret.Id);
                if (arret != null)
                {
                    txtNom.Text = arret.Nom;
                    txtLongitude.Text = arret.Longitude.ToString();
                    txtLatitude.Text = arret.Latitude.ToString();
                }
                ListeLigne lignes = BD.GetListeLigneArret(arret.Id);
                _listeDesLignes = lignes.MesLigne; // Convertit en liste pour la manipulation
                lbLigne.DataSource = null;
                lbLigne.DataSource = _listeDesLignes;
                
                lbLigne.DisplayMember = "NomLigne";
                lbLigne.ValueMember = "NLigne";
                CreerBoutonsPourChaqueLigne();
                miseAJourEnCours = false;
            }
            
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
                    // Supprime la ligne de la base de données
                    BD.SupprimerLigneDunArret(arret.Id, ligneASupprimer.NLigne);
                    // Supprime dans la source de données (ex : _lignesLieesAuComboBox)
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
        }
        private void pnlBackround_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {

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
    }
}
