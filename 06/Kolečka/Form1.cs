using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kolečka
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

            // Kolečka
            kp.DrawEllipse(Pens.Red,    40, 40, 20, 20);
            kp.DrawEllipse(Pens.Yellow, 40, 80, 20, 20);
            kp.DrawEllipse(Pens.Yellow, 80, 40, 20, 20);
            kp.DrawEllipse(Pens.Red,    80, 80, 20, 20);

            // Spojovací čáry
            kp.DrawLine(Pens.Black, 50, 60, 50, 80);
            kp.DrawLine(Pens.Black, 60, 50, 80, 50);
            kp.DrawLine(Pens.Black, 90, 60, 90, 80);
            kp.DrawLine(Pens.Black, 60, 90, 80, 90);
        }
    }
}