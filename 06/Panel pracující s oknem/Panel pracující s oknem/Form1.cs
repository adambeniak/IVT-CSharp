using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel_pracující_s_oknem
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;

            int šířka = panel1.ClientSize.Width;
            int výška = panel1.ClientSize.Height;

            kp.DrawEllipse(Pens.Tomato, 0, 0, šířka - 1, výška - 1);

        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
    }
}
