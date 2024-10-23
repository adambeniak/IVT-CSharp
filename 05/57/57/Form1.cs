using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _57
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoProveď_Click(object sender, EventArgs e)
        {
            int číslo;
            číslo = 57;
            poleČíslo.Text = Convert.ToString(číslo);
        }
    }
}
