using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base;
using Org.BouncyCastle.Tls;

namespace SAE_IHM.Admin.Modifier
{
    public partial class ModifierHoraire : Form
    {
        private bool changement = false;
        private List<Horaire> _horaires;
        private List<Horaire> _horairesBackup;
        private List<int> _semaineBackup;
        private List<int> _semaine;
        private List<PictureBox> boutonsSupprimer = new List<PictureBox>();
        private int _y = 304; // Position verticale initiale pour les boutons
        private PictureBox _boutonPlus = null;
        private int tagMax = 0;
        private AdminModifier _adminModifier;
        public ModifierHoraire(AdminModifier admnModifier)
        {
            InitializeComponent();
            cbLigne.DataSource = BD.GetLigne().MesLigne;

            _adminModifier = admnModifier;
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
            //tagMax = _horaires.Count;
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
            if (cbLigne.SelectedItem == null)
            {
                MessageBox.Show("Veuillez selectionner une ligne valide.");
                return;
            }
            if (cbArret.SelectedItem == null)
            {
                MessageBox.Show("Veuillez selectionner un arrêt valide.");
                return;
            }
            (List<Horaire> h, List<int> Semaine) r = BD.GetHoraireLigneArret(ligne.NLigne, arret.Id);

            ligne = (Ligne)cbLigne.SelectedItem;

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
                tbHoraire.TextChanged += txtHorraire_TextChanged; // Ajout de l'événement TextChanged pour vérifier les modifications
                tbHoraire.Tag = _horaires[i];
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
            tagMax = _horaires.Count;
            VerifModif(); // Vérifie si des modifications ont été faites

        }
        private void txtHorraire_TextChanged(object sender, EventArgs e)
        {
            if (changement)
                return;

            if (sender is TextBox txt && txt.Tag is Horaire horaire)
            {
                string input = txt.Text;

                // Ne tente de parser que si le texte correspond à un format complet
                if (Regex.IsMatch(input, @"^\d{1,2}:\d{1,2}$"))
                {
                    if (TimeSpan.TryParse(input, out TimeSpan heure))
                    {
                        horaire.Heure = heure;
                    }
                    else
                    {
                        AfficherErreur(txt, horaire);
                    }
                }
                else if (input.Length >= 5) // Si la saisie est complète mais non valide
                {
                    AfficherErreur(txt, horaire);
                }
                else
                {
                    horaire.Heure = null; // En cours de saisie
                }
            }

            VerifModif();
        }

        private void AfficherErreur(TextBox txt, Horaire horaire)
        {
            changement = true;
            txt.Text = string.Empty;
            horaire.Heure = null;
            MessageBox.Show("Ce n'est pas un horaire valide. Veuillez entrer un horaire au format HH:mm.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            changement = false;
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
            VerifModif(); // Vérifie si des modifications ont été faites
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
            Ligne ligneSelect = (Ligne)cbLigne.SelectedItem;
            Arret arretSelect = (Arret)cbArret.SelectedItem;
            if (ligneSelect == null || arretSelect == null)
            {
                MessageBox.Show("Veuillez sélectionner une ligne et un arrêt valides.");
                return;
            }
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
                Margin = new Padding(0, 2, 10, 0),

            };

            tbHoraire.TextChanged += txtHorraire_TextChanged; // Ajout de l'événement TextChanged pour vérifier les modifications



            panelHoraire.Controls.Add(tbHoraire);

            // Checkbox jour de semaine
            CheckBox checkBoxSemaine = new CheckBox()
            {
                Text = "Jour de la semaine",
                Checked = false,
                AutoSize = true,
                Margin = new Padding(0, 4, 20, 0),
                Tag = tagMax // On ajoute le tag pour savoir quel horaire on modifie
            };
            checkBoxSemaine.CheckedChanged += checkBoxSemaine_CheckedChanged; // Ajout de l'événement CheckedChanged pour vérifier les modifications
            panelHoraire.Controls.Add(checkBoxSemaine);

            // Checkbox jour férié
            CheckBox checkBoxFerie = new CheckBox()
            {
                Text = "Jour férié et week-end",
                Checked = false,
                AutoSize = true,
                Margin = new Padding(0, 4, 0, 0),
                Tag = tagMax // On ajoute le tag pour savoir quel horaire on modifie
            };
            checkBoxFerie.CheckedChanged += checkBoxFerie_CheckedChanged; // Ajout de l'événement CheckedChanged pour vérifier les modifications
            panelHoraire.Controls.Add(checkBoxFerie);

            // Ajouter le panel au FlowLayoutPanel principal
            flpHoraire.Controls.Add(panelHoraire);

            Horaire hCreate = new Horaire(null, 0, ligneSelect.NLigne, arretSelect.Id);

            _horaires.Add(hCreate); // Ajoute un nouvel horaire vide à la liste
            _semaine.Add(0); // Ajoute un jour de semaine par défaut (0)
            //On actualise les bouton supprimer et Plus
            CreerBoutonsPourChaqueLigne();
            if (tagMax >= 0 && tagMax < _horaires.Count)
            {
                tbHoraire.Tag = _horaires[tagMax];
            }
            else
            {
                // Handle the error or set a default value  
                tbHoraire.Tag = null;
            }
            VerifModif(); // Vérifie si des modifications ont été faites
        }

