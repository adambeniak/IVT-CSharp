using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kolečka
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
                    

            // Plná kolečka
            kp.FillEllipse(Brushes.Red,    40, 40, 20, 20);
            kp.FillEllipse(Brushes.Yellow, 40, 80, 20, 20);
            kp.FillEllipse(Brushes.Yellow, 80, 40, 20, 20);
            kp.FillEllipse(Brushes.Red,    80, 80, 20, 20);

            // Plné spojovací čáry
            kp.FillRectangle(Brushes.Black, 45, 45, 10, 50);
            kp.FillRectangle(Brushes.Black, 45, 45, 50, 10);
            kp.FillRectangle(Brushes.Black, 45, 85, 50, 10);
            kp.FillRectangle(Brushes.Black, 85, 45, 10, 50);
        }
    }
}