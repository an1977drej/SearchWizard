using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookSearchWizard
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSearchWizard());
            //try
            //{
            //    Application.Run(new frmSearchWizard());
            //}
            //catch (Exception)
            //{
            //    System.Environment.Exit(0);
            //}
        }
    }
}
