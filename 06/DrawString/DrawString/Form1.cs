using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawString
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void oknoProgramu_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;

            kp.DrawString("Abčýď KLM!%", new Font("Arial", 20), Brushes.Black, 100, 50);

            kp.DrawString("ABCabc", new Font("Courier", 22), Brushes.Red, 200, 100);
        }
    }
}
