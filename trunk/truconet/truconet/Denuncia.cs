using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace truconet
{
    public class Denuncia
    {
        private int codDenuncia;
        private String desDenuncia;

        //Constructores
        public Denuncia()
        {
        }


        //Getters y Setters
        public String DesDenuncia
        {
            get { return desDenuncia; }
            set { desDenuncia = value; }
        }

        public int CodDenuncia
        {
            get { return codDenuncia; }
            set { codDenuncia = value; }
        }



    }
}
