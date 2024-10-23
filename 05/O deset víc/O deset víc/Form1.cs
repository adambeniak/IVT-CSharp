using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O_deset_víc
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void poleČíslo1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int číslo1 = Convert.ToInt32(poleČíslo1.Text);

                int číslo2 = číslo1 + 10;

                poleČíslo2.Text = Convert.ToString(číslo2);
            }
            catch (Exception)
            {

                poleČíslo2.Text = null;
            }
        }
    }
}
