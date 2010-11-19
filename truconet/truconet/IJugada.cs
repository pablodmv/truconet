using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace truconet
{
    interface IJugada
    {
        int obtenerPuntos(List<Carta> cartas, Carta muestra);
        Carta cartaGanadora(List<Carta> cartas, Carta muestra);
    }
}
