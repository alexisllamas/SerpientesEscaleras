using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerpientesEscaleras
{
    public partial class Tablero : Form
    {
        private Player jugador1;
        private Player jugador2;
        private int[] tab;
        private Dado dadi;
        private int turno;
        public Tablero()
        {
            InitializeComponent();
            jugador1 = new Player();
            jugador2 = new Player();
            tab = new int[100];
            turno = 0;
            dadi = new Dado();
            llenar();
            ponerEscaleras();
            ponerSerpientes();
            mostrar();
        }

        public void mostrar()
        {
            txtJug1.Text = jugador1.Pos.ToString();
            txtJug2.Text = jugador2.Pos.ToString();
        }

        public void ponerEscaleras()
        {
            tab[3] = 50;
            tab[16] = 14;
            tab[96] = 3;
            tab[53] = 18;
            tab[24] = 28;
            tab[86] = 9;
            tab[53] = 18;
        }

        public void ponerSerpientes()
        {
            tab[98] = -97;
            tab[50] = -10;
            tab[23] = -3;
            tab[2] = -1;
            tab[76] = -25;
        }

        public void llenar()
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = 0;
            }
        }

        private void Lanzar(object sender, EventArgs e)
        {
            if(turno == 0)
            {
                avanzar(jugador1);
                cmdJug1.Enabled = false;
                cmdJug2.Enabled = true;
                turno = 1;
            }
            else
            {
                avanzar(jugador2);
                cmdJug2.Enabled = false;
                cmdJug1.Enabled = true;
                turno = 0;
            }

            if(!alguienGano())
                mostrar();
            else
            {
                if (jugador1.Gano)
                {
                    MessageBox.Show("Gana el jugador 1", "Felicidades");
                    txtJug1.Text = "Ganaste nene";
                    txtJug2.Text = "Perdiste, maldito loser";

                }
                else
                {
                    MessageBox.Show("Gana el jugador 2", "Felicidades");
                    txtJug2.Text = "Ganaste nene";
                    txtJug1.Text = "Perdiste, maldito loser";
                }

                cmdJug1.Enabled = false;
                cmdJug2.Enabled = false;
            }
        }

        private bool alguienGano()
        {
            if(jugador1.Pos < 100 && jugador2.Pos < 100)
                return false;
            else
            {
                if (jugador1.Pos >= 100)
                    jugador1.Gano = true;
                else
                    jugador2.Gano = true;

                return true;
            }
        }

        private void avanzar(Player holi)
        {
            holi.Pos += dadi.lanzar();
            if (!alguienGano())
            {
                if (tab[holi.Pos] > 0)
                {
                    mostrar();
                    MessageBox.Show(String.Format("Escalera bb, avanzas {0}", tab[holi.Pos]), "Yeeei");
                }
                else if (tab[holi.Pos] < 0)
                {
                    mostrar();
                    MessageBox.Show(String.Format("Serpiente :(, retrocedes {0}", -tab[holi.Pos]), "Buuuh!");
                }
                holi.Pos += tab[holi.Pos];
            }
        }

        private void cmdJuegoNuevo_Click(object sender, EventArgs e)
        {
            jugador1 = new Player();
            jugador2 = new Player();
            tab = new int[100];
            turno = 0;
            dadi = new Dado();
            llenar();
            ponerEscaleras();
            ponerSerpientes();
            mostrar();
            cmdJug1.Enabled = true;
        }
    }
}
