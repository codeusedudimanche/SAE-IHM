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
    public partial class RechercherTrajet : Form
    {
        public RechercherTrajet()
        {
            InitializeComponent();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void RechercherTrajet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0]!.Show();
        }

        private void pnlBackround_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
