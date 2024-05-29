using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;

namespace Train_Booking_System
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
            Application.Run(new LoginForm());
            //Application.Run(new AdminLogin());
            //Application.Run(new Mainform());
            //Application.Run(new Dashboard());
            
        }
    }
}
