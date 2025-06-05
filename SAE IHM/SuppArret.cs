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

namespace SAE_IHM
{
    public partial class SuppArret : Form
    {
        private EspaceAdmin parentForm;
        public SuppArret(EspaceAdmin parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void SuppArret_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm.Show();
        }
    }
}
