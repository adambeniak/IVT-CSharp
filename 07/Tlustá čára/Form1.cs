using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tlustá_čára
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
                int tloušťka = Convert.ToInt32(poleTloušťka.Text);
                Pen pero = new Pen(Color.CornflowerBlue, tloušťka);
                kp.DrawLine(pero, 10, 10, 90, 90);
            }
            catch
            {
            }

        }
    }
}