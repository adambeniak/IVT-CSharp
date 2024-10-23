using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sčítačka
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoRovnáSe_Click(object sender, EventArgs e)
        {
            poleVýsledek.Text = poleČíslo1.Text + poleČíslo2.Text;
        }
    }
}
