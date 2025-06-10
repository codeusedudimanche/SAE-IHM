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
    public partial class ModifierHoraire : Form
    {
        private List<Horaire> _horaires;
        private AdminModifier _adminModifier;
        private List<int> _semaine;
        public ModifierHoraire(AdminModifier admnModifier)
        {
            InitializeComponent();
            cbLigne.DataSource = BD.GetLigne().MesLigne;
            _adminModifier = admnModifier;
        }

        private void cbLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbArret.DataSource = BD.GetArretDuneLigne(((Ligne)cbLigne.SelectedItem).NLigne).MesArret;
        }

        private void cbArret_SelectedIndexChanged(object sender, EventArgs e)
        {
            // On vide le panel des horaires
            flpHoraire.Controls.Clear();
            int nombreHoraire = cbArret.Items.Count;
            Ligne ligne = ((Ligne)cbLigne.SelectedItem);
            Arret arret = ((Arret)cbArret.SelectedItem);

            // On récupère les horaires de la ligne et de l'arrêt sélectionnés
            (List<Horaire> h, List<int> Semaine) retour = BD.GetHoraireLigneArret(ligne.NLigne, arret.Id);
            _horaires = retour.h;
            _semaine = retour.Semaine;
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
                    Text = _horaires[i].Heure.ToString(@"hh\:mm"),
                    Height = 24,
                    Margin = new Padding(0, 2, 10, 0)
                };
                panelHoraire.Controls.Add(tbHoraire);

                // Checkbox jour de semaine
                CheckBox checkBoxSemaine = new CheckBox()
                {
                    Text = "Jour de la semaine",
                    Checked = true,
                    AutoSize = true,
                    Margin = new Padding(0, 4, 20, 0)
                };
                panelHoraire.Controls.Add(checkBoxSemaine);

                // Checkbox jour férié
                CheckBox checkBoxFerie = new CheckBox()
                {
                    Text = "Jour férié et week-end",
                    Checked = true,
                    AutoSize = true,
                    Margin = new Padding(0, 4, 0, 0)
                };
                panelHoraire.Controls.Add(checkBoxFerie);

                // Ajouter le panel au FlowLayoutPanel principal
                flpHoraire.Controls.Add(panelHoraire);

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
    }
}
