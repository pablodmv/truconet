using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrucoNetBackend.truconetDomain;

namespace TrucoNetBackend
{
    class ServiceBackend
    {

        public static Boolean altaUsuario(String nom, String apellido, 
            String telefono, String mail, String login, String pwd, String nick, Boolean adm){

            //TODO Llamar a web-service para realizar ALTA USUARIO
                truconetDomain.truconetDomain ws = new truconetDomain.truconetDomain();
                
                return ws.altaCredencial();
        }

        public static Boolean editarUsuario(String nom, String apellido,
            String telefono, String mail, String login, String pwd, String nick, Boolean adm)
        {

            //TODO Llamar a web-service para realizar EDITAR USUARIO
            return true;
        }

        public static Boolean bajaUsuario(String nick)
        {

            //TODO Llamar a web-service para realizar BAJA USUARIO
            return true;
        }

        public static List<Usuario> consultaUsuario()
        {
            truconetDomain.truconetDomain ws = new truconetDomain.truconetDomain();


            //TODO Llamar a web-service para realizar CONSULTA USUARIO
            //return ws.consultaUsuario();
            List<truconetDomain.Usuario> pepe = new List<truconetDomain.Usuario>();
            return pepe;
                
        }


        public static Boolean altaPartido(int identificador, int numParticipantes)
        {
            //TODO Llamar a web-service para realizar ALTA PARTIDO
            return true;
        }

        public static Boolean editarPartido(int identificador, int numParticipantes)
        {
            //TODO Llamar a web-service para realizar EDITAR PARTIDO
            return true;
        }


        public static Boolean bajaPartido(int identificador)
        {
            //TODO Llamar a web-service para realizar BAJA PARTIDO
            return true;
        }

        public static List<truconetDomain.Partido> consultaPartido()
        {
            //TODO Llamar a web-service para realizar CONSULTA PARTIDO (En CURSO/TERMINDADO)
            truconetDomain.truconetDomain ws = new truconetDomain.truconetDomain();
            List<truconetDomain.Partido> partidos = new List<truconetDomain.Partido>(ws.getPartidosPendientes());
            return partidos;
        }

        //public static List<Partido> consultaPartido(DateTime fechaIni, DateTime fechaFin)
        //{
        //    //TODO Llamar a web-service para realizar CONSULTA PARTIDO (RANGO DE FECHAS)
        //    truconetDomain.truconetDomain ws = new truconetDomain.truconetDomain();

        //    return ws.consultaPartidoRangos(fechaIni, fechaFin);

        //}


        //public static List<Partido> consultaPartido(List<Jugador> listaJugadores)
        //{
        //    //TODO Llamar a web-service para realizar CONSULTA PARTIDO (JUGADOR/ES)
        //    truconetDomain.truconetDomain ws = new truconetDomain.truconetDomain();

        //    return ws.consultaPartidoJugadores(listaJugadores);

        //}


        public static Boolean altaRanking(String nick, String puntaje)
        {
            //TODO Llamar a web-service para realizar ALTA RANKING
            return true;
        }

        public static Boolean editarRanking(String nick, String puntaje)
        {
            //TODO Llamar a web-service para realizar EDITAR RANKING
            return true;
        }

        public static Boolean bajaRanking(String nick)
        {
            //TODO Llamar a web-service para realizar BAJA RANKING
            return true;
        }

        //public static List<truconetDomain.Ranking> consultaRanking()
        //{
        //    //TODO Llamar a web-service para realizar CONSULTA RANKING
        //    List<truconetDomain.Ranking> listaRanking = new List<truconetDomain.Ranking>();
        //    return listaRanking;
        //}

        public static Boolean altaDenuncia(String descripcion)
        {
            //TODO Llamar a web-service para realizar ALTA DENUNCIA
            return true;
        }

        public static Boolean editarDenuncia(int codDenuncia, String descripcion)
        {
            //TODO Llamar a web-service para realizar EDITAR DENUNCIA
            return true;
        }

        public static Boolean bajaDenuncia(int codDenuncia)
        {
            //TODO Llamar a web-service para realizar BAJA DENUNCIA
            return true;
        }

        //public static List<truconetDomain.Denuncia> consultaDenuncia(){
        //    //TODO Llamar a web-service para realizar CONSULTA DENUNCIA
        //    List<truconetDomain.Denuncia> listaDenuncias = new List<truconetDomain.Denuncia>();

        //    return listaDenuncias;
        //}

    }
}
