using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;


namespace truconet
{
    public class DataLayer
    {
        private string connStr;

        public DataLayer()
        {
            this.connStr = "integrated security=SSPI;data source=GUSTAVOLEITES1\SQLEXPRESS;initial catalog=truconetDB";
        }








    }
}
