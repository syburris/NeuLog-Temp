using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuLog_Temp
{
    public partial class Form1 : Form
    {
        // create a boolean for running the experiment
        private static Boolean running = new Boolean();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            running = true;
            while(running == true)
            {
               
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            running = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
