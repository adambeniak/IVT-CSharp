using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kopírování
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoKopíruj_Click(object sender, EventArgs e)
        {
            poleKopie.Text = poleVěta.Text;

            // Pokud je objektem přiřazení okno programu, nemusí se bližší určování provádět! (U K3.pdf)
            Text = poleVěta.Text;
            // Je to totéž, co oknoProgramu.Text = poleVěta.Text;
        }
    }
}
