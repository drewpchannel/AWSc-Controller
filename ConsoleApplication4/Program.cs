using System;
using Npgsql;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlServer = new sqlLogin();
            var conn = sqlServer.getConnection();
            conn.Open();

            string simple = "whatever'); drop table data; INSERT INTO data (some_field) VALUES ('anything";
            sqlServer.recordCoords(simple);

            var cmdRead = new NpgsqlCommand();
            cmdRead.Connection = conn;
            cmdRead.CommandText = "SELECT * FROM data";
            var queryText = cmdRead.ExecuteReader();

            Console.WriteLine(queryText.Read());
            Console.WriteLine(queryText.GetString(0));
        }
    }
}
