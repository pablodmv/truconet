using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace truconet
{
    class Partido
    {
        private int identificador;
        private List<Jugador> participantes = new List<Jugador>();
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private List<Jugador> ganadores = new List<Jugador>();
        private int[,] puntajeFinal = new int[2, 3];

        public int[,] PuntajeFinal
        {
            get { return puntajeFinal; }
            set { puntajeFinal = value; }
        }


        public List<Jugador> Ganadores
        {
            get { return ganadores; }
            set { ganadores = value; }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public List<Jugador> Participantes
        {
            get { return participantes; }
            set { participantes = value; }
        }

        public int Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }

    }
}
