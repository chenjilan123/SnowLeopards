using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard
{
    static class Program
    {
        #region FormMode
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Main());
        //}
        #endregion

        static void Main()
        {
            //ThreadBegin.Run();

            ThreadPassParameter.Run();


            Trace.Assert(false, "heheh");
        }
    }
}
