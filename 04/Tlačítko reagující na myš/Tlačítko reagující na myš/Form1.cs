using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tlačítko_reagující_na_myš
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítko_MouseEnter(object sender, EventArgs e)
        {
            tlačítko.BackColor = Color.Green;
        }

        private void tlačítko_MouseLeave(object sender, EventArgs e)
        {
            tlačítko.BackColor = Color.Blue;
        }
    }
}
