using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace gymtech
{
    class Conexao
    {
        public NpgsqlConnection conn = new NpgsqlConnection();

        public void conectar()
        {
            conn.ConnectionString = @"Host=127.0.0.1;Username=postgres;Password=Palmeiras1914!;Database=academia";

            conn.Open();
        }

        public void desconectar()
        {
            conn.Close();
        }
    }
}
