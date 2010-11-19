using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace truconet
{
    public class Truco //Controladora del Truco
    {


         //public static int cantJugadores = 0;
        List<Partido> colPartido;
        List<Jugador> colJugadores;
        private List<Carta> maso = new List<Carta>();

       

        
        //TODO: definir como se van a hacer las comparaciones de las cartas

      

   
        //Singleton
        public static Truco instancia = null;
        
      


        private Truco()
        {
            this.colPartido = new List<Partido>();
            this.colJugadores = new List<Jugador>();
            crearMaso();
        }


        public static Truco getInstance()
        {

            if (instancia==null)
            {
                instancia = new Truco();
            }

                return instancia;
        
        }


        public void iniciarPartido(List<Jugador> pParticipantes, string desc)
        {
            if ((pParticipantes.Count()%2) == 0)
            {
                Partido partido = new Partido(desc, pParticipantes,maso);
                this.colPartido.Add(partido);  
            }
        
        }


        public List<Partido> ColPartido
        {
            get { return colPartido; }
            set { colPartido = value; }
        }

        public List<Carta> Maso
        {
            get { return maso; }
            set { maso = value; }
        }

        public void crearMaso()
        {
            maso = new List<Carta>();

            int[] num = { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };

            // {Oro=1, Copa=2, Basto=3, Espada=4}
            // recorro por palo y luego por numero de carta
            for (int i = 1; i <= 4; i++)
            {
                //Recorro por numero de carta, creando las cartas y agregandolas al maso
                for (int j = 0; j < num.Length; j++)
                {
                    Carta carta = new Carta(num[j], i);
                    maso.Add(carta);
                }
            }

        }

    }
}
