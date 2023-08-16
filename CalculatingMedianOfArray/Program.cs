using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatingMedianOfArray
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Array array = new Array();
            bool canArrayBeSaved = false;
            bool canResultBeSaved = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(array, canArrayBeSaved, canResultBeSaved));
        }
    }
}
