﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zkouška_barev
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void oknoProgramu_Load(object sender, EventArgs e)
        {
            // Žlutou barvu do proměnné (autogenerující vlastnost)
            Color žlutáBarva = Color.Yellow;

            // Získání barevných komponent RGB dané barvy
            // (použití složek objektu Color)
            int R = žlutáBarva.R;
            int G = žlutáBarva.G;
            int B = žlutáBarva.B;

            // Zobrazení výsledků
            poleŽlutáR.Text = Convert.ToString(R);
            poleŽlutáG.Text = Convert.ToString(G);
            poleŽlutáB.Text = Convert.ToString(B);
        }

        private void panelŽlutá_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            Color žlutáBarva = Color.Yellow;
            Pen žlutéPero = new Pen(žlutáBarva);
            kp.DrawEllipse(žlutéPero, 0, 0, 70, 70);
        }

        private void panelMíchaná_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;

            try
            {
                // Hodnoty z textových polí do číselné formy
                int R = Convert.ToInt32(poleMíchanáR.Text);
                int G = Convert.ToInt32(poleMíchanáG.Text);
                int B = Convert.ToInt32(poleMíchanáB.Text);

                // Namíchání barvy (autogenerující metoda)
                Color míchanáBarva = Color.FromArgb(R, G, B);
                
                // Pero z míchané barvy (volání konstruktoru)
                Pen pero = new Pen(míchanáBarva);

                // Elipsa připraveným perem
                kp.DrawEllipse(pero, 0, 0, 70, 70);
            }
            catch
            {
            }
        }

        private void všechnaPoleMíchaná_TextChanged(object sender, EventArgs e)
        // Společná obsluha tří spodních textových polí
        {
            panelMíchaná.Refresh();
        }
    }
}