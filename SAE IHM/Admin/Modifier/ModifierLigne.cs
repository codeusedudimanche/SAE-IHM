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
                txtNom.Text = selectedLigne.NomLigne;
                _listeArrets = BD.GetArretDuneLigne(selectedLigne.NLigne).MesArret;
                _listeArretBackup = new List<Arret>(_listeArrets); // Sauvegarde de la liste d'arrêts pour les modifications
                lbArret.DataSource = null; // Important pour forcer le refresh
                lbArret.DataSource = _listeArrets;
                CreerBoutonsPourChaqueLigne();
                VisibilitePoubelle(); // Met à jour la visibilité des boutons de suppression
            }

        }

        private bool VerifModif()
        {
            if (_listeArretBackup == null || _listeArrets == null)
            {
                return false; // Handle null case appropriately  
            }

            Ligne ligne = (Ligne)cbLigne.SelectedItem;
            if (_listeArretBackup.Count() == _listeArrets.Count()
                && ligne?.NLigne.ToString() == txtNumero.Text
                && ligne?.Destination == txtDestination.Text
                && ligne?.NomLigne == txtNom.Text)
            {
                btnValider.Enabled = false;
                return false;
            }
            btnValider.Enabled = true;
            return true;
        }
        private void CreerBoutonsPourChaqueLigne()
        {
            int y = 358; // Position verticale initiale pour les boutons
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
            PictureBox btn = sender as PictureBox;
            if (btn != null && btn.Tag is int index)
            {
                // Récupère l'arrêt à supprimer depuis la ListBox
                Arret arretASupprimer = lbArret.Items[index] as Arret;

                if (arretASupprimer != null)
                {
                    // Supprime dans la source de données 
                    _listeArrets.Remove(arretASupprimer); // liste liée à lbArret.DataSource

                    // Met à jour l'affichage
                    lbArret.DataSource = null;
                    lbArret.DataSource = _listeArrets;

                    // Supprime le bouton correspondant
                    this.Controls.Remove(btn);

                    // Met à jour la liste des boutons (si tu en as une pour chaque arrêt)
                    boutonsSupprimer.Remove(btn);
                }
            }

            // Met à jour l'affichage des boutons de suppression
            CreerBoutonsPourChaqueLigne();
            VisibilitePoubelle();// Met à jour la visibilité des boutons de suppression
            VerifModif(); // Vérifie si des modifications ont été faites
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
        private List<Arret> GetArretASupprimer()
        {
            if ((_listeArretBackup?.Count() ?? 0) == (_listeArrets?.Count() ?? 0))
            {

                if (_listeArretBackup?.Count() == _listeArrets?.Count())
                    return null; // Aucune ligne n'a été supprimée, retourne null
            }
            List<Arret> arrets = new List<Arret>();
            foreach (Arret arret in _listeArretBackup)
            {
                if (!_listeArrets.Contains(arret))
                {
                    arrets.Add(arret); // Ajoute la ligne à supprimer
                }


            }
            return arrets;
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Êtes-vous sûr de vouloir modifier cette ligne ?", "Confirmation", MessageBoxButtons.YesNo))
            {
                Ligne ligne = (Ligne)cbLigne.SelectedItem;
                //On verifie si il y a eu un changement dans la ligne
                if (!(ligne?.NLigne.ToString() == txtNumero.Text
                    && ligne?.Destination == txtDestination.Text && ligne?.NomLigne == txtNom.Text))
                {
                    BD.UpdateLigne(ligne.NLigne, Convert.ToInt32(txtNumero.Text), txtNom.Text, txtDestination.Text);
                }
                if (_listeArretBackup.Count() != _listeArrets.Count())
                {
                    List<Arret> arretsASupprimer = GetArretASupprimer();
                    if (arretsASupprimer != null && arretsASupprimer.Count > 0)
                    {
                        foreach (Arret arret in arretsASupprimer)
                        {
                            if (BD.SupprimerArretDuneLigne(ligne.NLigne, arret.Id))
                            {
                                MessageBox.Show($"L'arret {arret.Nom} a été supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //Mise à jour des distances entre les arret
                                int index = _listeArretBackup.IndexOf(arret);

                                if (index != -1 && index < _listeArretBackup.Count - 1)
                                {
                                    Arret suivant = _listeArretBackup[index + 1];
                                    BD.UpdateDistance(ligne.NLigne, arret.Id, suivant.Id);
                                }
                                else
                                {
                                    BD.UpdateDistance(ligne.NLigne, arret.Id, null);
                                }
                            }
                        }
                    }
                }

            }
            
        }

        private void lbArret_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisibilitePoubelle();
            VerifModif();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            VerifModif();
            if (!int.TryParse(txtNumero.Text, out int resultat))
            {
                MessageBox.Show("Le nombre doit un entier valide. ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Text = cbLigne.SelectedItem is Ligne selectedLigne ? selectedLigne.NLigne.ToString() : string.Empty;

            }
        }
        private void txtDestination_TextChanged(object sender, EventArgs e)
        {
            VerifModif();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (_listeArretBackup.Count() == _listeArrets.Count())
            {
                MessageBox.Show("Les lignes deservies sont deja réinitialisée. ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _listeArrets = new List<Arret>(_listeArretBackup); // Restaure la liste originale
                lbArret.DataSource = null;
                lbArret.DataSource = _listeArrets; // Met à jour l'affichage
                CreerBoutonsPourChaqueLigne(); // Recrée les boutons de suppression
                VisibilitePoubelle();// Met à jour la visibilité des boutons de suppression
                VerifModif();
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            VerifModif();
        }
    }
}
