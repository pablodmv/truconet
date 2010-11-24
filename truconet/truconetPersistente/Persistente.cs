using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace truconetPersistente
{
    public class Persistente
    {
        protected String conn = "integrated security=SSPI;data source=GUSTAVOLEITES1\\SQLEXPRESS;initial catalog=truconetDB";

        public Persistente()
		{
			
		}

    }
}
