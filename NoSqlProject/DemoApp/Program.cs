using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
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
            //Application.Run(new Form1());

            //Application.Run(new ServiceDeskEmployeeForm());
            //UserService userService = new UserService();
            //User user = userService.getMatchedUser("salah@gmail.com", "test")[0];
            //Application.Run(new RegularEmployeeForm(user));

            //Application.Run(new ServiceDeskEmployeeForm());
            //Application.Run(new RegularEmployeeForm());
        }
    }
}
