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
        string imagen;

        string[] palos = { "Oros", "Copas", "Espadas", "Bastos" };

        public Carta(int numero, int palo)
        {
            this.numero = numero;
            this.palo = palo;
            this.imagen = numero + palos[palo] + ".jpg";
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

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public override string ToString()
        {
            return (numero + " de " + palos[palo]);
        }

    }
}
