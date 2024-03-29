﻿using System;
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
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "INSERT INTO CREDENCIALES (Login, Password, Nick, Admin) VALUES (@Val1, @Val2, @Val3, @Val4)";
                sqlCom.Parameters.Add("@Val1", SqlDbType.Text).Value = "Gustavo";
                sqlCom.Parameters.Add("@Val2", SqlDbType.Text).Value = "Leites";
                sqlCom.Parameters.Add("@Val3", SqlDbType.Text).Value = "gus";
                sqlCom.Parameters.Add("@Val4", SqlDbType.Bit).Value = 0;
                sqlCom.Connection = dbConnection;
                dbConnection.Open();
                sqlCom.ExecuteNonQuery();
                dbConnection.Close();
                
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
