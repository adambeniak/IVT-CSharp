using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Výsledek_utkání
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoZobraz_Click(object sender, EventArgs e)
        {
            string zpráva = "Utkání Sparta - Baník skončilo " + poleSparta.Text + ":" + poleBaník.Text + ".";
            MessageBox.Show(zpráva);
        }
    }
}
