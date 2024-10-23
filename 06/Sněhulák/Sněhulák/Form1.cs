using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sněhulák
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

            kp.DrawEllipse(Pens.Blue, 260, 100,  80,  80);
            kp.DrawEllipse(Pens.Blue, 240, 180, 120, 120);
            kp.DrawEllipse(Pens.Blue, 220, 300, 160, 160);

            kp.DrawEllipse(Pens.Blue, 180, 220, 40, 40);
            kp.DrawEllipse(Pens.Blue, 380, 220, 40, 40);

            kp.DrawLine(Pens.Black, 220, 240, 240, 240);
            kp.DrawLine(Pens.Black, 360, 240, 380, 240);

            kp.DrawLine(Pens.Red, 240, 100, 360, 100);
            kp.DrawLine(Pens.Red, 240, 100, 300,  50);
            kp.DrawLine(Pens.Red, 300,  50, 360, 100);
        }

        private void oknoProgramu_Load(object sender, EventArgs e)
        {

        }
    }
}
