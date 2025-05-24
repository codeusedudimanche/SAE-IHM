using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_IHM
{ 
    public partial class AdminSupp : Form
    {
        public AdminSupp()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("fond.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void AdminSupp_Load(object sender, EventArgs e)
        {

        }
    }
}
