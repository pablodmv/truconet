using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace truconet
{
    public class Carta
    {
        private static int num=0;
        private int id;
        Jugador jugador;

     
        

    
        private int cod;

        // {Oro=1, Copa=2, Basto=3, Espada=4}
        private int palo;
        // {1=Pieza, 2=Mata, 3=Fio, 4=Comun}
        private int categoria;
        private int numero;
        private int puntaje;
        

        //Constructores
        public Carta(int numero, int palo)
        {
            this.id = num;
            num=num + 1;
            this.numero = numero;
            this.palo = palo;
            
        }
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


        public int Palo
        {
            get { return palo; }
            set { palo = value; }
        }
        public int Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public int Id
        {
            get { return id; }
        }


        public Jugador Jugador
        {
            get { return jugador; }
            set { jugador = value; }
        }



        private string strPalo()
        {
            if (this.palo==1)
            {
                return "Oro";
            }

            if (this.palo == 2)
            {
                return "Copa";
            }

            if (this.palo == 3)
            {
                return "Basto";
            }

            if (this.palo == 4)
            {
                return "Espada";
            }
            return "Sin palo";
        }

        public override string ToString()
        {
            return this.Numero + "-" + this.strPalo();
        }
    }
}
