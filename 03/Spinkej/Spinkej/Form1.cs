using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spinkej
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoSpi_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(5000);
        }

        private void tlačítkoTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program zrovna nespí.");
        }
    }
}
