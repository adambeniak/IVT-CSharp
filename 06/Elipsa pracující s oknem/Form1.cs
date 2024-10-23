using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Elipsa_pracující_s_oknem
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
            int šířka = ClientSize.Width;
            int výška = ClientSize.Height;

            kp.DrawEllipse(Pens.Tomato, 0, 0, šířka-1, výška-1);
        }

        private void oknoProgramu_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}