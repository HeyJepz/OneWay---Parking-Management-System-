using Baby_Thesis_Test;
using OneWay;
using OneWayUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneWay1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // intantiating all form
            new FrmBack();
            new FrmFront();
            new FrmFullScale();
            new FrmGazeMoto();
            new FrmSide();
            new FrmLogbook();
            Application.Run(new FrmHome());         
        }
    }
}
