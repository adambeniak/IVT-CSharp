using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tečka_na_zadané_pozici
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
                int x = Convert.ToInt32(poleX.Text);
                int y = Convert.ToInt32(poleY.Text);
                kp.FillRectangle(Brushes.Black, x, y, 1, 1);
                            }
            catch
            {
            }
        }

        private void poleXY_TextChanged(object sender, EventArgs e)
        {
            panel.Refresh();
        }
    }
}