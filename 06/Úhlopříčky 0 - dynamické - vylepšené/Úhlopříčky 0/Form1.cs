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
        int šířkaO, výškaO, šířkaKČO, výškaKČO;

        private void oknoProgramu_Load(object sender, EventArgs e)
        {
            šířkaO = Size.Width;
            poleŠO.Text = Convert.ToString(šířkaO);
            výškaO = Size.Height;
            poleVO.Text = Convert.ToString(výškaO);
            šířkaKČO = ClientSize.Width;
            výškaKČO = ClientSize.Height;

            poleŠKČO.Text = Convert.ToString(šířkaKČO);
            poleVKČO.Text = Convert.ToString(výškaKČO);
        }

        private void oknoProgramu_Resize(object sender, EventArgs e)
        {
            šířkaO = Size.Width;
            poleŠO.Text = Convert.ToString(šířkaO);
            výškaO = Size.Height;
            poleVO.Text = Convert.ToString(výškaO);
            šířkaKČO = ClientSize.Width;
            výškaKČO = ClientSize.Height;

            poleŠKČO.Text = Convert.ToString(šířkaKČO);
            poleVKČO.Text = Convert.ToString(výškaKČO);
        }
    }
}
