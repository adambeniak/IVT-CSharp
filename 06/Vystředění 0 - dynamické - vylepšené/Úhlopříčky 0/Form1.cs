using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Úhlopříčky_0
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }
        int šířkaO, výškaO, šířkaKČO, výškaKČO, xS, yS, xLH, yLH, šířka, výška, poloměr = 40;

        private void oknoProgramu_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            šířkaKČO = ClientSize.Width;
            výškaKČO = ClientSize.Height;
            xS = šířkaKČO / 2;
            yS = výškaKČO / 2;
            xLH = xS - poloměr;
            yLH = yS - poloměr;
            šířka = 2 * poloměr;
            výška = šířka;
            kp.DrawEllipse(Pens.Black, xLH, yLH, šířka, výška);
        }

        private void oknoProgramu_Load(object sender, EventArgs e)
        {
            šířkaO = Size.Width;
            výškaO = Size.Height;
            poleŠO.Text = Convert.ToString(šířkaO);
            poleVO.Text = Convert.ToString(výškaO);
            šířkaKČO = ClientSize.Width;
            výškaKČO = ClientSize.Height;
            poleŠKČO.Text = Convert.ToString(šířkaKČO);
            poleVKČO.Text = Convert.ToString(výškaKČO);
            xS = šířkaKČO / 2;
            yS = výškaKČO / 2;
            polexS.Text = Convert.ToString(xS);
            poleyS.Text = Convert.ToString(yS);
            xLH = xS - poloměr;
            yLH = yS - poloměr;
            polexLH.Text = Convert.ToString(xLH);
            poleyLH.Text = Convert.ToString(yLH);
        }

        private void oknoProgramu_Resize(object sender, EventArgs e)
        {
            šířkaO = Size.Width;
            výškaO = Size.Height;
            poleŠO.Text = Convert.ToString(šířkaO);
            poleVO.Text = Convert.ToString(výškaO);
            šířkaKČO = ClientSize.Width;
            výškaKČO = ClientSize.Height;
            poleŠKČO.Text = Convert.ToString(šířkaKČO);
            poleVKČO.Text = Convert.ToString(výškaKČO);
            xS = šířkaKČO / 2;
            yS = výškaKČO / 2;
            polexS.Text = Convert.ToString(xS);
            poleyS.Text = Convert.ToString(yS);
            xLH = xS - poloměr;
            yLH = yS - poloměr;
            polexLH.Text = Convert.ToString(xLH);
            poleyLH.Text = Convert.ToString(yLH);
            Refresh();
        }
    }
}
