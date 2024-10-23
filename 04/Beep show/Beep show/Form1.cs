using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beep_show
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoPípej_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
            System.Threading.Thread.Sleep(1000);
            System.Media.SystemSounds.Beep.Play();
            System.Threading.Thread.Sleep(1000);
            System.Media.SystemSounds.Beep.Play();
        }
    }
}
