using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace truconetPersistente
{
    public class UsuarioPersistente: Persistente
    {

        public UsuarioPersistente()
        {
           
        }

        public Boolean alta()
        {
            try
            {
                SqlConnection dbConnection = new SqlConnection(this.conn);
                SqlCommand sqlCom = new SqlCommand("INSERT INTO USUARIOS (Nombre, Apellido, Telefono,EMail,IdCredencial) VALUES (@Val1, @Val2, @Val3, @Val4, @Val5)", dbConnection);

                sqlCom.Parameters.Add("@Val1",SqlDbType.Text).Value = "Gustavo";
                sqlCom.Parameters.Add("@Val2", SqlDbType.Text).Value = "Leites";
                sqlCom.Parameters.Add("@Val3", SqlDbType.Text).Value = "898989";
                sqlCom.Parameters.Add("@Val4", SqlDbType.Text).Value = "gus@mimail.com";

                SqlDataAdapter dbDataAdapter = new SqlDataAdapter();
                dbDataAdapter.InsertCommand = sqlCom;

                DataSet dsUsuarios = new DataSet();

                dbDataAdapter.Update(dsUsuarios.Tables("USUARIOS")); 
                //dbDataAdapter.Fill(dsUsuarios,"USUARIOS");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }



    }
}
