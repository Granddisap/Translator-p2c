using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cnvrt
{
    static class Program
    {
        /// <summary>
        /// Основная точка входа в приложение.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainWindow());
        }
    }
}