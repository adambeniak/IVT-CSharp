using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obdélníčky
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

            kp.FillRectangle(Brushes.Turquoise, 100, 100, 100, 50);
            kp.FillRectangle(Brushes.Turquoise, 100, 200, 100, 50);
            kp.FillRectangle(Brushes.Turquoise, 300, 200, 100, 50);

            kp.DrawLine(Pens.Red, 200, 150, 200, 200);
            kp.DrawLine(Pens.Red, 200, 200, 300, 200);
            kp.DrawLine(Pens.Green, 200, 150, 300, 200);
        }
    }
}
