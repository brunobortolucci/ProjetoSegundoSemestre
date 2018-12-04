﻿using System;
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
        Conexao conexao = new Conexao();


        //dados usuario

        private int _id;
        private string _loginUsuario;
        private string _senhaUsuario;
        private string _nomeUsuario;
        private string _cpfUsuario;
        private string _dataUsuario;

        //variaveis uteis
        private string _stringSelect;
        private string _stringInsert;
        private int _valorPermissao;
        private string _controle;
        private string _comparacao;
        private string _maxid;        
        private bool _encontrouLogin;

        public void autLogin(string select, string loginUsuario, string senhaUsuario, Conexao conexao, bool encontrouLogin, int valorPermissao, string controle)
        {
            frmLogin frmLog = new frmLogin();

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
                    ler_teste.Close();
                }

                else if(_controle != "0")
                {
                    
                    ler_teste.Close();
                    _stringSelect = "SELECT * FROM usuarios WHERE login = '" + _loginUsuario + "' and senha = '" + _senhaUsuario + "' and permissao = 2";

                    //aluno

                    NpgsqlCommand user_aluno = new NpgsqlCommand(_stringSelect, conexao.conn);
                    NpgsqlDataReader ler_aluno = user_aluno.ExecuteReader();

                    if (ler_aluno.Read())
                    {
                        _controle = "2";
                        System.Windows.Forms.MessageBox.Show("Funcionou - Aluno");
                        ler_aluno.Close();
                    }

                    else if (_controle != "2")
                    {
                        ler_aluno.Close();
                        _stringSelect = "SELECT * FROM usuarios WHERE login = '" + _loginUsuario + "' and senha = '" + _senhaUsuario + "' and permissao = 1";

                        //professor

                        NpgsqlCommand user_professor = new NpgsqlCommand(_stringSelect, conexao.conn);
                        NpgsqlDataReader ler_professor = user_professor.ExecuteReader();

                        if (ler_professor.Read())
                        {
                            _controle = "1";
                            System.Windows.Forms.MessageBox.Show("Funcionou - Professor");
                            ler_professor.Close();
                        }

                        else if (_controle != "1")
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

        public void pegarID(string select, int id, string loginUsuario, Conexao conexao)
        {                                    
            this._loginUsuario = loginUsuario;
            this._stringSelect = select;

            _stringSelect = "SELECT id_user FROM usuarios WHERE login = '" + _loginUsuario + "'";

            NpgsqlCommand pegarid = new NpgsqlCommand(_stringSelect, conexao.conn);
            _id = Convert.ToInt32(pegarid.ExecuteScalar());
        }

        public void pegarNomeAdm(string select, string nomeUsuario, int id, string loginUsuario, Conexao conexao)
        {

            this._stringSelect = select;
            this._nomeUsuario = nomeUsuario;
            this._loginUsuario = loginUsuario;
            this._id = id;

            _stringSelect = "SELECT id_user FROM usuarios WHERE login = '" + _loginUsuario + "'";

            NpgsqlCommand pegarid = new NpgsqlCommand(_stringSelect, conexao.conn);
            _id = Convert.ToInt32(pegarid.ExecuteScalar());

            _stringSelect = "SELECT nome FROM administrador WHERE id_user = '" + _id + "'";

            NpgsqlCommand nome = new NpgsqlCommand(_stringSelect, conexao.conn);
            nomeUsuario = nome.ExecuteScalar().ToString();

        }

        public void pegarNomeAluno(string select, string nomeUsuario, int id, string loginUsuario, Conexao conexao)
        {

            this._stringSelect = select;
            this._nomeUsuario = nomeUsuario;
            this._loginUsuario = loginUsuario;
            this._id = id;

            _stringSelect = "SELECT id_user FROM usuarios WHERE login = '" + _loginUsuario + "'";

            NpgsqlCommand pegarid = new NpgsqlCommand(_stringSelect, conexao.conn);
            _id = Convert.ToInt32(pegarid.ExecuteScalar());

            _stringSelect = "SELECT nome FROM aluno WHERE id_user = '" + _id + "'";

            NpgsqlCommand nome = new NpgsqlCommand(_stringSelect, conexao.conn);
            nomeUsuario = nome.ExecuteScalar().ToString();

        }

        public void pegarNomeProfessor(string select, string nomeUsuario, int id, string loginUsuario, Conexao conexao)
        {
            this._stringSelect = select;
            this._nomeUsuario = nomeUsuario;
            this._loginUsuario = loginUsuario;
            this._id = id;

            _stringSelect = "SELECT id_user FROM usuarios WHERE login = '" + _loginUsuario + "'";

            NpgsqlCommand pegarid = new NpgsqlCommand(_stringSelect, conexao.conn);
            _id = Convert.ToInt32(pegarid.ExecuteScalar());

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

        public void verificarLogin(string select, string loginUsuario, bool encontrou, string comparacao, Conexao conexao)
        {
            _stringSelect = select;
            _loginUsuario = loginUsuario;
            _encontrouLogin = encontrou;
            _comparacao = comparacao;
            

            _encontrouLogin = false;

            _stringSelect = "SELECT senha FROM usuarios where senha = '" + _loginUsuario + "'";

            NpgsqlCommand verificarlogin = new NpgsqlCommand(_stringSelect, conexao.conn);
            _comparacao = verificarlogin.ExecuteScalar().ToString();
            

            if (_comparacao == _loginUsuario)
            {
                _encontrouLogin = true;
                System.Windows.Forms.MessageBox.Show("Usuario ja existe!");
            }
            else if(_encontrouLogin == false)
            {
                System.Windows.Forms.MessageBox.Show("Usuario disponivel!");
            }

        }

        public void cadastrarProfessor(string select, string insert, string nome, string cpf, string data, string loginUsuario, string senhaUsuario, int permissao, int idUsuario, Conexao conexao)
        {
            _stringSelect = select;
            _stringInsert = insert;
            _nomeUsuario = nome;
            _cpfUsuario = cpf;
            _dataUsuario = data;
            _loginUsuario = loginUsuario;
            _senhaUsuario = senhaUsuario;
            _valorPermissao = permissao;
            _id = idUsuario;

            _valorPermissao = 1;

            try
            {
                _stringInsert = "INSERT INTO usuarios(login, senha, permissao) VALUES (:login, :senha, :permissao)";
                NpgsqlCommand inserir_usuario = new NpgsqlCommand(_stringInsert, conexao.conn);
                inserir_usuario.Parameters.Add(new NpgsqlParameter("login", _loginUsuario));
                inserir_usuario.Parameters.Add(new NpgsqlParameter("senha", _senhaUsuario));
                inserir_usuario.Parameters.Add(new NpgsqlParameter("permissao", _valorPermissao));
                inserir_usuario.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }                    
            
            _stringSelect = "SELECT MAX(id_user) FROM usuarios";

            NpgsqlCommand pegarmaxid = new NpgsqlCommand(_stringSelect, conexao.conn);
            _id = Convert.ToInt32(pegarmaxid.ExecuteScalar());

            try
            {
                _stringInsert = "INSERT INTO professor (nome, cpf, data_nasc, id_user) VALUES (:nome, :cpf, :data_nasc, :id_user)";

                NpgsqlCommand inserir_professor = new NpgsqlCommand(_stringInsert, conexao.conn);
                inserir_professor.Parameters.Add(new NpgsqlParameter("nome", _nomeUsuario));
                inserir_professor.Parameters.Add(new NpgsqlParameter("cpf", _cpfUsuario));
                inserir_professor.Parameters.Add(new NpgsqlParameter("data_nasc", _dataUsuario));
                inserir_professor.Parameters.Add(new NpgsqlParameter("id_user", _id));
                inserir_professor.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Usuario Cadastrado!");

            }

            catch (Exception ex)
            {
                throw ex;
            }

            
        }
    }
}
