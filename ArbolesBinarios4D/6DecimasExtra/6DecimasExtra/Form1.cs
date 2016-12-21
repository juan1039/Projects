using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6DecimasExtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (r[i] == true)
                    textBox1.Text += i.ToString() + " ";
            }
        }
        bool[] r = new bool[1000];
        
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++ )
            {
                r[i] = true;
            }
            for (int i = 2; i < 1000; i++)
            {
                if (r[i] == true)
                {
                    for (int j=i+1; j<1000; j++)
                    {
                        if (j%i == 0)
                            r[j] = false;
                    }
                }
            }
        }
    }
}
