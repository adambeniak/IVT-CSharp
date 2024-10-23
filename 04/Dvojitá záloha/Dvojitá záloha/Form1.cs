using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dvojitá_záloha
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoZálohuj_Click(object sender, EventArgs e)
        {
            polePůvodníZáloha.Text = poleZáloha.Text;
            poleZáloha.Text = poleVěta.Text;
        }
    }
}
