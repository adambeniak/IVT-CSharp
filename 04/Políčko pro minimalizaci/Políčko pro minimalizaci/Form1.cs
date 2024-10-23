using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Políčko_pro_minimalizaci
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void políčkoDovol_CheckedChanged(object sender, EventArgs e)
        {
            MinimizeBox = políčkoDovol.Checked;
        }
    }
}
