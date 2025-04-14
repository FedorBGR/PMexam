using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMexam
{
    internal class Database
    {
        private static string connectionString = "Host = localhost; Port = 5432; Username = postgres; Password = Bogorodick200444; Database = PMP";
        
        public static NpgsqlConnection GetConnection()
        {
            var conn = new NpgsqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
