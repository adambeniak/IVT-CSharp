using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domeček
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

            Pen pero = Pens.Black;

            kp.DrawLine(pero, 100, 170, 150, 120);

            kp.DrawLine(pero, 150, 120, 200, 170);

            kp.DrawLine(pero, 100, 170, 200, 270);

            kp.DrawLine(pero, 100, 270, 200, 170);

            kp.DrawRectangle(pero, 100, 170, 100, 100);
        }
    }
}
