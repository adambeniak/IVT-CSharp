using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vystředění
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

            // Zjištění rozměrů okna
            int šířkaOkna = ClientSize.Width;
            int výškaOkna = ClientSize.Height;

            // Výpočet středu
            int xStředu = šířkaOkna / 2;
            int yStředu = výškaOkna / 2;

            // Výpočet levého horního rohu opsaného obdélníka a rozměrů
            int poloměr = 40;
            int xLH = xStředu - poloměr;
            int yLH = yStředu - poloměr;
            int šířka = 2 * poloměr;
            int výška = šířka;

            // Vykreslení
            kp.DrawEllipse(Pens.Black, xLH, yLH, šířka, výška);
        }

        private void oknoProgramu_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}