using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cnvrt
{
    static class Program
    {
        /// <summary>
        /// �������� ����� ����� � ����������.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainWindow());
        }
    }
}