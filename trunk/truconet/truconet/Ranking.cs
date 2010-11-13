using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace truconet
{
    class Ranking
    {

        private int posicion;
        private Jugador jug;
        private String puntaje;


        //Constructores

        public Ranking()
        {
        }


        //Getters y Setters

        public String Puntaje
        {
            get { return puntaje; }
            set { puntaje = value; }
        }


        public Jugador Jug
        {
            get { return jug; }
            set { jug = value; }
        }
        


        public int Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

        

    }
}
