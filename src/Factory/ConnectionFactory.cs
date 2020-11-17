using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Factory
{
    public class ConnectionFactory
    {

        public SqlConnection CriarConexao()
        {
            SqlConnection connection = new SqlConnection("Server=localhost;Initial Catalog=AdventureWorks2017;Integrated Security=SSPI");
            connection.Open();
            return connection;
        }

    }
}
