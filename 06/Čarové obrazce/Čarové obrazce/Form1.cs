using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Čarové_obrazce
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void oknoProgramu_Paint(object sender, PaintEventArgs e)
        {
            //Získání objektu kreslicí plochy
            Graphics kreslicíPlocha;
            kreslicíPlocha = e.Graphics;

            //Nakreslení černých čar
            kreslicíPlocha.DrawLine(Pens.Black, 0, 0, 200, 100);

            kreslicíPlocha.DrawLine(Pens.Black, 0, 100, 200, 100);

            //Modrý obdélník
            kreslicíPlocha.DrawRectangle(Pens.Blue, 200, 100, 50, 100);

            //Čokoládová elipsa
            kreslicíPlocha.DrawEllipse(Pens.Chocolate, 200, 100, 50, 100);
        }
    }
}
