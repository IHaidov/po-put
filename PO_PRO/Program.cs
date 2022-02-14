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
            
            if (LoggedIn == 0)
                Application.Run(new LoginForm());
            else if (LoggedIn == 1)
            {
                Application.Run(new AdminForm());
            }
            else if (LoggedIn == 2)
            {
                Application.Run(new UserForm());
            }
        }
    }
}
