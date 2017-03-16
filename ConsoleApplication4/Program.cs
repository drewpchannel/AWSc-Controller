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

            string simple = "{435, 982}";
            sqlServer.recordCoords(simple);

            var cmdRead = new NpgsqlCommand();
            cmdRead.Connection = conn;
            cmdRead.CommandText = "SELECT * FROM tradeinfo";
            var queryText = cmdRead.ExecuteReader();

            Console.WriteLine(queryText.Read());
            Console.WriteLine(queryText.GetString(0));
        }
    }
}
