using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Čerchovaná_čára
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

            Pen čerchovanéPero = new Pen(Color.CornflowerBlue);
            čerchovanéPero.DashStyle = DashStyle.DashDot;
            kp.DrawRectangle(čerchovanéPero, 10, 10, 100, 100);
        }
    }
}