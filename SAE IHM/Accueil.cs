using System.Windows.Forms;
using System.Windows.Forms;
using Base;
using static System.Windows.Forms.DataFormats;

namespace SAE_IHM
{
    public partial class Accueil : Form
    {

        public Accueil()
        {
            InitializeComponent();
            BD.Connexion();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            Titre = new Label();
            btnConsulterCarte = new Button();
            btnConfigTrajet = new Button();
            btnEspaceBillets = new Button();
            pnlBackround = new Panel();
            pbConnexion = new PictureBox();
            pbMyTulsa = new PictureBox();
            pnlBackround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbConnexion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMyTulsa).BeginInit();
            SuspendLayout();
            // 
            // Titre
            // 
            Titre.AutoSize = true;
            Titre.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titre.Location = new Point(86, 30);
            Titre.Name = "Titre";
            Titre.Size = new Size(238, 67);
            Titre.TabIndex = 0;
            Titre.Text = "Tulsa Bus";
            Titre.Click += Titre_Click;
            // 
            // btnConsulterCarte
            // 
            btnConsulterCarte.Location = new Point(101, 192);
            btnConsulterCarte.Name = "btnConsulterCarte";
            btnConsulterCarte.Size = new Size(204, 29);
            btnConsulterCarte.TabIndex = 1;
            btnConsulterCarte.Tag = "";
            btnConsulterCarte.Text = "Consulter la carte";
            btnConsulterCarte.UseVisualStyleBackColor = true;
            btnConsulterCarte.Click += button1_Click;
            // 
            // btnConfigTrajet
            // 
            btnConfigTrajet.Location = new Point(101, 240);
            btnConfigTrajet.Name = "btnConfigTrajet";
            btnConfigTrajet.Size = new Size(204, 29);
            btnConfigTrajet.TabIndex = 2;
            btnConfigTrajet.Tag = "";
            btnConfigTrajet.Text = "Configurer son trajet";
            btnConfigTrajet.UseVisualStyleBackColor = true;
            btnConfigTrajet.Click += button1_Click_1;
            // 
            // btnEspaceBillets
            // 
            btnEspaceBillets.Location = new Point(101, 291);
            btnEspaceBillets.Name = "btnEspaceBillets";
            btnEspaceBillets.Size = new Size(204, 29);
            btnEspaceBillets.TabIndex = 3;
            btnEspaceBillets.Tag = "";
            btnEspaceBillets.Text = "Espace Billets";
            btnEspaceBillets.UseVisualStyleBackColor = true;
            btnEspaceBillets.Click += button1_Click_2;
            // 
            // pnlBackround
            // 
            pnlBackround.BackColor = SystemColors.ControlLightLight;
            pnlBackround.Controls.Add(pbConnexion);
            pnlBackround.Controls.Add(pbMyTulsa);
            pnlBackround.Controls.Add(Titre);
            pnlBackround.Controls.Add(btnEspaceBillets);
            pnlBackround.Controls.Add(btnConfigTrajet);
            pnlBackround.Controls.Add(btnConsulterCarte);
            pnlBackround.Location = new Point(400, 200);
            pnlBackround.Name = "pnlBackround";
            pnlBackround.Size = new Size(402, 393);
            pnlBackround.TabIndex = 4;
            pnlBackround.Paint += panel1_Paint_1;
            // 
            // pbConnexion
            // 
            pbConnexion.Image = (Image)resources.GetObject("pbConnexion.Image");
            pbConnexion.Location = new Point(27, 331);
            pbConnexion.Name = "pbConnexion";
            pbConnexion.Size = new Size(42, 44);
            pbConnexion.SizeMode = PictureBoxSizeMode.Zoom;
            pbConnexion.TabIndex = 6;
            pbConnexion.TabStop = false;
            pbConnexion.Click += pictureBoxConnexion_Click;
            // 
            // pbMyTulsa
            // 
            pbMyTulsa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbMyTulsa.Image = Properties.Resources.mytulsa;
            pbMyTulsa.Location = new Point(33, 20);
            pbMyTulsa.Name = "pbMyTulsa";
            pbMyTulsa.Size = new Size(339, 155);
            pbMyTulsa.SizeMode = PictureBoxSizeMode.Zoom;
            pbMyTulsa.TabIndex = 5;
            pbMyTulsa.TabStop = false;
            pbMyTulsa.Click += pictureBox1_Click_1;
            // 
            // Accueil
            // 
            BackColor = Color.FromArgb(0, 64, 0);
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(pnlBackround);
            Name = "Accueil";
            Text = "Accueil - MyTulsa";
            Load += accueil_Load;
            pnlBackround.ResumeLayout(false);
            pnlBackround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbConnexion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMyTulsa).EndInit();
            ResumeLayout(false);
        }

        private Label Titre;

        private void Titre_Click(object sender, EventArgs e)
        {

        }

        private Button btnConsulterCarte;

        private void button1_Click(object sender, EventArgs e)
        {
            Consultercarte Formconsulte = new Consultercarte();
            Formconsulte.Show();
            this.Hide();
        }

        private Button btnConfigTrajet;

        private void button1_Click_1(object sender, EventArgs e)
        {
            RechercherTrajet FormConfigTrajet = new RechercherTrajet();
            FormConfigTrajet.Show();
            this.Hide();
        }

        private Button btnEspaceBillets;

        private void button1_Click_2(object sender, EventArgs e)
        {
            EspaceBillets FormEspaceBillet = new EspaceBillets();
            FormEspaceBillet.Show();
            this.Hide();
        }

        private Panel pnlBackround;

        private void accueil_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private PictureBox pbMyTulsa;

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }


        private void pictureBoxConnexion_Click(object sender, EventArgs e)
        {
            AccesAdmin accesAdmin = new AccesAdmin();
            accesAdmin.Show();
            this.Hide();
        }

        private PictureBox pbConnexion;

        private void btnAdminAjout_Click(object sender, EventArgs e)
        {

        }

        private void AdminRaccourci_Click(object sender, EventArgs e)
        {
            EspaceAdmin espaceAdmin = new EspaceAdmin();
            espaceAdmin.Show();
            this.Hide();
        }
    }
}
