using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Zopakování_jména
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoZobraz_Click(object sender, EventArgs e)
        {
            string zpráva = "Jmenujete se " + poleJméno.Text + ".";
            MessageBox.Show(zpráva);
            
            // Alternativní řešení bez použití proměnné (jen 1 řádek):
            // MessageBox.Show("Jmenujete se " + poleJméno.Text + ".");
        }
    }
}