using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Grafika_v_části_okna
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            // Získáme kreslicí plochu PANELU 
            Graphics kp = e.Graphics;

            // Údaje z textových polí převedeme do číselné formy
            int xStředu, yStředu, šířka, výška;
            try
            {
                xStředu = Convert.ToInt32(poleXstředu.Text);
                yStředu = Convert.ToInt32(poleYstředu.Text);
                šířka   = Convert.ToInt32(poleŠířka.Text);
                výška   = Convert.ToInt32(poleVýška.Text);
            }
            catch
            {
                // V případě zadání špatné hodnoty ukončíme
                //   vykonávání obsluhy události Paint, čímž 
                //   panel zůstane prázdný
                return;
            }

            // Spočteme souřadnice levého horního rohu
            //   pomyslného opsaného obdélníka
            int xLH = xStředu - šířka / 2;
            int yLH = yStředu - výška / 2;
            polexLH.Text = Convert.ToString(xLH);
            poleyLH.Text = Convert.ToString(yLH);

            // A konečně vykreslíme elipsu (i s ohraničením)
            kp.FillEllipse(Brushes.CornflowerBlue, xLH, yLH, šířka, výška);
            kp.DrawEllipse(Pens.Black, xLH, yLH, šířka, výška);
        }

        private void tlačítkoPřekresli_Click(object sender, EventArgs e)
        {
            panel.Refresh();
        }
    }
}