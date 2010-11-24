using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using truconetPersistente;

namespace truconet
{
    public class Credencial
    {

        private String login;
        private String pass;
        private String nick;
        private Boolean admin;

        private CredencialPersistente credPersist = new CredencialPersistente(); 

        //Constructores
        public Credencial()
        {
        }


        //Getters y Setters

        public Boolean Admin
        {
            get { return admin; }
            set { admin = value; }
        }

        public String Login
        {
            get { return login; }
            set { login = value; }
        }


        public String Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public String Nick
        {
            get { return nick; }
            set { nick = value; }
        }

        public Boolean alta(){
            this.credPersist.alta();
            return true;
        }

    }
}
