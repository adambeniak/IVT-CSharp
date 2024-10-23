using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Báječný_soused
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoChamtivý_Click(object sender, EventArgs e)
        {
            try
            {
                int číslo1 = Convert.ToInt32(poleJá.Text);
                int číslo2 = 2 * číslo1;

                poleSoused.Text = Convert.ToString(číslo2);
            }
            catch (Exception)
            {

                
            }
        }

        private void tlačítkoZávistivý_Click(object sender, EventArgs e)
        {
            try
            {
                int číslo1 = Convert.ToInt32(poleSoused.Text);
                int číslo2 = číslo1 - 1;

                poleJá.Text = Convert.ToString(číslo2);
            }
            catch (Exception)
            {

                
            }
        }
    }
}
