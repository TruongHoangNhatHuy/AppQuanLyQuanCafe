using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop
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
<<<<<<< Updated upstream
            //Application.Run(new View.LoginForm());
            Application.Run(new View.EmpForm.DetailOrderForm());
            //Application.Run(new View.EmpForm.BillForm());
=======
            Application.Run(new View.EmployeeForm());
            //Application.Run(new View.LoginForm());
            //Application.Run(new View.EmpForm.OrderForm());
>>>>>>> Stashed changes
        }
    }
}
