using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string archivo = openFileDialog1.FileName;
            FileStream fls = new FileStream(archivo, FileMode.Open);
            BinaryReader bir = new BinaryReader(fls);

            int dato;
            bir.ReadByte();
            bir.ReadByte();
            dato = bir.ReadInt32();
            txtTamñoBytes.Text = dato.ToString();

            for(int i=0; i<12;i++)
            {
                bir.ReadByte();
            }
            dato = bir.ReadInt32();
            txtAncho.Text = dato.ToString();
            dato = bir.ReadInt32();
            txtAltura.Text = dato.ToString();

            for(int i=0;i<2;i++)
            {
                bir.ReadByte();
            }
            dato = bir.ReadInt16();
            txtNumPixel.Text = dato.ToString();

            bir.Close();
            fls.Close();
        }
    }
}
