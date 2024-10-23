using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schovej_program
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoSchovejSe_Click(object sender, EventArgs e)
        {
            Hide();
            System.Threading.Thread.Sleep(1000);
            Show();
        }
    }
}
