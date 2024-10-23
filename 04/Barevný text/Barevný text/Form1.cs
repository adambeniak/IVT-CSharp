using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barevný_text
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítko1_Click(object sender, EventArgs e)
        {
            poleText.ForeColor = tlačítko1.BackColor;
        }

        private void tlačítko2_Click(object sender, EventArgs e)
        {
            poleText.ForeColor = tlačítko2.BackColor;
        }

        private void tlačítko3_Click(object sender, EventArgs e)
        {
            poleText.ForeColor = tlačítko3.BackColor;
        }

        private void tlačítko4_Click(object sender, EventArgs e)
        {
            poleText.ForeColor = tlačítko4.BackColor;
        }
    }
}
