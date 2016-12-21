using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vectoresUnir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] vector1 = new int[20];
        int[] vector2 = new int[30];

        private void btnVector1_Click(object sender, EventArgs e)
        {
            
            Random Aleatorio = new Random();

            txtVector1.Text = "";
            for (int i = 0; i < 20; i++) 
            {
                vector1[i] = Aleatorio.Next(0,9);
            }

            Array.Sort(vector1);
            for (int i = 0; i < 20; i++)
            {
                txtVector1.Text += vector1[i].ToString() + Environment.NewLine;
            }
        }

        private void btnVector2_Click(object sender, EventArgs e)
        {
            
            Random Aleatorio = new Random();

            txtVector2.Text = "";
            for (int i = 0; i < 30; i++)
            {
                vector2[i] = Aleatorio.Next(0, 9);
            }

            Array.Sort(vector2);
            for (int i = 0; i < 30; i++)
            {
                txtVector2.Text += vector2[i].ToString() + Environment.NewLine;
            }
        }

        private void btnVector3_Click(object sender, EventArgs e)
        {
            int[] vector3 = new int[50];
            int i = 0, j=0, k=0;
            
            txtVector3.Text = "";
          
        }
        public int[] unir(int[] vector1, int[] vector2)
        {
            int i;
            int[] unido = new int[50];

            for (i = 0; i < vector1.Length; i++)
            {
                unido[i] = vector1[i];
            }

            for (int j = 0; j < vector2.Length; j++)
            {
                unido[i++] = vector2[j];
            }

            return unido;
        }
        public int[] ordenar(int[] vector, int[] v1, int[] v2)
        {
            int[] tmp = new int[vector.Length];
            int i = 0, j = 0, k = 0;

            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j])
                {
                    tmp[k++] = v1[i++];
                }
                else
                {
                    tmp[k++] = v2[j++];
                }
            }
            while (i < v1.Length)
            {
                tmp[k++] = v1[i++];
            }
            while (i < v1.Length)
            {
                tmp[k++] = v2[i++];
            }

            return tmp;
        }
    }
}
