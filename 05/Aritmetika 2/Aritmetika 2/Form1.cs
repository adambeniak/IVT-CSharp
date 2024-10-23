using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aritmetika_2
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void poleČísla_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int číslo1 = Convert.ToInt32(poleČíslo1.Text);
                int číslo2 = Convert.ToInt32(poleČíslo2.Text);

                int součet = číslo1 + číslo2;

                poleSoučet.Text = Convert.ToString(součet);

                int rozdíl = číslo1 - číslo2;

                poleRozdíl.Text = Convert.ToString(rozdíl);

                int součin = číslo1 * číslo2;

                poleSoučin.Text = Convert.ToString(součin);
            }
            catch (Exception)
            {

                
            }
        }
    }
    }


   

