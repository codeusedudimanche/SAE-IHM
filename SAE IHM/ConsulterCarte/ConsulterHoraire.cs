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
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SAE_IHM
{
    public partial class ConsulterHoraire : Form
    {
        private List<Arret> _listeArret = new List<Arret>();
        public ConsulterHoraire()
        {
            InitializeComponent();
            ChargeLigne();
        }

        private void ChargeLigne()
        {
            string chaineConnexion = "Server=10.1.139.236;Database=basef3;Uid=f3;Pwd=mdp";
            using (var conn = new MySqlConnection(chaineConnexion))
            {
                try
                {
                    conn.Open();
                    string requete = "SELECT N°Ligne FROM Ligne";
                    using (var cmd = new MySqlCommand(requete, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbLigne.Items.Add("Ligne " + reader.GetInt32(0));
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des lignes : " + ex.Message);
                }
            }
        }
        private void ChargeHoraire(int LigneSelectionnee, string ArretSelectionne)
        {
            string chaineConnexion = "Server=10.1.139.236;Database=basef3;Uid=f3;Pwd=mdp";
            using (var conn = new MySqlConnection(chaineConnexion))
            {
                try
                {
                    conn.Open();
                    string requete = "SELECT Horaire FROM Horaire, Arret WHERE " +
                        "Arret.N°Arret = Horaire.N°Arret AND Horaire.N°Ligne= @numligne AND " +
                        "NomArret = @nomarret";

                    using (var cmd = new MySqlCommand(requete, conn))
                    {
                        cmd.Parameters.AddWithValue("@numligne", LigneSelectionnee);
                        cmd.Parameters.AddWithValue("@nomarret", ArretSelectionne);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lstvHoraire.Items.Add(reader.GetTimeSpan(0).ToString());
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des arrêts : " + ex.Message);
                }
            }
        }

        private void ChargeArret(int LigneSelectionnee)
        {
            string chaineConnexion = "Server=10.1.139.236;Database=basef3;Uid=f3;Pwd=mdp";
            using (var conn = new MySqlConnection(chaineConnexion))
            {
                try
                {
                    conn.Open();
                    string requete = "SELECT NomArret FROM Horaire, Arret WHERE Arret.N°Arret = Horaire.N°Arret AND Horaire.N°Ligne=@numLigne";
                    _listeArret = new List<Arret>();
                    using (var cmd = new MySqlCommand(requete, conn))
                    {
                        cmd.Parameters.AddWithValue("@numLigne", LigneSelectionnee);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbArret.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des arrêts : " + ex.Message);
                }
            }
        }

        private void ConsulterHoraire_Load(object sender, EventArgs e)
        {

        }

        private void cbLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNomLigne.Text = cbLigne.Text;
            cbArret.Enabled = true;
            lblNomArrêt.Visible = false;
            lblNomLigne.Visible = false;
            cbArret.Items.Clear();
            lstvHoraire.Items.Clear();

            if (cbLigne.SelectedItem != null)
            {
                string selectedItem = cbLigne.SelectedItem.ToString()!;
                int numeroLigne;
                if (int.TryParse(selectedItem.Replace("Ligne ", ""), out numeroLigne))
                {
                    ChargeArret(numeroLigne);
                }
                else
                {
                    MessageBox.Show("Numéro de ligne invalide.");
                }

            }
        }

        private void cbArret_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNomLigne.Visible = true;
            lblNomArrêt.Visible = true;
            pnlHoraire.Visible = true;
            lstvHoraire.Items.Clear();
            string selectedLigne = cbLigne.SelectedItem!.ToString()!;
            string selectedArret = cbArret.SelectedItem!.ToString()!;
            lblNomLigne.Text = selectedLigne;
            lblNomArrêt.Text = selectedArret;
            if (cbLigne.SelectedItem != null && cbArret.SelectedItem != null)
            {
                if (int.TryParse(selectedLigne.Replace("Ligne ", ""), out int numeroLigne))
                {
                    ChargeHoraire(numeroLigne, selectedArret);
                }
                else
                {
                    MessageBox.Show("Numéro de ligne invalide.");
                }
            }
        }

        private void lblNomArrêt_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0]!.Show();
        }
    }
}
