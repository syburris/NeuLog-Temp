using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            
            if(running == false)
            {
                running = true;
                textBox3.Text += "Beginning experiment...\r\n";
            }
            else
            {
                textBox3.Text += "Experiment is already running...\r\n";
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(running == true)
            {
                textBox3.Text += "Ending experiment...\r\n";
                running = false;
            }
            else
            {
                textBox3.Text += "No experiment is currently running...\r\n";
            }
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
