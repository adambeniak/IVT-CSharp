﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Výměna_barev
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítka_Click(object sender, EventArgs e)
        {
            Color skrýš = tlačítko2.BackColor;
            tlačítko2.BackColor = tlačítko1.BackColor;
            tlačítko1.BackColor = skrýš;
        }

        
    }
}
