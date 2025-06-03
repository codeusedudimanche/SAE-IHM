using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Base;

namespace SAE_IHM
{
    public partial class SuppLigne : Form
    {
        private EspaceAdmin parentForm;
        public SuppLigne(EspaceAdmin parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }
    }
}
