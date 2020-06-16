using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuLog_Temp
{
    static class Program
    {

        // set some variables
        public static string folder = "C:\\Users\\steve\\Desktop\\FTO\\{0}.csv";
        private static System.Timers.Timer aTimer;
        public static string url = "http://localhost:22002/NeuLogAPI?GetSensorValue:[Temperature],[1]";
        public static List<Reading> readings = new List<Reading>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void BeginExperiment()
        {
            
        }

      
    }
}
