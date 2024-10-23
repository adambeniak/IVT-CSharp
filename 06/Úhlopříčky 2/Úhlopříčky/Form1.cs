using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Úhlopříčky
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

            kp.DrawLine(Pens.Black,         0, 0, šířka - 1, výška - 1);
            kp.DrawLine(Pens.Black, šířka - 1, 0,         0, výška - 1);
        }
    }
}
