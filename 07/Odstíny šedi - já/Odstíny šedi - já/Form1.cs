using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odstíny_šedi___já
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

            try
            {
                int odstín = Convert.ToInt32(poleOdstín.Text);
                int R = odstín;
                int G = odstín;
                int B = odstín;
                Color šedá = Color.FromArgb(R, G, B);
                Pen pero = new Pen(šedá, 10);
                kp.DrawEllipse(pero, 10, 10, 176, 176);
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
