using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Zkouška_barev___já
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void oknoProgramu_Load(object sender, EventArgs e)
        {
            // Purpurovou barvu do proměnné (autogenerující vlastnost)
            Color purpurováBarva = Color.Magenta;

            // Získání barevných komponent RGB dané barvy
            // (použití složek objektu Color)
            int R = purpurováBarva.R;
            int G = purpurováBarva.G;
            int B = purpurováBarva.B;

            // Zobrazení výsledků
            polePurpurováR.Text = Convert.ToString(R);
            polePurpurováG.Text = Convert.ToString(G);
            polePurpurováB.Text = Convert.ToString(B);


        }

        private void panelPurpurová_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            Color purpurováBarva = Color.Magenta;
            //2 parametry
            Pen purpurovéPero = new Pen(purpurováBarva, 10);
            kp.DrawEllipse(purpurovéPero, 10, 10, 149, 149);


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

                // Pero z míchané barvy (volání konstruktoru), 2 parametry
                Pen pero = new Pen(míchanáBarva, 5);

                // Elipsa připraveným perem
                kp.DrawEllipse(pero, 5, 5, 159, 159);
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
