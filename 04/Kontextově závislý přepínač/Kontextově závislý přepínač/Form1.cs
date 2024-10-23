using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontextově_závislý_přepínač
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void políčkoSleva_CheckedChanged(object sender, EventArgs e)
        {
            přepínačDruhSlevy.Enabled = políčkoSleva.Checked;
        }
    }
}
