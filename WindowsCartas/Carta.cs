using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCartas
{
    class Carta
    {
        int numero;
        int palo;

        string[] palos = { "Oros", "Copas", "Espadas", "Bastos" };

        public Carta(int numero, int palo)
        {
            this.numero = numero;
            this.palo = palo;
        }


        public int Numero {
            get {return numero; } 
            set { numero = value;} 
        }

        public int Palo
        {
            get { return palo; }
            set { palo = value; }
        }
        public override string ToString()
        {
            return (numero + " de " + palos[palo]);
        }

    }
}
