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

        private void oknoProgramu_Load(object sender, EventArgs e)
        {
            int šířkaO = Size.Width;
            poleŠO.Text = Convert.ToString(šířkaO);
            int výškaO = Size.Height;
            poleVO.Text = Convert.ToString(výškaO);
            int šířkaKČO = ClientSize.Width;
            int výškaKČO = ClientSize.Height;

            poleŠKČO.Text = Convert.ToString(šířkaKČO);
            poleVKČO.Text = Convert.ToString(výškaKČO);
        }

        private void oknoProgramu_Resize(object sender, EventArgs e)
        {
            int šířkaO = Size.Width;
            poleŠO.Text = Convert.ToString(šířkaO);
            int výškaO = Size.Height;
            poleVO.Text = Convert.ToString(výškaO);
            int šířkaKČO = ClientSize.Width;
            int výškaKČO = ClientSize.Height;

            poleŠKČO.Text = Convert.ToString(šířkaKČO);
            poleVKČO.Text = Convert.ToString(výškaKČO);
        }
    }
}
