﻿using System;
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
    public partial class Consultercarte : Form
    {
        public Consultercarte()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Consultercarte_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consultercarte_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Consultercarte_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0]!.Show();
        }
    }
}
