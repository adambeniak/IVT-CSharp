using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Přesouvání
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoPřesuň_Click(object sender, EventArgs e)
        {
            poleKopie.Text = poleVěta.Text;
            poleVěta.Text = null;
            MessageBox.Show("Věta přesunuta, horní pole vymazáno.");
        }
    }
}
