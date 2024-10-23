using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aritmetika
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoSečti_Click(object sender, EventArgs e)
        {
            try
            {
                int číslo1 = Convert.ToInt32(poleČíslo1.Text);
                int číslo2 = Convert.ToInt32(poleČíslo2.Text);

                int součet = číslo1 + číslo2;

                poleVýsledek.Text = Convert.ToString(součet);
            }
            catch (Exception)
            {

                
            }
        }

        private void tlačítkoOdečti_Click(object sender, EventArgs e)
        {
            try
            {
                int číslo1 = Convert.ToInt32(poleČíslo1.Text);
                int číslo2 = Convert.ToInt32(poleČíslo2.Text);

                int rozdíl = číslo1 - číslo2;

                poleVýsledek.Text = Convert.ToString(rozdíl);
            }
            catch (Exception)
            {

                
            }
        }

        private void tlačítkoVynásob_Click(object sender, EventArgs e)
        {
            try
            {
                int číslo1 = Convert.ToInt32(poleČíslo1.Text);
                int číslo2 = Convert.ToInt32(poleČíslo2.Text);

                int součin = číslo1 * číslo2;

                poleVýsledek.Text = Convert.ToString(součin);
            }
            catch (Exception)
            {

                
            }
        }
    }
}