        private void checkBoxSemaine_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox cb && cb.Tag is int id)
            {

                if (cb.Checked)
                {
                    _semaine[id] += 1;
                    _horaires[id].JourSemaine += 1;
                }
                else
                {
                    if (_semaine[id] > 0)
                    {
                        _semaine[id] -= 1;
                        _horaires[id].JourSemaine -= 1;
                    }
                }
            }

            VerifModif();
        }


        private void checkBoxFerie_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox cb && cb.Tag is int id)
            {
                if (cb.Checked)
                {
                    _semaine[id] += 2;
                    _horaires[id].JourSemaine = (_horaires[id].JourSemaine + 2); // Mise à jour de l’objet Horaire
                }
                else
                {
                    if (_semaine[id] >= 2)
                    {
                        _semaine[id] -= 2;
                        _horaires[id].JourSemaine = (_horaires[id].JourSemaine - 2); // Mise à jour de l’objet Horaire
                    }
                }
            }

            VerifModif();
        }

        private bool areHoraireEgal(List<Horaire> h1, List<Horaire> h2)
        {
            if (h1.Count != h2.Count)
                return false;

            var h2Copy = new List<Horaire>(h2);

            foreach (var horaire in h1)
            {
                if (!h2Copy.Remove(horaire)) // Supprime l'élément correspondant si trouvé
                    return false;
            }

            return true;
        }



        private void VerifModif()
        {
            if (!areHoraireEgal(_horaires, _horairesBackup))
            {
                btnValider.Enabled = true;
            }
            else
            {
                btnValider.Enabled = false;
            }
        }
        private List<Horaire> GetHorairesASupprimer(List<Horaire> liste1, List<Horaire> liste2)
        {
            var horairesASupprimer = new List<Horaire>();
            var copieListe2 = new List<Horaire>(liste2);

            foreach (var horaire in liste1)
            {
                if (!copieListe2.Remove(horaire))
                {
                    // Si l'horaire n'est pas trouvé dans liste2, il doit être supprimé
                    horairesASupprimer.Add(horaire);
                }
            }

            return horairesASupprimer;
        }
        private List<Horaire> GetHorairesAAjouter(List<Horaire> backup, List<Horaire> actuelle)
        {
            var horairesAAjouter = new List<Horaire>();
            var copieBackup = new List<Horaire>(backup);

            foreach (var horaire in actuelle)
            {
                if (!copieBackup.Remove(horaire))
                {
                    // L'horaire est dans la liste actuelle mais pas dans la backup, donc à ajouter
                    horairesAAjouter.Add(horaire);
                }
            }

            return horairesAAjouter;
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            List<Horaire> _horaireASupprimer = GetHorairesASupprimer(_horairesBackup, _horaires);
            List<Horaire> _horaireAAjouter = GetHorairesAAjouter(_horairesBackup, _horaires);

            if (DialogResult.Yes == MessageBox.Show("Êtes-vous sûr de vouloir modifier ces horaires ?", "Confirmation", MessageBoxButtons.YesNo))
            {
                foreach (Horaire h in _horaireASupprimer)
                {
                    if (h.Heure.HasValue)
                    {
                        BD.SupprimerHoraire(h.NLigne, h.NArret, h.JourSemaine, h.Heure.Value);

                    }

                }
                if (_horaireASupprimer.Count > 0)
                {
                    MessageBox.Show("Horaire supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                foreach (Horaire h in _horaireAAjouter)
                {
                    if (h.Heure.HasValue)
                    {
                        if (BD.AjoutHoraire(h.NLigne, h.NArret, h.JourSemaine, h.Heure.Value))
                        {

                        }
                        else
                        {
                            MessageBox.Show($"Erreur lors de l'ajout de l'horaire : {h.Heure.Value.ToString(@"hh\:mm")} pour la ligne {h.NLigne} à l'arrêt {h.NArret}.");

                        }
                    }
                }
                if (_horaireAAjouter.Count > 0)
                {
                    MessageBox.Show("Horaire ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void flpHoraire_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
