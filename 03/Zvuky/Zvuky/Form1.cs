using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zvuky
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoZvuk1_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
        }

        private void tlačítkoZvuk2_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
        }

        private void tlačítkoZvuk3_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void tlačítkoZvuk4_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Hand.Play();
        }
    }
}
