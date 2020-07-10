using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NLayer.Negocio;
using System.Windows.Forms;

namespace NLayer.Forms
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
            Application.Run(new Form1(new ClienteServicio()));
        }
    }
}
