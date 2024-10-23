using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schovej_jméno
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoSchovej_Click(object sender, EventArgs e)
        {
            poleJméno.UseSystemPasswordChar = true;
            poleJméno.Enabled = false;
            tlačítkoSchovej.Enabled = false;
            tlačítkoOdkryj.Enabled = true;
        }

        private void tlačítkoOdkryj_Click(object sender, EventArgs e)
        {
            poleJméno.UseSystemPasswordChar = false;
            poleJméno.Enabled = true;
            tlačítkoOdkryj.Enabled = false;
            tlačítkoSchovej.Enabled = true;
        }
    }
}
