using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
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
            BienvenidaForm bienvenidaForm = new BienvenidaForm();
            BienvenidaController bienvenidaController = new BienvenidaController(bienvenidaForm);
            Application.Run(bienvenidaForm);
        }
    }
}
