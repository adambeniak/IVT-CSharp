using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Zkouška_per___já
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

            //Vytvoříme nové pero - DarkCyan, výchozí tloušťka
            Pen modréPero = new Pen(Color.DarkCyan);
            kp.DrawLine(modréPero, 20, 20, 20, 150);

            //Změníme tloušťku pera na 10 pixelů
            modréPero.Width = 10;
            kp.DrawLine(modréPero, 40, 30, 40, 160);

            //Změníme barvu pera - Navy
            modréPero.Color = Color.Navy;
            kp.DrawLine(modréPero, 60, 40, 60, 170);

            //Další pero dvouparametrickým konstruktorem
            Pen červenéPero = new Pen(Color.Red, 20);
            kp.DrawLine(červenéPero, 80, 50, 80, 180);

            //Jedno pero nesvislé
            Pen černéPero = new Pen(Color.Black, 30);
            kp.DrawLine(černéPero, 100, 0, 150, 180);
        }
    }
}
