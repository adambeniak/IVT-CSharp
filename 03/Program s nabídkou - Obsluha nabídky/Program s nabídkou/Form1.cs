using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_s_nabídkou
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void podnabídkaNový_Click(object sender, EventArgs e)
        {
            Form dlg1 = new Form();
            dlg1.ShowDialog();
        }

        private void podnabídkaOtevřít_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uživatel vybral nabídku Soubor > Otevřít...", "Otevřít");
        }

        private void podnabídkaKonec_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
