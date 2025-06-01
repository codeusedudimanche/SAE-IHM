using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SAE_IHM
{
    public partial class EspaceBillets_CB : Form
    {

        public EspaceBillets_CB()
        {
            InitializeComponent();

            btnValider.Enabled = false;

            txtNumeroCarte.TextChanged += ChampModifie;
            txtDateExpiration.TextChanged += ChampModifie;
            txtCodeSecurite.TextChanged += ChampModifie;
            btnValider.Click += btnValider_Click;
        }


        private void ChampModifie(object sender, EventArgs e)
        {
            btnValider.Enabled = TousLesChampsValides();
        }

        private bool TousLesChampsValides()
        {
            // Numéro de carte : 16 chiffres (espaces autorisés)
            bool numeroCarteValide = Regex.IsMatch(txtNumeroCarte.Text.Replace(" ", ""), @"^\d{16}$");

            // Date expiration : format MM/AA
            bool dateValide = Regex.IsMatch(txtDateExpiration.Text, @"^(0[1-9]|1[0-2])\/\d{2}$");

            // Code de sécurité : 2 à 3 chiffres
            bool codeValide = Regex.IsMatch(txtCodeSecurite.Text, @"^\d{2,3}$");

            return numeroCarteValide && dateValide && codeValide;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paiement accepté", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form accueil = Application.OpenForms["accueil"];
            accueil?.Show();
            this.Close();
        }

        private void EspaceBillets_CB_Load(object sender, EventArgs e)
        {

        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {

        }
    }
}
