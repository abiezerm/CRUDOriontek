﻿using Autofac;
using SGClaves.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClaves
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
            Container = CompositionRoot.CreateContainer();
            PresenterFactory.SetContainer(Container);
            Application.Run(new FormMenu());
           
        }
     public static IContainer Container; 
    }
}
