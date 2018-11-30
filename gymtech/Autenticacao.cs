using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace gymtech
{
    class Autenticacao
    {
        string login;
        string senha;


        //metodo para fazer login
        public void logar(string login1, string senha1)
        {

            login = login1;
            senha = senha1;

        }

        public void deslogar()
        {
            login = null;
            senha = null;
        }

        public string getUser()
        {
            return "Login: " + login + "\nSenha: " + senha;
        }

    }
}
