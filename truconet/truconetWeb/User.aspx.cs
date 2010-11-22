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

namespace truconetWeb
{
    public partial class User : System.Web.UI.Page
    {
                   

        protected void Page_Load(object sender, EventArgs e)
        {
            this.cargarJugadorSistema();

            
            
            
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
            this.lsbJugSistema.Items.Clear();
            truconetFachadaProxy.truconetFachada ws = new truconetFachadaProxy.truconetFachada();
            //List<truconetFachadaProxy.Jugador> jugSistema = new List<truconetFachadaProxy.Jugador>(ws.obtenerJugadores());
            List<truconetFachadaProxy.Jugador> jugadores = new List<truconetFachadaProxy.Jugador>();
            jugadores = new List<truconetFachadaProxy.Jugador>(ws.obtenerJugadores());
            foreach (truconetFachadaProxy.Jugador jug in ws.obtenerJugadores())
            {
                this.lsbJugSistema.Items.Add(jug.Nombre + " " + jug.Apellido);

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
            this.lbIdPartido.Text = ws.crearPartido().ToString();
            this.cargarListParticipantes();
            this.cargarPartidos();
            
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
                    
                    this.TextBox1.Text += carta.Numero + " " + carta.Palo + " Cat: " + carta.Categoria + " P: " + carta.Puntaje + " -- ";
                }

                
            }
            this.TextBox1.Text += " Muestra: " + ws.getPartido(idPartido).Muestra.Palo;
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

       
    }
}
