using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seriaPort
{
    public partial class Form1 : Form
    {
        SerialPort miPuerto;
        Timer t;
        public Form1()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            miPuerto = new SerialPort("COM1",9600,Parity.None,8,StopBits.Two);
            miPuerto.Open();
            t.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (miPuerto.BytesToRead > 0)
                textBox1.Text += miPuerto.ReadLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            miPuerto.Close();
            t.Enabled = false;
        }
    }
}
