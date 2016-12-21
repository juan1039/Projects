using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSueldo_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtNumero.Text);

            if (numero <= 1000)
            {
                numero *= 1.1;

                txtLista.Text = numero.ToString();
            }
            else if (numero < 1500)
            {
                numero *= 1.08;

                txtLista.Text = numero.ToString();
            }
            else if (numero <= 1800)
            {
                numero *= 1.7;

                txtLista.Text = numero.ToString();
            }
        }

        private void btnPerfecto_Click(object sender, EventArgs e)
        {
            for(int i=1;i<=1000;i++)
            {
                if (esPerfecto(i)==true)
                    txtLista.Text += i.ToString()+ Environment.NewLine;
            }
        }
        private int sumaDiv(int n)
        {
            int s = 0;

            for(int i=1; i<n;i++)
            {
                if(n%i==0)
                {
                    s += i;
                }
            }
            return s;
        }

        private bool esPerfecto(int n)
        {
            if (n == sumaDiv(n))
                return true;
            else
                return false;
        }
    }
}
