using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Geometrie_obdélníka
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
            try
            {
                int x1 = Convert.ToInt32(poleX1.Text);
                int y1 = Convert.ToInt32(poleY1.Text);
                int x2 = Convert.ToInt32(poleX2.Text);
                int y2 = Convert.ToInt32(poleY2.Text);
                int šířka = x2 - x1 + 1;
                int výška = y2 - y1 + 1;
                kp.FillRectangle(Brushes.CornflowerBlue, x1, y1, šířka, výška);
            }
            catch
            {
            }
        }

        private void tlačítkoPřekresli_Click(object sender, EventArgs e)
        {
            panel.Refresh();
        }
    }
}