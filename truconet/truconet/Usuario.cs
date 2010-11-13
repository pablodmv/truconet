using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace truconet
{
    public class Usuario
    {

        private int id;
        private Credencial credencial;
        private String nombre;
        private String apellido;
        private String telefono;
        private String eMail;


        //Constructores
        public Usuario()
        {
        }

        //Getters y Setters

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }



        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private Credencial Credencial
        {
            get { return credencial; }
            set { credencial = value; }
        }
    }
}
