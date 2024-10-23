using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Zahození_návratové_hodnoty
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoZjisti_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(poleÚdaj.Text);
                MessageBox.Show("Zadaný údaj je číselný.");
            }
            catch 
            {
                MessageBox.Show("Zadaný údaj není číselný.");
            }
        }
    }
}