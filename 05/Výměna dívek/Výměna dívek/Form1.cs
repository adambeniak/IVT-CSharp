using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Výměna_dívek
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoVyměň_Click(object sender, EventArgs e)
        {
            string skrýš = pole2.Text;
            pole2.Text = pole1.Text;
            pole1.Text = skrýš;
        }
    }
}
