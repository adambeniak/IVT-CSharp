using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextChanged_VERSUS_KeyDown
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void pole1_TextChanged(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Hand.Play();
            MessageBox.Show("Událost TextChanged.");
            
        }

        private void pole2_KeyDown(object sender, KeyEventArgs e)
        {
            System.Media.SystemSounds.Question.Play();
            MessageBox.Show("Událost KeyDown.");
            
        }
    }
}
