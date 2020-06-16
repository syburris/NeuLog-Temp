using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuLog_Temp
{
    class Sensor
    {
        public double[] GetSensorValue { get; set; }

        public Sensor()
        {

        }

        public Sensor(double values)
        {
            GetSensorValue = new double[(int)values];
        }
    }
}
