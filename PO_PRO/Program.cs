using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PO_PRO.Forms;

namespace PO_PRO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static int LoggedIn = 0;
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
           
            Application.Run(new LoginForm());
           
        }
    }
}
