using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCartas
{
    class Baraja
    {
        public List<Carta> barajaList = new List<Carta>();

        public Baraja()
        {
            for (int i = 0; i < 4/*4*/; i++)
            {
                for (int j = 1; j <= 12/*12*/; j++)
                {
                    Carta carta = new Carta(j, i);
                    barajaList.Add(carta);
                }
            }
        }

        public int ContarCartas()
        {
            return barajaList.Count();
        }

        public Carta RobarCarta()
        {
            //robar carta implica que retiro la 1a carta de la lista y la pongo abajo del todo.
            Carta cartaEliminada = new Carta(barajaList[0].Numero, barajaList[0].Palo);
            barajaList.Remove(barajaList[0]);
            //barajaList.Add(cartaEliminada);
            return cartaEliminada;


        }

        public void Barajar()
        {
            List<Carta> barajaBarajada =  BarajarMethod(barajaList);
            barajaList = barajaBarajada;
        }

        // que nadie me pregunte como funciona este metodo, no me interesa.
        public List<Carta> BarajarMethod(List<Carta> list)
        {
            var random = new Random();
            var barajaBarajadaMethod = new List<Carta>();
            var listcCount = list.Count;
            for (int i = 0; i < listcCount; i++)
            {
                var randomElementInList = random.Next(0, list.Count);

                barajaBarajadaMethod.Add(list[randomElementInList]);
                list.Remove(list[randomElementInList]);
            }
            return barajaBarajadaMethod;
        }

        public Carta CogerCarta(int n)
        {
            Carta cartaEliminada = new Carta(barajaList[n].Numero, barajaList[n].Palo);
            barajaList.Remove(barajaList[n]);
            return cartaEliminada;
        }

        public Carta CogerCartaAlAzar(int nRandom)
        {

            Carta cartaEliminada = new Carta(barajaList[nRandom].Numero, barajaList[nRandom].Palo);
            barajaList.Remove(barajaList[nRandom]);

            return cartaEliminada;

        }

        public override string ToString()
        {
            //for (int i = 0; i < ContarCartas() - 1; i++)
            //{
            //    Console.WriteLine(barajaList[i].ToString());
            //}
            return barajaList.ToString();
        }
    }
}
