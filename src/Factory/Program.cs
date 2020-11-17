using System;
using System.Data;
using System.Data.SqlClient;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory");


            using (SqlConnection connection = new ConnectionFactory().CriarConexao())
            {
                SqlCommand command = new SqlCommand("select * from [Person].[ContactType]", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["Name"]);
                }
            }

                        

            Console.ReadKey();
        }
    }
}
