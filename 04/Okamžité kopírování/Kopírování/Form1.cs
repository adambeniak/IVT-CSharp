using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kopírování
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        

        private void poleVěta_TextChanged(object sender, EventArgs e)
        {
            poleKopie.Text = poleVěta.Text;
        }
    }
}
