using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
    using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Web.Util;


namespace truconetWeb
{
    public partial class User : System.Web.UI.Page
    {

        public static bool pepe = false;

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        //protected void btnCartas_Click(object sender, EventArgs e)
        //{
        //    truconetFachada.truconetFachada ws = new truconetFachada.truconetFachada();
        //    this.TextBox1.Text= ws.holaPablo();
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void listaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void cargarJugadorSistema()
        {
            this.listaJugSistema.Items.Clear();
            truconetFachadaProxy.truconetFachada ws = new truconetFachadaProxy.truconetFachada();
            //List<truconetFachadaProxy.Jugador> jugSistema = new List<truconetFachadaProxy.Jugador>(ws.obtenerJugadores());
            List<truconetFachadaProxy.Jugador> jugadores = new List<truconetFachadaProxy.Jugador>();
            jugadores = new List<truconetFachadaProxy.Jugador>(ws.obtenerJugadores());
            foreach (truconetFachadaProxy.Jugador jug in ws.obtenerJugadores())
            {
                this.listaJugSistema.Items.Add(jug.Id + ":"+jug.Nombre + " " + jug.Apellido);

            }
        
        
        }

        protected void btnCartas_Click(object sender, EventArgs e)
        {
            char[] p = { ':' };
            int participante = int.Parse(this.listaUsuarios.SelectedItem.ToString().Split(p)[0]);
            int Partido = int.Parse(this.lbIdPartido.Text);
            truconetFachadaProxy.truconetFachada ws = new truconetFachadaProxy.truconetFachada();
            ws.borrarParticipante(participante, Partido);
            this.TextBox1.Text = "";
            this.cargarListParticipantes();
            this.cargarPartidos();
        }

        protected void iniciarPartido_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text = "";
            truconetFachadaProxy.truconetFachada ws = new truconetFachadaProxy.truconetFachada();
            ArrayList items = new ArrayList(this.listaInvitados.Items);
            int[] idJugador = new int[items.Count];
            char[] p = { ':' };
            for (int i = 0; i < items.Count; i++)
            {
                idJugador[i] = int.Parse(items[i].ToString().Split(p)[0]);
                
            }
            ws.crearPartido(idJugador);
            //this.lbIdPartido.Text = ws.crearPartido().ToString();
            this.cargarListParticipantes();
            this.cargarPartidos();
            this.cargarJugadorSistema();
           // Page.ClientScript.RegisterStartupScript(typeof(Page), "myScript", "alert('Your Alert Message')", true);
            
        }

        private void cargarPartidos()
        {
            this.lstPartidos.Items.Clear();
            truconetFachadaProxy.truconetFachada ws = new truconetFachadaProxy.truconetFachada();
            List<truconetFachadaProxy.Partido> partidos = new List<truconetFachadaProxy.Partido>(ws.getPartidosPendientes());
            foreach (truconetFachadaProxy.Partido game in partidos)
            {
                if (game.Participantes.Length==2)
                {
                    lstPartidos.Items.Add(game.Id.ToString());
                 }
                else
                {
                    lstPartidos.Items.Add(game.Id.ToString() + " * ");
                }
                
                
            }
        }

        private void cargarListParticipantes()
        {
            this.TextBox1.Text = "";
            this.listaUsuarios.Items.Clear();
            int idPartido = int.Parse(this.lbIdPartido.Text);
            truconetFachadaProxy.truconetFachada ws = new truconetFachadaProxy.truconetFachada();

            List<truconetFachadaProxy.Jugador> jugadores = new List<truconetFachadaProxy.Jugador>(ws.getjugadorPartido(idPartido));
            foreach (truconetFachadaProxy.Jugador Jug in jugadores)
            {
                
                listaUsuarios.Items.Add(Jug.Id + ":" + Jug.Nombre + " " + Jug.Apellido + " " + jugadores.Count);
                foreach (truconetFachadaProxy.Carta carta in Jug.Mano.Cartas)
                {
                    
                    //this.TextBox1.Text += carta.Numero + " " + carta.Palo + " Cat: " + carta.Categoria + " P: " + carta.Puntaje + " -- ";
                    this.TextBox1.Text += this.descCarta(carta)+ " ";
                }
                this.TextBox1.Text += " ### Jugada: " +Jug.Mano.Jugada.ToString() + " P: " + Jug.Mano.Puntos.ToString() + " ";

                
            }
            this.lbMuestra.Text = this.descCarta( ws.getPartido(idPartido).Muestra);
            //int tmpcard = ws.getPartido(int.Parse(this.idPartido.Text)).MasoJuego.Length;
            //this.TextBox1.Text = tmpcard.ToString();
           // this.TextBox1.Text = jugadores[0].Mano.Cartas[0].Numero + " " + jugadores[0].Mano.Cartas[0].Palo;
            
                
                
        }

        protected void lstPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            char[] p = { ' ' };
            this.lbIdPartido.Text = this.lstPartidos.SelectedItem.Text.Split(p)[0];
            this.cargarListParticipantes();

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            char[] p = { ':' };
            //string seleccion = this.listaJugSistema.SelectedItem.Text.Split(p)[0];
            //this.lbIdPartido.Text = ;
            //int hola = this.listaJugSistema.Items.Count;
            if (!(this.listaInvitados.Items.Contains(this.listaJugSistema.SelectedItem)))
            {
                this.listaInvitados.Items.Add(this.listaJugSistema.SelectedItem.Text);     
            }
            
        }

        protected void lsbJugSistema_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void listaInvitados_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text = "";
            truconetFachadaProxy.truconetFachada ws = new truconetFachadaProxy.truconetFachada();
            int[] pepe = { 0, 1 };
            this.lbIdPartido.Text = ws.crearPartido(pepe).ToString();
            this.cargarListParticipantes();
            this.cargarPartidos();
            this.cargarJugadorSistema();
        }




        private string strPalo(int palo)
        {
            if (palo == 1)
            {
                return "Oro";
            }

            if (palo == 2)
            {
                return "Copa";
            }

            if (palo == 3)
            {
                return "Basto";
            }

            if (palo == 4)
            {
                return "Espada";
            }
            return "Sin palo";
        }

       
        public string descCarta(truconetFachadaProxy.Carta carta)
        {
            return carta.Numero + "-" + this.strPalo(carta.Palo);// +carta.Categoria.ToString() + carta.Puntaje.ToString();
        }

       
    }
}
