using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace truconet
{
    public class cartasMano
    {
        private List<Carta> cartas = new List<Carta>();
        private int jugada = 0; //1-Flor, 2-Envido
        private int puntos = 0;
        private int idPartido;

     

        public cartasMano(int idPartido)
        {
            this.idPartido = idPartido;
        }
        public cartasMano()
        {

        }
        #region Metodos_Accesores


        public int Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }
        public int Jugada
        {
            get { return jugada; }
            set { jugada = value; }
        }
      

        public List<Carta> Cartas
        {
            get { return cartas; }
            set { cartas = value; }
        }

        public int IdPartido
        {
            get { return idPartido; }
            set { idPartido = value; }
        }


        #endregion

        public void chequearJugada()
        {
            List<Carta> piezas = new List<Carta>();
            List<Carta> resto = new List<Carta>();
            int cantPiezas = 0;

            foreach (Carta card in this.Cartas)
            {
                if (card.Categoria==1)
                {
                    piezas.Add(card);
                        cantPiezas++;

                }
                else
                {
                    resto.Add(card);
                }
            }

            switch (cantPiezas)
            {
                case 3:
                    this.florTresPiezas();
                    break;
                case 2:
                    this.florDosPiezas(piezas,resto[0]);
                    break;
                case 1:
                    if (resto[0].Palo==resto[1].Palo) //Si es una pieza, me fijo que el resto sea del mismo palo
                    {
                        this.florUnaPieza(piezas[0], resto);
                    }
                    else
                    {
                        esEnvido(piezas[0], resto);
                    }
                    
                    break;
                case 0:
                    if (resto[0].Palo==resto[1].Palo && resto[1].Palo==resto[2].Palo) //Si no tiene piezas me fijo que sea Flor derecha
                    {
                        this.florSinPiezas(this.Cartas);
                    }
                    else
                    {
                        esEnvido(null,resto);
                    }

                    
                    break;
            }
        
        
        }





        private void esEnvido(Carta pieza, List<Carta> resto)
        {
            //Chequeo que las cartas en resto no sean negras y luego cual es la mayor.
            int puntaje = 0;
            if (pieza!=null)
            {
                puntaje += pieza.Puntaje;
                if (resto[0].Numero<10 && resto[1].Numero<10) //Si no son negras me fijo cual es mayor y sumo el puntaje
                {
                    if (resto[0].Numero>resto[1].Numero)
                    {
                        puntaje += resto[0].Numero;
                        this.Puntos = puntaje;
                        this.Jugada = 2;
                    }
                    else
                    {
                        puntaje += resto[1].Numero;
                        this.Puntos = puntaje;
                        this.Jugada = 2;
                    }
                   
                }
                else
                {
                    if (resto[0].Numero<10) //Si hay una negra y no es la primera, sumo el valor de esa carta.
                    {
                        puntaje += resto[0].Numero;
                        this.Puntos = puntaje;
                        this.Jugada = 2;
                    }
                    else
                    {
                        puntaje += resto[1].Numero;
                        this.Puntos = puntaje;
                        this.Jugada = 2;
                    }

                }
            }
            else //Si la pieza es null
            {

                List<Carta> negras = new List<Carta>();
                List<Carta> blancas = new List<Carta>();
                foreach (Carta card in resto) // Separo segun negras y blancas.
                {
                    if (card.Numero < 10)
                    {
                        blancas.Add(card);
                    }
                    else
                    {
                        negras.Add(card);
                    }
                }
                if (negras.Count == 2 && negras[0].Palo == negras[1].Palo)  //Si son dos negras y del mismo palo
                {
                    puntaje += 20;
                }
                if (negras.Count == 1 && negras[0].Palo == blancas[0].Palo)  //si hay una negra y una blanca del mismo palo
                {
                    puntaje += 20 + blancas[0].Numero;
                }
                if (negras.Count == 1 && negras[0].Palo == blancas[1].Palo) //si hay una negra y una blanca del mismo palo
                {
                    puntaje += 20 + blancas[1].Numero;
                }
                if (negras.Count == 1 && blancas[0].Palo == blancas[1].Palo) //Si hay dos blancas del mismo palo
                {
                    puntaje += blancas[0].Numero + blancas[1].Numero + 20;
                }
                if (negras.Count == 0 && blancas[0].Palo == blancas[1].Palo) //Si hay dos blancas del mismo palo
                {
                    puntaje += blancas[0].Numero + blancas[1].Numero + 20;
                }
                if (negras.Count == 0 && blancas[0].Palo == blancas[2].Palo) //Si hay dos blancas del mismo palo
                {
                    puntaje += blancas[0].Numero + blancas[2].Numero + 20;
                }
                if (negras.Count == 0 && blancas[1].Palo == blancas[2].Palo) //Si hay dos blancas del mismo palo
                {
                    puntaje += blancas[1].Numero + blancas[2].Numero + 20;
                }

                if (blancas.Count==3) //si son 3 blancas de distinto palo, busco la mayor
                {
                    Carta mayor=resto[0];
                    foreach (Carta card in resto)
                    {
                        if (card.Numero>mayor.Numero)
                        {
                            mayor = card;
                        }
                        
                    }
                    puntaje += mayor.Numero;
                }
                if (negras.Count==3) //Si son 3 negras
                {
                    puntaje = 0;
                }

            }
        }



        public void florTresPiezas()
        {
            List<Carta> tmpCartas = this.cartas;
            int puntaje = 0;
            Carta cartaMayor;
           
                cartaMayor = piezaMasAlta(tmpCartas);
                puntaje += cartaMayor.Puntaje;
                foreach (Carta card in tmpCartas)
                {
                    if (!card.Equals(cartaMayor))
                    {
                        puntaje += card.Puntaje - 20;
                    }
                }
                this.Jugada = 1;
                this.Puntos = puntaje;

        }


        public Carta piezaMasAlta(List<Carta> cartas)
        {
            Carta tmpCarta = cartas[0];
            foreach (Carta card in cartas)
            {
                if (card.Puntaje > tmpCarta.Puntaje)
                {
                    tmpCarta = card;
                }

            }
            return tmpCarta;

        }


        public void florDosPiezas(List<Carta> piezas, Carta cartaResto)
        {
            int puntaje = 0;
            if (piezas[0].Puntaje > piezas[1].Puntaje)
            {
                if (cartaResto.Numero < 10)
                {
                    puntaje += (piezas[0].Puntaje + (piezas[1].Puntaje - 20) + cartaResto.Numero);
                }
                else
                {
                    puntaje += (piezas[0].Puntaje + (piezas[1].Puntaje - 20));
                }
            }
            else
            {


                if (cartaResto.Numero < 10)
                {
                    puntaje += (piezas[1].Puntaje + (piezas[0].Puntaje - 20) + cartaResto.Numero);
                }
                else
                {
                    puntaje += (piezas[1].Puntaje + (piezas[0].Puntaje - 20));
                }

            }
            this.Jugada = 1;
            this.Puntos = puntaje;
        }

        public void florUnaPieza(Carta pieza, List<Carta> resto)
        {

            int puntaje = pieza.Puntaje;

            foreach (Carta Card in resto)
            {
                if (Card.Numero < 10)
                {
                    puntaje += Card.Numero;
                }
            }

            this.Jugada = 1;
            this.Puntos = puntaje;
        }

        public void florSinPiezas(List<Carta> cartas)
        {
            int puntaje = 0;
            foreach (Carta card in cartas)
            {
                if (card.Numero < 10)
                {
                    puntaje += card.Numero;
                }

            }
            this.Jugada = 1;
            this.Puntos = puntaje;

        }


        public override string ToString()
        {
            return cartas[0].ToString() + " - " + cartas[1].ToString() + " - " + cartas[2].ToString();
        }

        public void BorroCartas()
        {
            this.cartas.Clear(); ;
        }

    }
}
