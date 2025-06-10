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
using Org.BouncyCastle.Tls;

namespace SAE_IHM.Admin.Modifier
{
    public partial class ModifierHoraire : Form
    {
        private AdminModifier _adminModifier;
        private List<Horaire> _horaires;
        private List<Horaire> _horairesBackup;
        private List<int> _semaineBackup;
        private List<int> _semaine;
        private List<PictureBox> boutonsSupprimer = new List<PictureBox>();
        private int _y = 304; // Position verticale initiale pour les boutons
        private PictureBox _boutonPlus = null;
        private int tagMax = 0;
        public ModifierHoraire(AdminModifier admnModifier)
        {
            InitializeComponent();
            cbLigne.DataSource = BD.GetLigne().MesLigne;

            _adminModifier = admnModifier;
        }
        private void VerifModif()
        {

        }

        private void CreerBoutonsPourChaqueLigne()
        {



            int y = 304; // Position verticale initiale pour les boutons
            foreach (var bouton in boutonsSupprimer)
            {
                this.Controls.Remove(bouton);
                bouton.Dispose();
            }
            boutonsSupprimer.Clear(); // Important si on recrées les boutons
            if (_horaires.Count == 0)

            {
                AjoutPlus();
                return;
                
            }
            
            for (int i = 0; i < _horaires.Count; i++)
            {
                int index = i; // Copie pour éviter les problèmes de closure dans l'événement

                PictureBox btnSupprimer = new PictureBox();
                btnSupprimer.Image = Properties.Resources.poubelle;
                btnSupprimer.Size = new Size(30, 30);
                btnSupprimer.Location = new Point(788, y); // Coordonnée de la poubelle
                btnSupprimer.Tag = index; // Stocke l'index dans le Tag (utile dans l'événement)
                btnSupprimer.SizeMode = PictureBoxSizeMode.Zoom; // Pour que l'image s'adapte au bouton
                btnSupprimer.Click += BtnSupprimer_Click;
                this.Controls.Add(btnSupprimer);
                btnSupprimer.BringToFront(); // Pour qu’il soit visible au-dessus des autres
                boutonsSupprimer.Add(btnSupprimer); // <-- On garde une référence ici
                y += 40; // Décale le bouton suivant vers le bas

            }
            tagMax = _horaires.Count;
            AjoutPlus();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            if (btn != null && btn.Tag is int index)
            {
                _horaires.RemoveAt(index); // Supprime l'horaire de la liste
                _semaine.RemoveAt(index); // Supprime le jour de la semaine associé
                flpHoraire.Controls.RemoveAt(index); // Supprime le panel horaire de l'affichage
                // On supprime le bouton de la liste des boutons
                // On met à jour les boutons restants
                for (int i = 0; i < boutonsSupprimer.Count; i++)
                {
                    boutonsSupprimer[i].Tag = i; // Met à jour l'index du bouton
                    boutonsSupprimer[i].Location = new Point(788, 360 + (i * 40)); // Met à jour la position
                }
                // On met à jour l'affichage des horaires restants
                cbArret_SelectedIndexChanged(sender, e); // Rafraîchit l'affichage des horaires pour l'arrêt sélectionné
            }

            // Met à jour l'affichage des boutons de suppression
            CreerBoutonsPourChaqueLigne();

            VerifModif(); // Vérifie si des modifications ont été faites
            if (_horaires.Count == 0)
            {
                flpHoraire.Controls.Clear();

                // Vérifier plus précisément si un label existe déjà
                var existingLabel = flpHoraire.Controls.OfType<Label>()
                                      .FirstOrDefault(l => l.Name == "lblAucunHoraire");

                if (existingLabel == null)
                {
                    Label lblAucunHoraire = new Label()
                    {
                        Name = "lblAucunHoraire",
                        Text = "Aucun horaire disponible pour cette ligne et cet arrêt.",
                        AutoSize = true,
                        ForeColor = Color.Red,
                        Location = new Point(20, 20)
                    };
                    flpHoraire.Controls.Add(lblAucunHoraire);
                }
            }
        }

        private void cbLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbArret.DataSource = BD.GetArretDuneLigne(((Ligne)cbLigne.SelectedItem).NLigne).MesArret;
            CreerBoutonsPourChaqueLigne();
        }

