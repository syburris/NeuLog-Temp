using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using System.Timers;

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

        private static void SetTimer()
        {
            // Create a timer with a one second interval.
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
            //intitiate the request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json; charset=utf-8";

            //capture the response
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                string json = reader.ReadToEnd();
                Sensor sensor = JsonConvert.DeserializeObject<Sensor>(json);
                LogReading(sensor);
            }
        }

        private static void LogReading(Sensor s)
        {
            if (s is null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            Reading r = new Reading();
            foreach (var value in s.GetSensorValue)
            {
                r.temp = value.ToString();
            }
            r.time = DateTime.Now.ToString();
            readings.Add(r);
        }

    }
}
