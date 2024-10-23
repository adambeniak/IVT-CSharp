using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celková_cena
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoSpočti_Click(object sender, EventArgs e)
        {
            try
            {
                int kusy1 = Convert.ToInt32(poleKusů1.Text);
                int kusy2 = Convert.ToInt32(poleKusů2.Text);
                int kčkus1 = Convert.ToInt32(poleKčZaKus1.Text);
                int kčkus2 = Convert.ToInt32(poleKčZaKus2.Text);
                int poštovné = Convert.ToInt32(polePoštovné.Text);
                int balné = Convert.ToInt32(poleBalné.Text);

                int cena = kusy1 * kčkus1 + kusy2 * kčkus2 + poštovné + balné;

                string cenadozprávy = Convert.ToString(cena);

                MessageBox.Show("Celková cena je " + cenadozprávy + " Kč.");
            }
            catch (Exception)
            {
                MessageBox.Show("Byly zadány nesprávné údaje!");
                
            }
        }
    }
}
