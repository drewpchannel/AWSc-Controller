using System;
using Npgsql;

namespace ConsoleApplication4
{
    //do you need to somehow assign a new instance?  i think c# does that for me
    //maybe id the instance with something random an check on it?
    class sqlLogin
    {
        private NpgsqlConnection _npgsqlConnection = new NpgsqlConnection("Host=34.206.79.166;Port=5432;Username=somethingiffy;Password=rugby123;Database=postgresdb");
        private NpgsqlCommand cmd = new NpgsqlCommand();
        public NpgsqlConnection getConnection()
        {
            return _npgsqlConnection;
        }

        public void recordCoords(string playerId)
        {
            var cmd = new NpgsqlCommand();
            cmd.Connection = this._npgsqlConnection;
            var cmdText = $"INSERT INTO tradeinfo (coords) VALUES ('{playerId}')";
            Console.WriteLine(cmdText);
            cmd.CommandText = cmdText;
            cmd.ExecuteNonQuery();
        }

    }
}
