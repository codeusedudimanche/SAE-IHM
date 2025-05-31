using System.Windows.Forms;
using Base;
using static System.Windows.Forms.DataFormats;

namespace SAE_IHM
{
    public partial class accueil : Form
    {
        public accueil() 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accueil));
            Titre = new Label();
            btnConsulterCarte = new Button();
            btnConfigTrajet = new Button();
            btnEspaceBillets = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Titre);
            panel1.Controls.Add(btnEspaceBillets);
            panel1.Controls.Add(btnConfigTrajet);
            panel1.Controls.Add(btnConsulterCarte);
            panel1.Location = new Point(400, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 393);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 331);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBoxConnexion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.mytulsa;
            pictureBox1.Location = new Point(33, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(339, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // accueil
            // 
            BackColor = Color.FromArgb(0, 64, 0);
            BackgroundImage = Properties.Resources.Fond_d_application;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Name = "accueil";
            Load += accueil_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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

        private Panel panel1;

        private void accueil_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private PictureBox pictureBox1;

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }


        private void pictureBoxConnexion_Click(object sender, EventArgs e)
        {
            AccesAdmin accesAdmin = new AccesAdmin();
            accesAdmin.Show();
            this.Hide();
        }

        private PictureBox pictureBox2;
    }
}
