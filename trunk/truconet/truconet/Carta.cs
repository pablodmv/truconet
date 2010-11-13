using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace truconet
{
    public class Carta
    {
        private int cod;
        public enum palo {Oro, Copa, Basto, Espada};
        public enum categoria {Pieza, Mata, Fio, Comun};
        private int numero;
        private int puntaje;

        //Constructores
        public Carta()
        {
            
        }


        //Getters y Setters
        public int Cod
        {
            get{ return cod; }
            set{ cod = value; }
        }


        public int Numero
        {
            get{ return numero; }
            set{ numero = value; }
        }


        public int Puntaje
        {
            get{ return puntaje; }
            set{ puntaje = value; }
        }





    }
}
