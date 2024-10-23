using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sčítačka
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }

        private void tlačítkoRovnáSe_Click(object sender, EventArgs e)
        {
            try
            {
                //Hodnoty Text obou vstupních polí převést na čísla
                int číslo1;
                číslo1 = Convert.ToInt32(poleČíslo1.Text);
                int číslo2;
                číslo2 = Convert.ToInt32(poleČíslo2.Text);

                //Čísla sečíst
                int výsledek;
                výsledek = číslo1 + číslo2;

                //Výsledek převést na řetězec a zapsat jako hodnotu Text výstupního pole
                poleVýsledek.Text = Convert.ToString(výsledek);
            }
            catch (Exception)
            {

                poleVýsledek.Text = null;
            }
        }
    }
}
