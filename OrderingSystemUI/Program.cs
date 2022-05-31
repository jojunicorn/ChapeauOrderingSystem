using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderingSystemLogic;
using OrderingSystemModel;

namespace OrderingSystemUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Employee employee = null;
            Application.Run(new WaiterUI(employee));
            //Application.Run(new LoginForm());
        }
    }
}
