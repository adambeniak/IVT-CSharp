using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Zkouška_per
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

            // Vytvoříme nové pero
            Pen modréPero = new Pen(Color.Blue);
            kp.DrawLine(modréPero, 20, 0, 20, 100);
            
            // Změníme tloušťku pera na 10 pixelů
            modréPero.Width = 10;
            kp.DrawLine(modréPero, 40, 0, 40, 100);

            // Změníme barvu pera na světle modrou
            modréPero.Color = Color.LightBlue;
            kp.DrawLine(modréPero, 60, 0, 60, 100);

            // Další pero dvouparametrickým konstruktorem
            Pen červenéPero = new Pen(Color.Red, 20);
            kp.DrawLine(červenéPero, 100, 0, 100, 100);
        }
    }
}