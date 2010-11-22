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
        Random rnd = new Random();
       

        
        //TODO: definir como se van a hacer las comparaciones de las cartas

      

   
        //Singleton
        public static Truco instancia = null;
        
      


        private Truco()
        {
            this.colPartido = new List<Partido>();
            this.colJugadores = new List<Jugador>();
            //crearMaso();
            
        }










        public static Truco getInstance()
        {

            if (instancia==null)
            {
                instancia = new Truco();
                instancia.datosPrueba(); //Carga datos de prueba
            }

                return instancia;
        
        }


        public List<Jugador> obtenerJugadores(int[] id)
        {
            List<Jugador> retorno = new List<Jugador>();
            foreach (Jugador jug in this.ColJugadores)
            {
                if (id.Contains(jug.Id))
                {
                    retorno.Add(jug);
                    
                }
                
            }
            return retorno;
        
        }

        private void datosPrueba()
        {
            //Jugador pepe = new Jugador();
            //Jugador pepe2 = new Jugador();
            //pepe.Nombre = "Pablo";
            //pepe.Apellido = "Martinez";
            //pepe2.Nombre = "Gustavo";
            //pepe2.Apellido = "Leites";
            string nombre = "Pablo ";
            string apellido = "Martinez";
            string nombre1 = "Gustavo ";
            string apellido1 = "Leites";
            string nombre2 = "Jorge ";
            string apellido2 = "Lopez";
            string nombre3 = "Andres ";
            string apellido3 = "Perez";
            this.ColJugadores.Add(new Jugador(nombre, apellido));
            this.ColJugadores.Add(new Jugador(nombre1, apellido1));
            this.ColJugadores.Add(new Jugador(nombre2, apellido2));
            this.ColJugadores.Add(new Jugador(nombre3, apellido3));
        }




        public int iniciarPartido(int[] pParticipantes, string desc)
        {

            if ((pParticipantes.Length %2) == 0)
            {
                List<Jugador> pParticipantesObj = new List<Jugador>();
                pParticipantesObj = this.obtenerJugadores(pParticipantes);

                Partido partido = new Partido(desc, pParticipantesObj);
                this.colPartido.Add(partido);
                return partido.Id;
            }
            return 0;
        }


        public List<Jugador> participantesPartido(int idPartido)
        {
            foreach (Partido part in this.colPartido)
            {
                if (part.Id==idPartido)
                {
                    return part.Participantes;
                }
            }
            return null;
        
        
        }


        public List<Partido> ColPartido
        {
            get { return colPartido; }
            set { colPartido = value; }
        }


        public List<Jugador> ColJugadores
        {
            get { return colJugadores; }
            set { colJugadores = value; }
        }

        public List<Carta> Maso
        {
            get { return maso; }
            set { maso = value; }
        }

      
        public Partido getPartido(int idPartido)
        {
            foreach (Partido part in this.ColPartido)
            {
                if (part.Id==idPartido)
                {
                    return part;
                }
                
            }
            return null;
        }

        public bool borrarParticipante(int idJugador, int idPartido)
        {
            Partido tmpPart = this.getPartido(idPartido);

            foreach (Jugador jug in tmpPart.Participantes)
            {
                if (jug.Id==idJugador)
                {
                    tmpPart.Participantes.Remove(jug);
                    return true;
                }
                
            }
            return false;
        
        
        
        }

        public List<Partido> getPartidosPendientes()
        {
            List<Partido> retorno = new List<Partido>();
            foreach (Partido game in this.colPartido)
            {
                if (game.FechaFin!=null)
                {
                    retorno.Add(game);
                }
            }
            return retorno;
                
        
        
        }

    }
}
