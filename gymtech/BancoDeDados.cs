using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace gymtech
{
    class BancoDeDados
    {
        //objetos
        Conexao _conexao = new Conexao();        


        //todos os comandos de banco de dados

        private string _stringSelect;
        private string _loginUsuario;
        private string _senhaUsuario;
        private string _nomeUsuario;
        private bool _encontrouLogin;
        private int _valorPermissao;
        private string _controle;
        private string _id;
        private string _maxid;


        public void autLogin(string select, string loginUsuario, string senhaUsuario, Conexao conexao, bool encontrouLogin, int valorPermissao, string controle)
        {
            frmLogin frmLog = new frmLogin();
            frmAdministrador frmAdm = new frmAdministrador();

            this._stringSelect = select;
            this._loginUsuario = loginUsuario;
            this._senhaUsuario = senhaUsuario;
            this._valorPermissao = valorPermissao;
            this._controle = controle;

            _encontrouLogin = false;
            _stringSelect = "SELECT * FROM usuarios WHERE login = '" + _loginUsuario + "' and senha = '" + _senhaUsuario + "'";

            NpgsqlCommand cmd = new NpgsqlCommand(_stringSelect, conexao.conn);

            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                _encontrouLogin = true;
                dr.Close();                

                _stringSelect = "SELECT * FROM usuarios WHERE login = '" + _loginUsuario + "' and senha = '" + _senhaUsuario + "' and permissao = 0";
                NpgsqlCommand user_teste = new NpgsqlCommand(_stringSelect, conexao.conn);
                NpgsqlDataReader ler_teste = user_teste.ExecuteReader();

                if (ler_teste.Read())
                {
                    _controle = "0";
                    frmAdm.Show();
                    ler_teste.Close();

                }

                else if(_controle != "0")
                {
                    
                    ler_teste.Close();
                    _stringSelect = "SELECT * FROM usuarios WHERE login = '" + _loginUsuario + "' and senha = '" + _senhaUsuario + "' and permissao = 1";

                    //aluno

                    NpgsqlCommand user_aluno = new NpgsqlCommand(_stringSelect, conexao.conn);
                    NpgsqlDataReader ler_aluno = user_aluno.ExecuteReader();

                    if (ler_aluno.Read())
                    {
                        _controle = "1";
                        System.Windows.Forms.MessageBox.Show("Funcionou - Aluno");
                        ler_aluno.Close();
                    }

                    else if (_controle != "1")
                    {
                        ler_aluno.Close();
                        _stringSelect = "SELECT * FROM usuarios WHERE login = '" + _loginUsuario + "' and senha = '" + _senhaUsuario + "' and permissao = 2";

                        //professor

                        NpgsqlCommand user_professor = new NpgsqlCommand(_stringSelect, conexao.conn);
                        NpgsqlDataReader ler_professor = user_professor.ExecuteReader();

                        if (ler_professor.Read())
                        {
                            _controle = "2";
                            System.Windows.Forms.MessageBox.Show("Funcionou - Professor");
                            ler_professor.Close();
                        }

                        else if (_controle != "2")
                        {
                            ler_professor.Close();                            
                        }
                    }

                }                                

            }

            else if (_encontrouLogin == false)
            {
                System.Windows.Forms.MessageBox.Show("Login e/ou senha incorretos");
                conexao.desconectar();
                conexao.conectar();
            }
        }

        public void pegarID(string select, string id, string loginUsuario, Conexao conexao)
        {

            this._id = id;
            this._loginUsuario = loginUsuario;
            this._stringSelect = select;

            _stringSelect = "SELECT id_user FROM usuarios WHERE login = '" + _loginUsuario + "'";

            NpgsqlCommand pegarid = new NpgsqlCommand(_stringSelect, conexao.conn);
            _id = pegarid.ExecuteScalar().ToString();

            _id.ToString();

        }

        public void pegarNomeAdm(string select, string nomeUsuario, string id, string loginUsuario, Conexao conexao)
        {

            this._stringSelect = select;
            this._nomeUsuario = nomeUsuario;
            this._loginUsuario = loginUsuario;
            this._id = id;

            _stringSelect = "SELECT id_user FROM usuarios WHERE login = '" + _loginUsuario + "'";

            NpgsqlCommand pegarid = new NpgsqlCommand(_stringSelect, conexao.conn);
            _id = pegarid.ExecuteScalar().ToString();

            _stringSelect = "SELECT nome FROM administrador WHERE id_user = '" + _id + "'";

            NpgsqlCommand nome = new NpgsqlCommand(_stringSelect, conexao.conn);
            nomeUsuario = nome.ExecuteScalar().ToString();

        }

        public void pegarNomeAluno(string select, string nomeUsuario, string id, string loginUsuario, Conexao conexao)
        {

            this._stringSelect = select;
            this._nomeUsuario = nomeUsuario;
            this._loginUsuario = loginUsuario;
            this._id = id;

            _stringSelect = "SELECT id_user FROM usuarios WHERE login = '" + _loginUsuario + "'";

            NpgsqlCommand pegarid = new NpgsqlCommand(_stringSelect, conexao.conn);
            _id = pegarid.ExecuteScalar().ToString();

            _stringSelect = "SELECT nome FROM aluno WHERE id_user = '" + _id + "'";

            NpgsqlCommand nome = new NpgsqlCommand(_stringSelect, conexao.conn);
            nomeUsuario = nome.ExecuteScalar().ToString();

        }

        public void pegarNomeProfessor(string select, string nomeUsuario, string id, string loginUsuario, Conexao conexao)
        {
            this._stringSelect = select;
            this._nomeUsuario = nomeUsuario;
            this._loginUsuario = loginUsuario;
            this._id = id;

            _stringSelect = "SELECT id_user FROM usuarios WHERE login = '" + _loginUsuario + "'";

            NpgsqlCommand pegarid = new NpgsqlCommand(_stringSelect, conexao.conn);
            _id = pegarid.ExecuteScalar().ToString();

            _stringSelect = "SELECT nome FROM professor WHERE id_user = '" + _id + "'";

            NpgsqlCommand nome = new NpgsqlCommand(_stringSelect, conexao.conn);
            nomeUsuario = nome.ExecuteScalar().ToString();
        }


        public void pegarMaiorID(string select, string id, Conexao conexao)
        {
            _stringSelect = select;
            _maxid = id;

            _stringSelect = "SELECT MAX(id_user) FROM usuarios";

            NpgsqlCommand pegarmaxid = new NpgsqlCommand(_stringSelect, conexao.conn);
            _maxid = pegarmaxid.ExecuteScalar().ToString();
        }
    }
}
