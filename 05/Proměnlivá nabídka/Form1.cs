using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proměnlivá_nabídka
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void nabídkaSouborOtevřít_Click(object sender, EventArgs e)
        {
            nabídkaSouborOtevřít.Enabled = false;
            nabídkaSouborZavřít.Enabled = true;
            nabídkaProjektVlastnostiProjektu.Enabled = true;
            nabídkaProjektVlastnostiProjektu.Text = "Vlastnosti projektu " + poleJméno.Text;
        }

        private void nabídkaSouborZavřít_Click(object sender, EventArgs e)
        {
            nabídkaSouborOtevřít.Enabled = true;
            nabídkaSouborZavřít.Enabled = false;
            nabídkaProjektVlastnostiProjektu.Enabled = false;
            nabídkaProjektVlastnostiProjektu.Text = "Vlastnosti projektu";
        }

        private void nabídkaSouborKonec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nabídkaProjektVlastnostiProjektu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nastavují se vlastnosti projektu " + poleJméno.Text + ".");
        }
    }
}