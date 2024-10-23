using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Výčet_TextAlign___já
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoDoleva_Click(object sender, EventArgs e)
        {
            poleSTextem.TextAlign = HorizontalAlignment.Left;
        }

        private void tlačítkoNaStřed_Click(object sender, EventArgs e)
        {
            poleSTextem.TextAlign = HorizontalAlignment.Center;
        }

        private void tlačítkoDoprava_Click(object sender, EventArgs e)
        {
            poleSTextem.TextAlign = HorizontalAlignment.Right;
        }
    }
}
