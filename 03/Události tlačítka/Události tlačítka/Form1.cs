using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Události_tlačítka
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoUkončit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tlačítka_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Ukazatel myši se zastavil nad tlačítkem.");
        }

        private void tlačítkoZobrazit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vítá vás program s tlačítky.");
        }
    }
}
