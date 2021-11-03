/*
Practice 1. C# and Northwind. Investigate how you can use .NET built-in classes called 
SqlConnection and SqlCommand to access your Northwind database.

Write C# code to read all Finnish customers from the Northwind database 
and print out those company names.
*/


using System;
using System.Data.SqlClient;

namespace DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // establish connection to the database
            Console.WriteLine("Accessing the SQL Server database.");

            string connectionString = "Server=localhost;Database=Northwind;User Id=SA;Password=mennaanko%vegepois1928";
            SqlConnection connection = new(connectionString); 

            connection.Open();
            Console.WriteLine("Connection to SQL Server is now open!");

            // execute the SQL query
            string sql = "SELECT * FROM Customers WHERE Country = 'Finland'";
            SqlCommand command = new(sql, connection); // executing sql statmenet against the connection that refers to the database
            SqlDataReader reader = command.ExecuteReader();

            // process the results
            while (reader.Read()) // boolean, while the reader reads, read the company name and display in console
            {
                string name = reader["CompanyName"].ToString();
                Console.WriteLine(name);
            }
        }
    }
}
