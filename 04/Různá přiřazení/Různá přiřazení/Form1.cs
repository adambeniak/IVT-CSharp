using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Různá_přiřazení
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoAhojLidi_Click(object sender, EventArgs e)
        {
            poleVěta.Text = "Ahoj, lidi!";
        }

        private void tlačítkoVymaž_Click(object sender, EventArgs e)
        {
            poleVěta.Text = "";
            // Rozšíření: Zobraz o tom zprávu.
            MessageBox.Show("Textové pole Věta je nyní určitě prázdné.");
        }

        private void tlačítkoTextČerveně_Click(object sender, EventArgs e)
        {
            poleVěta.ForeColor = Color.Red;
        }

        private void tlačítkoZablokuj_Click(object sender, EventArgs e)
        {
            poleVěta.Enabled = false;
            tlačítkoZablokuj.Enabled = false;
            tlačítkoOdblokuj.Enabled = true;
        }

        private void tlačítkoOdblokuj_Click(object sender, EventArgs e)
        {
            poleVěta.Enabled = true;
            tlačítkoOdblokuj.Enabled = false;
            tlačítkoZablokuj.Enabled = true;
        }
    }
}
