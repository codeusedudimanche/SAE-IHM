using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SAE_IHM
{
    public partial class accueil : Form
    {
        public accueil()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("fond.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
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
            Titre = new Label();
            btnConsulterCarte = new Button();
            btnConfigTrajet = new Button();
            btnEspaceBillets = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
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
            btnConsulterCarte.Location = new Point(101, 148);
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
            btnConfigTrajet.Location = new Point(101, 196);
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
            btnEspaceBillets.Location = new Point(101, 247);
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
            panel1.Controls.Add(Titre);
            panel1.Controls.Add(btnEspaceBillets);
            panel1.Controls.Add(btnConfigTrajet);
            panel1.Controls.Add(btnConsulterCarte);
            panel1.Location = new Point(353, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 379);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint_1;
            // 
            // accueil
            // 
            ClientSize = new Size(1038, 507);
            Controls.Add(panel1);
            Name = "accueil";
            Load += accueil_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}
