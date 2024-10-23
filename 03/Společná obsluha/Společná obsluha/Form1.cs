using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Společná_obsluha
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítka_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Myš vstoupila nad tlačítko");
        }
    }
}
