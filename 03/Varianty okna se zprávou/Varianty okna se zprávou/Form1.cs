using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Varianty_okna_se_zprávou
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítko1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stisk tlačítka 1.", "CHYBA!");
        }

        private void tlačítko2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stisk tlačítka 2.", "", MessageBoxButtons.YesNoCancel);
        }

        private void tlačítko3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stisk tlačítka 3.", "OTÁZKA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
    }
}
