﻿using SnowLeopard.WFs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard
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
            //Application.Run(new StartupShotdown());
<<<<<<< HEAD
            //Application.Run(new BorderTimer());
            //Application.Run(new Align());
            Application.Run(new Layout());
=======
            Application.Run(new BorderTimer());
>>>>>>> parent of bb4c8d9... 1
        }
    }
}















