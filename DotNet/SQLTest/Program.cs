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
            Console.WriteLine("Accessing the SQL Server database.");

            string connectionString = "Server=localhost;Database=Northwind;User Id=SA;Password=mennaanko%vegepois1928";
            SqlConnection connection = new(connectionString); 

            connection.Open();
            Console.WriteLine("Connection to SQL Server is now open!");
        }
    }
}
