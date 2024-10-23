using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Událost_Resize
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void oknoProgramu_ResizeBegin(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Hand.Play();
        }

        private void oknoProgramu_ResizeEnd(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
        }
    }
}
