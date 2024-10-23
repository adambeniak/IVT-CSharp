using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Čerchovaná_čára___já
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
            Pen čerchovanéPero = new Pen(Color.DarkViolet, 5);
            čerchovanéPero.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            kp.DrawRectangle(čerchovanéPero, 50, 50, 150, 150);
        }
    }
}
