using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nad_prvkem_či_mimo
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void prvkyKlikni_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Myš stisknuta nad ovládacím prvkem.");
        }

        private void oknoProgramu_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Myš stisknuta mimo ovládací prvky.");
        }
    }
}
