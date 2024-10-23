using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Čáry_z_rohů
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new oknoProgramu());
        }
    }
}