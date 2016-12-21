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

namespace archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 65;
            long l = 65;
            short s = 65;
            double d = 3.14159245;
            string st = "esta es una cadena";
            saveFileDialog1.ShowDialog();
            string archivo = saveFileDialog1.FileName;
            FileStream ft = new FileStream(archivo,FileMode.Create);
            StreamWriter stw = new StreamWriter(ft);
            
            stw.WriteLine(i);
            stw.WriteLine(l);
            stw.WriteLine(s);
            stw.WriteLine(d);
            stw.WriteLine(st);
            stw.Close();
            ft.Close();


        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string archivo = openFileDialog1.FileName;
            FileStream fs = new FileStream(archivo, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string datos;
            datos = sr.ReadLine();
            //int i = Convert.ToInt32(datos);
            MessageBox.Show(datos);
            datos = sr.ReadToEnd();
            MessageBox.Show(datos);
            sr.Close();
            fs.Close();
        }

        private void btnGrabarBinarios_Click(object sender, EventArgs e)
        {
            int i = 65;
            long l = 65;
            short s = 65;
            double d = 3.14159245;
            string st = "esta es una cadena";
            saveFileDialog1.ShowDialog();
            string archivo = saveFileDialog1.FileName;
            FileStream ft = new FileStream(archivo, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(ft);


            bw.Write(i);
            bw.Write(l);
            bw.Write(s);
            bw.Write(d);
            bw.Write(st);
            bw.Close();
            ft.Close();
        }
    }
}
