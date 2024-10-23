using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Výměna_stavu_ano_ne
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoVyměň_Click(object sender, EventArgs e)
        {
            bool skrýš = políčko2.Checked;
            políčko2.Checked = políčko1.Checked;
            políčko1.Checked = skrýš;
        }
    }
}
