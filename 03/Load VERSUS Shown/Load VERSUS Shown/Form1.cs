using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Load_VERSUS_Shown
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void oknoProgramu_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Vznikla událost Load.");
        }

        private void oknoProgramu_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Vznikla událost Shown.");
        }
    }
}
