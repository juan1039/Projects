using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dado1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Random Aleatorio = new Random();
        public int Lanzar()
        {
            int x = Aleatorio.Next(1, 7);
            return x;
        }
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int[] vector = new int[6];
            int d = Lanzar();
            
            for (int i = 1; i <= 1000; i++)
            {
               
            }
        }
    }
}
