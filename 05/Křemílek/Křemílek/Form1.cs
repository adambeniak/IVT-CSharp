using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Křemílek
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoProveď_Click(object sender, EventArgs e)
        {
            string věta;
            věta = "Křemílek a Vochomůrka";
            poleVěta.Text = věta;
        }
    }
}
