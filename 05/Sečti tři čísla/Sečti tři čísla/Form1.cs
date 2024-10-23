using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sečti_tři_čísla
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoSečti_Click(object sender, EventArgs e)
        {
            int číslo1 = Convert.ToInt32(poleČíslo1.Text);
            int číslo2 = Convert.ToInt32(poleČíslo2.Text);
            int číslo3 = Convert.ToInt32(poleČíslo3.Text);

            int výsledek = číslo1 + číslo2 + číslo3;

            poleVýsledek.Text = Convert.ToString(výsledek);
        }
    }
}