        private void cbArret_SelectedIndexChanged(object sender, EventArgs e)
        {
            // On vide le panel des horaires
            flpHoraire.Controls.Clear();
            int nombreHoraire = cbArret.Items.Count;

            Ligne ligne = ((Ligne)cbLigne.SelectedItem);
            Arret arret = ((Arret)cbArret.SelectedItem);
            (List<Horaire> h, List<int> Semaine) r = BD.GetHoraireLigneArret(ligne.NLigne, arret.Id);
            _horairesBackup = r.h;
            _semaineBackup = r.Semaine;

            // On récupère les horaires de la ligne et de l'arrêt sélectionnés
            //On vérifie si l'objet sender est bien le ComboBox cbArret 
            //Si non c'est que c'est la pictureBox Poubelle donc on ne met surtout pas a jour

            if (sender.GetType() == cbArret.GetType())
            {
                (List<Horaire> h, List<int> Semaine) retour = BD.GetHoraireLigneArret(ligne.NLigne, arret.Id);
                _horaires = retour.h;
                _semaine = retour.Semaine;
            }

            for (int i = 0; i < _horaires.Count; i++)
            {

                // Panel pour regrouper les éléments d'un horaire
                FlowLayoutPanel panelHoraire = new FlowLayoutPanel()
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = false,
                    Padding = new Padding(5, 0, 5, 0),
                    Margin = new Padding(0, 5, 0, 5) // Espacement vertical entre chaque ligne
                };

                // TextBox pour l'horaire
                TextBox tbHoraire = new TextBox()
                {
                    Text = _horaires[i].Heure.HasValue ? _horaires[i].Heure.Value.ToString(@"hh\:mm") : string.Empty,
                    Height = 24,
                    Margin = new Padding(0, 2, 10, 0)
                };
                panelHoraire.Controls.Add(tbHoraire);

                // Checkbox jour de semaine
                CheckBox checkBoxSemaine = new CheckBox()
                {
                    Text = "Jour de la semaine",
                    // Si _semaine[i] == 1 ou 3 cela veut dire que c'est actif la semaine
                    Checked = _semaine[i] % 2 == 1,
                    AutoSize = true,
                    Margin = new Padding(0, 4, 20, 0)
                };
                panelHoraire.Controls.Add(checkBoxSemaine);

                // Checkbox jour férié
                CheckBox checkBoxFerie = new CheckBox()
                {
                    Text = "Jour férié et week-end",
                    //Si _semaine[i] >= 2 (2 ou 3) cela veut dire que c'est actif le week-end ou jour férié
                    Checked = _semaine[i] >= 2,
                    AutoSize = true,
                    Margin = new Padding(0, 4, 0, 0)
                };
                panelHoraire.Controls.Add(checkBoxFerie);

                // Ajouter le panel au FlowLayoutPanel principal
                flpHoraire.Controls.Add(panelHoraire);

            }
            CreerBoutonsPourChaqueLigne();
            if (_horaires.Count == 0)
            {
                flpHoraire.Controls.Clear();

                // Vérifier plus précisément si un label existe déjà
                var existingLabel = flpHoraire.Controls.OfType<Label>()
                                      .FirstOrDefault(l => l.Name == "lblAucunHoraire");

                if (existingLabel == null)
                {
                    Label lblAucunHoraire = new Label()
                    {
                        Name = "lblAucunHoraire",
                        Text = "Aucun horaire disponible pour cette ligne et cet arrêt.",
                        AutoSize = true,
                        ForeColor = Color.Red,
                        Location = new Point(20, 20)
                    };
                    flpHoraire.Controls.Add(lblAucunHoraire);
                }
            }

        }


        private void pbEspaceAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifierHoraire_FormClosing(object sender, FormClosingEventArgs e)
        {
            _adminModifier.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // On vide le panel des horaires
            flpHoraire.Controls.Clear();
            int nombreHoraire = cbArret.Items.Count;
            Ligne ligne = ((Ligne)cbLigne.SelectedItem);
            Arret arret = ((Arret)cbArret.SelectedItem);

            _horaires = new List<Horaire>(_horairesBackup);
            _semaine = new List<int>(_semaineBackup);
            tagMax = _horaires.Count(); // Le nombre de bouton Poubelle
            
            // On récupère les horaires de la ligne et de l'arrêt sélectionnés
            //On vérifie si l'objet sender est bien le ComboBox cbArret 
            //Si non c'est que c'est la pictureBox Poubelle donc on ne met surtout pas a jour

            for (int i = 0; i < _horairesBackup.Count; i++)
            {

                // Panel pour regrouper les éléments d'un horaire
                FlowLayoutPanel panelHoraire = new FlowLayoutPanel()
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = false,
                    Padding = new Padding(5, 0, 5, 0),
                    Margin = new Padding(0, 5, 0, 5) // Espacement vertical entre chaque ligne
                };

                // TextBox pour l'horaire
                TextBox tbHoraire = new TextBox()
                {
                    Text = _horairesBackup[i].Heure.HasValue ? _horairesBackup[i].Heure.Value.ToString(@"hh\:mm") : string.Empty,
                    Height = 24,
                    Margin = new Padding(0, 2, 10, 0)
                };
                panelHoraire.Controls.Add(tbHoraire);

                // Checkbox jour de semaine
                CheckBox checkBoxSemaine = new CheckBox()
                {
                    Text = "Jour de la semaine",
                    // Si _semaine[i] == 1 ou 3 cela veut dire que c'est actif la semaine
                    Checked = _semaineBackup[i] % 2 == 1,
                    AutoSize = true,
                    Margin = new Padding(0, 4, 20, 0)
                };
                panelHoraire.Controls.Add(checkBoxSemaine);

                // Checkbox jour férié
                CheckBox checkBoxFerie = new CheckBox()
                {
                    Text = "Jour férié et week-end",
                    //Si _semaine[i] >= 2 (2 ou 3) cela veut dire que c'est actif le week-end ou jour férié
                    Checked = _semaineBackup[i] >= 2,
                    AutoSize = true,
                    Margin = new Padding(0, 4, 0, 0)
                };
                panelHoraire.Controls.Add(checkBoxFerie);

                // Ajouter le panel au FlowLayoutPanel principal
                flpHoraire.Controls.Add(panelHoraire);

            }
            CreerBoutonsPourChaqueLigne();
            if (_horaires.Count == 0)
            {
                flpHoraire.Controls.Clear();

                // Vérifier plus précisément si un label existe déjà
                var existingLabel = flpHoraire.Controls.OfType<Label>()
                                      .FirstOrDefault(l => l.Name == "lblAucunHoraire");

                if (existingLabel == null)
                {
                    Label lblAucunHoraire = new Label()
                    {
                        Name = "lblAucunHoraire",
                        Text = "Aucun horaire disponible pour cette ligne et cet arrêt.",
                        AutoSize = true,
                        ForeColor = Color.Red,
                        Location = new Point(20, 20)
                    };
                    flpHoraire.Controls.Add(lblAucunHoraire);
                }
            }
        }

        private void AjoutPlus()
        {
            if (_boutonPlus != null)
            {
                _boutonPlus.Dispose();
            }
            _y = 304 + _horaires.Count * 40; // Position verticale du plus (à la fin de tous les autres poubelles)
            _boutonPlus = new PictureBox();
            _boutonPlus.Image = Properties.Resources.plus;
            _boutonPlus.Size = new Size(30, 30);
            _boutonPlus.Location = new Point(788, _y); // Coordonnée du Plus
            _boutonPlus.Tag = tagMax;
            _boutonPlus.SizeMode = PictureBoxSizeMode.Zoom; // Pour que l'image s'adapte au bouton
            _boutonPlus.Click += BtnPlus_Click;
            this.Controls.Add(_boutonPlus); // Utilisation de 'this' pour accéder à l'instance actuelle
            _boutonPlus.BringToFront(); // Pour qu’il soit visible au-dessus des autres
        }
        

        private void BtnPlus_Click(object sender, EventArgs e)
        {

            if (_horaires.Count == 0)
                flpHoraire.Controls.Clear();
            
            // Panel pour regrouper les éléments d'un horaire
            FlowLayoutPanel panelHoraire = new FlowLayoutPanel()
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Padding = new Padding(5, 0, 5, 0),
                Margin = new Padding(0, 5, 0, 5) // Espacement vertical entre chaque ligne
            };

            // TextBox pour l'horaire
            TextBox tbHoraire = new TextBox()
            {
                Text = "",
                Height = 24,
                Margin = new Padding(0, 2, 10, 0)
            };
            panelHoraire.Controls.Add(tbHoraire);

            // Checkbox jour de semaine
            CheckBox checkBoxSemaine = new CheckBox()
            {
                Text = "Jour de la semaine",
                Checked = false,
                AutoSize = true,
                Margin = new Padding(0, 4, 20, 0)
            };
            panelHoraire.Controls.Add(checkBoxSemaine);

            // Checkbox jour férié
            CheckBox checkBoxFerie = new CheckBox()
            {
                Text = "Jour férié et week-end",
                Checked = false,
                AutoSize = true,
                Margin = new Padding(0, 4, 0, 0)
            };
            panelHoraire.Controls.Add(checkBoxFerie);

            // Ajouter le panel au FlowLayoutPanel principal
            flpHoraire.Controls.Add(panelHoraire);
            Horaire hCreate = new Horaire(null, 0, 0, 0);
            
            _horaires.Add(hCreate); // Ajoute un nouvel horaire vide à la liste
            _semaine.Add(0); // Ajoute un jour de semaine par défaut (0)
            //On actualise les bouton supprimer et Plus
            CreerBoutonsPourChaqueLigne();
        }
    }
}
