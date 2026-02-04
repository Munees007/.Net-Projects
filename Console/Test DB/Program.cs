using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace Test_DB
{
    internal class Program
    {
        static string connectionString = "Server=localhost;Port=3306;Database=javadb;User=root;Password=Muneesw@r@n8072.p;";
        static void Main(string[] args)
        {
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();

            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM Customers", sqlConnection);
            using (MySqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader["CustomerID"].ToString());
                    Console.WriteLine(reader["Name"].ToString());
                }
            }

            //MySqlCommand insertQuery = new MySqlCommand("INSERT INTO Customers (CustomerID, Name) VALUES (@CustomerID, @Name)", sqlConnection);
            //using (insertQuery)
            //{
            //    insertQuery.Parameters.AddWithValue("@CustomerID", "MW0000000002");
            //    insertQuery.Parameters.AddWithValue("@Name", "Karthik Balan");
            //    int rowsAffected = insertQuery.ExecuteNonQuery();
            //    Console.WriteLine($"{rowsAffected} row(s) inserted.");
            //}
            sqlConnection.Close();
        }
    }
}
