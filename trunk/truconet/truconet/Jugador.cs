using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace truconet
{
    public class Jugador : Usuario
    {
        public static int num = 0;

        bool esMano=false;
        cartasMano mano = new cartasMano();

       


        public Jugador(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Id = num;
            num += 1;

            
        }

        private Jugador()
        {

        }

        public void agregarCarta(Carta card)
        {
            Mano.Cartas.Add(card);
        
        }




        public List<Carta> getCartas()
        {
            return mano.Cartas;
        }




        public cartasMano Mano
        {
            get { return mano; }
            set { mano = value; }
        }

     
        public bool EsMano
        {
            get { return esMano; }
            set { esMano = value; }
        }



        
            

    }
}
