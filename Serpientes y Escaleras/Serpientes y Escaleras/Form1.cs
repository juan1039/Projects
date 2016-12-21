using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serpientes_y_Escaleras
{
    public partial class Form1 : Form
    {
        Jugador infor = new Jugador();
       
        public Form1()
        {
            InitializeComponent();
            txtJugador1.Text = "0"; txtJugador2.Text = "0";
        }

        bool estado = true;
        
        private void btnJugador1_Click(object sender, EventArgs e)
        {
            if (estado == true)
            {
                lblInfo.Text = "";
                string info = Convert.ToString(infor.jugador(1));
                lblInfo2.Text = "";

                if (info == "Jugardor 1, no es su turno.")
                {
                    lblInfo.Text = info;
                }

                else if (info == "666")
                {
                    lblInfo.Text = "Jugador 1 Ganador"; txtJugador1.Text = "100"; txtJugador2.Text = "Perdiste"; estado = false;
                }

                else
                {
                    txtJugador1.Text = info;
                }
            }
            else { }
        }

        private void btnJugador2_Click(object sender, EventArgs e)
        {
             if (estado == true)
            {

                lblInfo2.Text = "";
                string info = Convert.ToString(infor.jugador(2));
                lblInfo.Text = "";

                if (info == "Jugardor 2 no es su turno.")
                {
                    lblInfo2.Text = info;
                }

                else if (info == "666")
                {
                    lblInfo2.Text = "Jugador 2 Ganador"; txtJugador1.Text = "Perdiste"; txtJugador2.Text = "100"; estado = false;
                }
                else
                {
                    txtJugador2.Text = info;
                }
            }
            else { }
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
