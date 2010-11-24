using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace truconetPersistente
{
    public class CredencialPersistente: Persistente
    {



        public Boolean alta()
        {
            try
            {
                SqlConnection dbConnection = new SqlConnection(this.conn);
                SqlCommand sqlCom = new SqlCommand("INSERT INTO CREDENCIALES (Login, Password, Nick, Admin) VALUES (@Val1, @Val2, @Val3, @Val4)", dbConnection);

                sqlCom.Parameters.Add("@Val1", SqlDbType.Text).Value = "Gustavo";
                sqlCom.Parameters.Add("@Val2", SqlDbType.Text).Value = "Leites";
                sqlCom.Parameters.Add("@Val3", SqlDbType.Text).Value = "gus";
                sqlCom.Parameters.Add("@Val4", SqlDbType.Bit).Value = 0;

                SqlDataAdapter dbDataAdapter = new SqlDataAdapter();
                dbDataAdapter.InsertCommand = sqlCom;

                DataSet dsUsuarios = new DataSet();

                dbDataAdapter.Update(dsUsuarios,"CREDENCIALES");
                //dbDataAdapter.Fill(dsUsuarios,"USUARIOS");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }
    }
}
