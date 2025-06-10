using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base;
using MySql.Data.MySqlClient;
using static System.Net.WebRequestMethods;

namespace SAE_IHM
{
    public partial class ConsulterLigne : Form
    {
        public ConsulterLigne()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelCarte_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            {
                string numligne = cbLigne.SelectedItem!.ToString().Replace("Ligne ", "");
                string url;
                url = "https://transitapp.com/fr/region/tulsa/tulsa-transit/bus-" + numligne;
                if (numligne == 700.ToString())
                {
                    url = "https://transitapp.com/fr/region/tulsa/tulsa-transit/aero-700";
                }

                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            };
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void ConsulterLigne_Load(object sender, EventArgs e)
        {

        }

        private void lblNomLigne_Click(object sender, EventArgs e)
        {

        }

        private void ConsulterLigne_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0]!.Show();
        }

        private void cbLigne_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            panelCarte.Visible = true;
            lblNomLigne.Text = cbLigne.SelectedItem!.ToString();
        }
    }
}
