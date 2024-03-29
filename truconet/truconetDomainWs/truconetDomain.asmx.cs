﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

namespace truconetDomainWs
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://truconet/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class truconetDomain : System.Web.Services.WebService
    {

        [WebMethod]
        public int crearPartido(int[] idJugadores)
        {
            truconet.Truco ws= truconet.Truco.getInstance();
            return ws.iniciarPartido(idJugadores, "Partido");

             
        }

        [WebMethod]
        public List<truconet.Jugador> getJugadores()
        {
            truconet.Truco aux = truconet.Truco.getInstance();
            //ArrayList jugadores = new ArrayList();
            //foreach (truconet.Jugador jug in aux.ColJugadores)
            //{
            //    string Jugador = jug.Id + ":" + jug.Nombre + " " + jug.Apellido;
            //    jugadores.Add(Jugador);
            //}
            //return jugadores;
            return aux.ColJugadores;
             

        }

        [WebMethod]
        public List<truconet.Jugador> getJugadorPartido(int idPartido)
        {
            truconet.Truco ws = truconet.Truco.getInstance();
            return ws.participantesPartido(idPartido);
        
        }

        [WebMethod]
        public truconet.Partido getPartido(int idPartido)
        {
            truconet.Truco ws = truconet.Truco.getInstance();
            return ws.getPartido(idPartido);
        
        }


        [WebMethod]
        public List<truconet.Partido> getPartidosPendientes()
        {
            truconet.Truco ws = truconet.Truco.getInstance();
            return ws.getPartidosPendientes();
        
        }


        [WebMethod]
        public bool borrarParticipante(int idJugador, int idPartido)
        {
            truconet.Truco ws = truconet.Truco.getInstance();
            return ws.borrarParticipante(idJugador,idPartido);

        }


        //[WebMethod]
        //public string obtenerCarta()
        //{
        //    truconet.Carta aux = new truconet.Carta();
        //    return aux.descCarta();


        //}


        //Web Methods sobre persistencia


        // Credencial
        [WebMethod]
        public bool altaCredencial()
        {
            truconetPersistente.CredencialPersistente ws = new truconetPersistente.CredencialPersistente();
            return ws.alta();

        }






    }
}
