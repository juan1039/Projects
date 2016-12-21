using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevador
{
    public partial class Form1 : Form
    {
        class Elevador
        {
            private int pisosTotales;
            private int pisoActual;
            private Boolean puertaEstado;
        }
        public int pisoActual { get { return pisoActual; } }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
