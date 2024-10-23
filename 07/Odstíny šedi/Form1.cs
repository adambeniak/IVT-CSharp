using System;
using System.Drawing;
using System.Windows.Forms;

namespace Odstíny_šedi
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoPřekresli_Click(object sender, EventArgs e)
        {
            panel.Refresh();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;

            try
            {
                int odstín = Convert.ToInt32(poleOdstín.Text);
                int R = odstín;
                int G = odstín;
                int B = odstín;
                Color šedá = Color.FromArgb(R, G, B);
                Pen pero = new Pen(šedá, 3);
                kp.DrawEllipse(pero, 10, 10, 80, 80);
            }
            catch
            {
            }

        }
    }
}