using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tlustá_čára___já
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
                int tloušťka = Convert.ToInt32(poleTloušťka.Text);
                Pen pero = new Pen(Color.Red, tloušťka);
                kp.DrawLine(pero, 15, 15, 228, 228);
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
