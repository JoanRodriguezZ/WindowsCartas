using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCartas
{
    public partial class CartasWindow : Form
    {

        Baraja baraja;

        public CartasWindow()
        {
            InitializeComponent();
            ComprobarBaraja();
        }

        void btnCrearBaraja_Click(object sender, EventArgs e)
        {
            baraja = new Baraja();
            RefrescarLista();

            MessageBox.Show("Nueva baraja creada");
            ComprobarBaraja();
        }

        bool ComprobarBaraja()
        {
            if (baraja == null || baraja.ContarCartas() <= 0)
            {
                labelNumCartas.Text = "No hay cartas en la baraja.";
                btnBarajar.Enabled = false;
                btnCogerCarta.Enabled = false;
                btnCogerCartaRandom.Enabled = false;
                btnRobarCarta.Enabled = false;
                return false;
            } else
            {
                labelNumCartas.Text = "Numero de cartas: " + baraja.ContarCartas().ToString();
                btnBarajar.Enabled = true;
                btnCogerCarta.Enabled = true;
                btnCogerCartaRandom.Enabled = true;
                btnRobarCarta.Enabled = true;
                return true;
            }
        }

        void RefrescarLista()
        {
            listBoxCartasBaraja.Items.Clear();

            foreach (Carta carta in baraja.barajaList)
            {
                listBoxCartasBaraja.Items.Add(carta);
            }

        }

        private void btnBarajar_Click(object sender, EventArgs e)
        {
            baraja.Barajar();
            listBoxCartasBaraja.Items.Clear(); 
            
            foreach (Carta carta in baraja.barajaList)
            {
                listBoxCartasBaraja.Items.Add(carta);
            }
        }

        private void btnRobarCarta_Click(object sender, EventArgs e)
        {
            
            labelCartaElegida.Text = baraja.RobarCarta().ToString();
            RefrescarLista();
            ComprobarBaraja();
        }

        private void btnCogerCartaRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int numRandom = random.Next(baraja.ContarCartas() - 1);
            labelCartaElegida.Text = baraja.CogerCartaAlAzar(numRandom).ToString();
            
            RefrescarLista();
            ComprobarBaraja();

        }

        private void btnCogerCarta_Click(object sender, EventArgs e)
        {
            string cEscogida = textBoxCartaEspecifica.Text;

            int cEscogidaInt;

            bool isParsable = Int32.TryParse(cEscogida, out cEscogidaInt);

            if (isParsable)
            {
                labelCartaElegida.Text = baraja.CogerCarta(cEscogidaInt - 1).ToString();
            }
            else
                Console.WriteLine("Por favor introduce un valor valido.");

            RefrescarLista();
            ComprobarBaraja();

        }
    }
}
