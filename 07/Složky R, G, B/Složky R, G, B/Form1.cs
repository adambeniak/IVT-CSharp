using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Složky_R__G__B
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoZpráva_Click(object sender, EventArgs e)
        {
            int R = BackColor.R;
            string textR = Convert.ToString(R);
            int G = BackColor.G;
            string textG = Convert.ToString(G);
            int B = BackColor.B;
            string textB = Convert.ToString(B);
            string zpráva = "R = " + textR + ", G = " + textG + ", B = " + textB;
            MessageBox.Show(zpráva);
        }
    }
}
