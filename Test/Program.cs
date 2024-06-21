#define DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace MissileControl
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
            #if DEBUG
                ConsoleFunctions.AllocConsole();
                Console.WriteLine("Debug Console");
            #endif
            Application.Run(new MainWindow());
            #if DEBUG
                MessageBox.Show("This MessageBox gives you some time" +
                                " to look at your debug window");
                ConsoleFunctions.FreeConsole();
            #endif
        }
    }
}
