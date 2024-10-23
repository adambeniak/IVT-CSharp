using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Čáry_z_rohů
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
            int šířka = panel.ClientSize.Width;
            int výška = panel.ClientSize.Height;

            try
            {
                int x = Convert.ToInt32(poleX.Text);
                int y = Convert.ToInt32(poleY.Text);
                kp.DrawLine(Pens.CornflowerBlue, 0, 0, x, y);       // Z levého horního
                kp.DrawLine(Pens.CornflowerBlue, 0, výška-1, x, y); // Z levého dolního
                kp.DrawLine(Pens.CornflowerBlue, šířka-1, 0, x, y); // Z pravého horního
                kp.DrawLine(Pens.CornflowerBlue, šířka-1, výška-1, x, y); // Z pravého dolního
            }
            catch
            {
            }
        }

        private void poleXiY_TextChanged(object sender, EventArgs e)
        {
            panel.Refresh();
        }
    }
}