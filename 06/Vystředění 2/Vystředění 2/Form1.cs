using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vystředění_2
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;

            int šířkaPanelu = panel.ClientSize.Width;
            int výškaPanelu = panel.ClientSize.Height;

            int xStředu = šířkaPanelu / 2;
            int yStředu = výškaPanelu / 2;

            int poloměr = 40;
            int xLH = xStředu - poloměr;
            int yLH = yStředu - poloměr;
            int šířka = 2 * poloměr;
            int výška = šířka;

            kp.DrawEllipse(Pens.DarkRed, xLH, yLH, šířka, výška);

        }
    }
}
