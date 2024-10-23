using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vyplněné_obrazce
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void oknoProgramu_Paint(object sender, PaintEventArgs e)
        {
            // Získáme kreslicí plochu kp
            Graphics kp = e.Graphics;

            // Nakreslíme chrpově modrý VYPLNĚNÝ obdélník
            //   v bodě [20, 100] o šířce i výšce 50 pixelů 
            //   (takže vlastně čtverec)
            // Význam parametrů stejný jako u DrawRectangle 
            kp.FillRectangle(Brushes.CornflowerBlue, 20, 100, 50, 50);

            // Ještě jeden obdélník, tentokrát zelený
            kp.FillRectangle(Brushes.Green, 0, 200, 300, 10);

            // Pomocí obdélníků 1x1 můžeme kreslit tečky
            kp.FillRectangle(Brushes.Black, 10, 10, 1, 1);

            // Nakreslíme růžovou VYPLNĚNOU elipsu umístěnou 
            //   uvnitř obdélníka, který začíná v bodě [120, 30]
            //   a je 100 pixelů široký a 70 pixelů vysoký
            // Význam parametrů je stejný jako u DrawEllipse
            kp.FillEllipse(Brushes.Pink, 120, 30, 100, 70);
        }
    }
}