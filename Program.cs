﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollV1
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
            Application.Run(new PayrollForm());

            /* Application.Run(new ProductForm());*/
            /* Application.Run(new Login());*/
           /* Application.Run(new Employee_login_form());*/
            /* Application.Run(new DTRForm());*/
        }
    }
}
