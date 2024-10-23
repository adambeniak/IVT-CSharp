using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jiné_zaškrtávání
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoZaškrtni_Click(object sender, EventArgs e)
        {
            políčkoJsemSpokojen.Checked = true;
        }

        private void tlačítkoZruš_Click(object sender, EventArgs e)
        {
            políčkoJsemSpokojen.Checked = false;
        }
    }
}
