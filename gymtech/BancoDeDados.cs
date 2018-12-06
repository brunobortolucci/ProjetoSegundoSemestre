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
        Conexao conexao = new Conexao();


        //dados usuario     

        private int _id;
        private int _idUsuario;
        private string _loginUsuario;
        private string _senhaUsuario;
        private string _nomeUsuario;
        private string _cpfUsuario;
        private string _rg;
        private string _dataUsuario;
        private string _enderecoRua;
        private string _enderecoNum;
        private string _enderecoCom;
        private string _cep;
        private string _bairro;
        private string _celular; 

        //variaveis uteis
        private string _stringSelect;
        private string _stringInsert;
        private string _stringUpdate;
        private int _valorPermissao;
        private string _controle;
        private string _comparacao;
        private string _maxid;        
        private bool _encontrouLogin;
        private string _retorno;


        //dados treino
        private string _exercicio;
        private string _nivel;
        private double _peso;
        private int _series;
        private int _repeticoes;

        //dados fichatreino
        private string _tipSang;
        private double _pesoUsuario;
        private double _alturaUsuario;
        private int _idPerna;
        private int _idOmbro;
        private int _idCostas;
        private int _idBiceps;
        private int _idTriceps;
        private int _idPeito;

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

        public void cadastrarAluno(string select, string insert, int permissao, string nome, string cpf, string rg, string endrua, string endnum, string endcomp, string cep, string bairro, string data, string celular, string login, string senha, int id, Conexao conexao)
        {
            //insert into aluno(nome, cpf, rg, endereco_rua, endereco_num, endereco_comp, cep, bairro, data_nasc, celular, id_user)

            _stringSelect = select;
            _stringSelect = insert;
            _nomeUsuario = nome;
            _cpfUsuario = cpf;
            _rg = rg;
            _enderecoRua = endrua;
            _enderecoNum = endnum;
            _enderecoCom = endcomp;
            _cep = cep;
            _bairro = bairro;
            _dataUsuario = data;
            _celular = celular;
            _loginUsuario = login;
            _senhaUsuario = senha;
            _id = id;
            _valorPermissao = permissao;

            _valorPermissao = 2;

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
                _stringInsert = "INSERT INTO aluno(nome, cpf, rg, endereco_rua, endereco_num, endereco_comp, cep, bairro, data_nasc, celular, id_user)" +
                    " VALUES (:nome, :cpf, :rg, :endereco_rua, :endereco_num, :endereco_comp, :cep, :bairro, :data_nasc, :celular, :id_user)";

                NpgsqlCommand inserir_professor = new NpgsqlCommand(_stringInsert, conexao.conn);
                inserir_professor.Parameters.Add(new NpgsqlParameter("nome", _nomeUsuario));
                inserir_professor.Parameters.Add(new NpgsqlParameter("cpf", _cpfUsuario));
                inserir_professor.Parameters.Add(new NpgsqlParameter("rg", _rg));
                inserir_professor.Parameters.Add(new NpgsqlParameter("endereco_rua", _enderecoRua));
                inserir_professor.Parameters.Add(new NpgsqlParameter("endereco_num", _enderecoNum));
                inserir_professor.Parameters.Add(new NpgsqlParameter("endereco_comp", _enderecoCom));
                inserir_professor.Parameters.Add(new NpgsqlParameter("cep", _cep));
                inserir_professor.Parameters.Add(new NpgsqlParameter("bairro", _bairro));
                inserir_professor.Parameters.Add(new NpgsqlParameter("data_nasc", _dataUsuario));
                inserir_professor.Parameters.Add(new NpgsqlParameter("celular", _celular));
                inserir_professor.Parameters.Add(new NpgsqlParameter("id_user", _id));
                inserir_professor.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Usuario Cadastrado!");

            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void buscarAlunoNome(string select, string nome, string retorno, Conexao conexao)
        {
            _stringSelect = select;
            _nomeUsuario = nome;
            _retorno = retorno;

            _stringSelect = "SELECT nome FROM aluno WHERE nome = '" + _nomeUsuario + "'";

            NpgsqlCommand buscanome = new NpgsqlCommand(_stringSelect, conexao.conn);
            _retorno = Convert.ToString(buscanome.ExecuteScalar());
        }

        public void buscarAlunoCpf(string select, string cpf, string retorno, Conexao conexao)
        {
            _stringSelect = select;
            _cpfUsuario = cpf;
            _retorno = retorno;

            _stringSelect = "SELECT nome FROM aluno WHERE cpf = '" + _cpfUsuario + "'";
            NpgsqlCommand buscacpf = new NpgsqlCommand(_stringSelect, conexao.conn);
            _retorno = Convert.ToString(buscacpf.ExecuteScalar());
        }

        public void cadastrarTreinoPerna(string select, string insert, string nivel, string exericio, double peso, int series, int repeticoes, Conexao conexao)
        {
            _stringSelect = select;
            _stringInsert = insert;
            _nivel = nivel;
            _exercicio = exericio;
            _peso = peso;
            _series = series;
            _repeticoes = repeticoes;

            try
            {
                _stringInsert = "INSERT INTO treino_perna(nivel, exercicios, peso, series, repeticoes) VALUES (:nivel, :exercicios, :peso, :series, :repeticoes)";
                NpgsqlCommand treino = new NpgsqlCommand(_stringInsert, conexao.conn);
                treino.Parameters.Add(new NpgsqlParameter("nivel", _nivel));
                treino.Parameters.Add(new NpgsqlParameter("exercicios", _exercicio));
                treino.Parameters.Add(new NpgsqlParameter("peso", _peso));
                treino.Parameters.Add(new NpgsqlParameter("series", _series));
                treino.Parameters.Add(new NpgsqlParameter("repeticoes", _repeticoes));
                treino.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Treino Cadastrado!");
            }

            catch(Exception ex)
            {
                throw ex;
            }            

        }

        public void cadastrarTreinoOmbro(string select, string insert, string nivel, string exericio, double peso, int series, int repeticoes, Conexao conexao)
        {
            _stringSelect = select;
            _stringInsert = insert;
            _nivel = nivel;
            _exercicio = exericio;
            _peso = peso;
            _series = series;
            _repeticoes = repeticoes;

            try
            {
                _stringInsert = "INSERT INTO treino_ombro(nivel, exercicios, peso, series, repeticoes) VALUES (:nivel, :exercicios, :peso, :series, :repeticoes)";
                NpgsqlCommand treino = new NpgsqlCommand(_stringInsert, conexao.conn);
                treino.Parameters.Add(new NpgsqlParameter("nivel", _nivel));
                treino.Parameters.Add(new NpgsqlParameter("exercicios", _exercicio));
                treino.Parameters.Add(new NpgsqlParameter("peso", _peso));
                treino.Parameters.Add(new NpgsqlParameter("series", _series));
                treino.Parameters.Add(new NpgsqlParameter("repeticoes", _repeticoes));
                treino.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Treino Cadastrado!");
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void cadastrarTreinoBiceps(string select, string insert, string nivel, string exericio, double peso, int series, int repeticoes, Conexao conexao)
        {
            _stringSelect = select;
            _stringInsert = insert;
            _nivel = nivel;
            _exercicio = exericio;
            _peso = peso;
            _series = series;
            _repeticoes = repeticoes;

            try
            {
                _stringInsert = "INSERT INTO treino_biceps(nivel, exercicios, peso, series, repeticoes) VALUES (:nivel, :exercicios, :peso, :series, :repeticoes)";
                NpgsqlCommand treino = new NpgsqlCommand(_stringInsert, conexao.conn);
                treino.Parameters.Add(new NpgsqlParameter("nivel", _nivel));
                treino.Parameters.Add(new NpgsqlParameter("exercicios", _exercicio));
                treino.Parameters.Add(new NpgsqlParameter("peso", _peso));
                treino.Parameters.Add(new NpgsqlParameter("series", _series));
                treino.Parameters.Add(new NpgsqlParameter("repeticoes", _repeticoes));
                treino.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Treino Cadastrado!");
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void cadastrarTreinoCostas(string select, string insert, string nivel, string exericio, double peso, int series, int repeticoes, Conexao conexao)
        {
            _stringSelect = select;
            _stringInsert = insert;
            _nivel = nivel;
            _exercicio = exericio;
            _peso = peso;
            _series = series;
            _repeticoes = repeticoes;

            try
            {
                _stringInsert = "INSERT INTO treino_costas(nivel, exercicios, peso, series, repeticoes) VALUES (:nivel, :exercicios, :peso, :series, :repeticoes)";
                NpgsqlCommand treino = new NpgsqlCommand(_stringInsert, conexao.conn);
                treino.Parameters.Add(new NpgsqlParameter("nivel", _nivel));
                treino.Parameters.Add(new NpgsqlParameter("exercicios", _exercicio));
                treino.Parameters.Add(new NpgsqlParameter("peso", _peso));
                treino.Parameters.Add(new NpgsqlParameter("series", _series));
                treino.Parameters.Add(new NpgsqlParameter("repeticoes", _repeticoes));
                treino.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Treino Cadastrado!");
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void cadastrarTreinoPeito(string select, string insert, string nivel, string exericio, double peso, int series, int repeticoes, Conexao conexao)
        {
            _stringSelect = select;
            _stringInsert = insert;
            _nivel = nivel;
            _exercicio = exericio;
            _peso = peso;
            _series = series;
            _repeticoes = repeticoes;

            try
            {
                _stringInsert = "INSERT INTO treino_peito(nivel, exercicios, peso, series, repeticoes) VALUES (:nivel, :exercicios, :peso, :series, :repeticoes)";
                NpgsqlCommand treino = new NpgsqlCommand(_stringInsert, conexao.conn);
                treino.Parameters.Add(new NpgsqlParameter("nivel", _nivel));
                treino.Parameters.Add(new NpgsqlParameter("exercicios", _exercicio));
                treino.Parameters.Add(new NpgsqlParameter("peso", _peso));
                treino.Parameters.Add(new NpgsqlParameter("series", _series));
                treino.Parameters.Add(new NpgsqlParameter("repeticoes", _repeticoes));
                treino.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Treino Cadastrado!");
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void cadastrarTreinoTriceps(string select, string insert, string nivel, string exericio, double peso, int series, int repeticoes, Conexao conexao)
        {
            _stringSelect = select;
            _stringInsert = insert;
            _nivel = nivel;
            _exercicio = exericio;
            _peso = peso;
            _series = series;
            _repeticoes = repeticoes;

            try
            {
                _stringInsert = "INSERT INTO treino_triceps(nivel, exercicios, peso, series, repeticoes) VALUES (:nivel, :exercicios, :peso, :series, :repeticoes)";
                NpgsqlCommand treino = new NpgsqlCommand(_stringInsert, conexao.conn);
                treino.Parameters.Add(new NpgsqlParameter("nivel", _nivel));
                treino.Parameters.Add(new NpgsqlParameter("exercicios", _exercicio));
                treino.Parameters.Add(new NpgsqlParameter("peso", _peso));
                treino.Parameters.Add(new NpgsqlParameter("series", _series));
                treino.Parameters.Add(new NpgsqlParameter("repeticoes", _repeticoes));
                treino.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Treino Cadastrado!");
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void atualizarAluno(string update, string nome, string cpf, string rg, string endrua, string endnum, string endcomp, string cep, string bairro, string data, string celular, string login, string senha, int id, int id_user, Conexao conexao)
        {
            _stringUpdate = update;
            _nomeUsuario = nome;
            _cpfUsuario = cpf;
            _rg = rg;
            _enderecoRua = endrua;
            _enderecoNum = endnum;
            _enderecoCom = endcomp;
            _cep = cep;
            _bairro = bairro;
            _dataUsuario = data;
            _celular = celular;
            _loginUsuario = login;
            _senhaUsuario = senha;
            _id = id;
            _idUsuario = id_user;

            try
            {
                _stringUpdate = "UPDATE aluno SET nome = @nome, cpf = @cpf, rg = @rg, endereco_rua = @endereco_rua, endereco_num = @endereco_num, endereco_comp = @endereco_comp, cep = @cep, bairro = @bairro, data_nasc = @data_nasc, celular = @celular WHERE id_aluno = @id";

                NpgsqlCommand atualizar = new NpgsqlCommand(_stringUpdate, conexao.conn);
                atualizar.Parameters.Add(new NpgsqlParameter("@nome", _nomeUsuario));
                atualizar.Parameters.Add(new NpgsqlParameter("@cpf", _cpfUsuario));
                atualizar.Parameters.Add(new NpgsqlParameter("@rg", _rg));
                atualizar.Parameters.Add(new NpgsqlParameter("@endereco_rua", _enderecoRua));
                atualizar.Parameters.Add(new NpgsqlParameter("@endereco_num", _enderecoNum));
                atualizar.Parameters.Add(new NpgsqlParameter("@endereco_comp", _enderecoCom));
                atualizar.Parameters.Add(new NpgsqlParameter("@cep", _cep));
                atualizar.Parameters.Add(new NpgsqlParameter("@bairro", _bairro));
                atualizar.Parameters.Add(new NpgsqlParameter("@data_nasc", _dataUsuario));
                atualizar.Parameters.Add(new NpgsqlParameter("@celular", _celular));
                atualizar.Parameters.Add(new NpgsqlParameter("@id", _id));
                atualizar.ExecuteNonQuery();

                _stringUpdate = "UPDATE usuarios SET login = @login, senha = @senha WHERE id_user = @id_user";

                NpgsqlCommand attlogin = new NpgsqlCommand(_stringUpdate, conexao.conn);
                attlogin.Parameters.Add(new NpgsqlParameter("@login", _loginUsuario));
                attlogin.Parameters.Add(new NpgsqlParameter("@senha", _senhaUsuario));
                attlogin.Parameters.Add(new NpgsqlParameter("@id_user", _idUsuario));
                attlogin.ExecuteNonQuery();


                System.Windows.Forms.MessageBox.Show("Atualizado!");

            }

            catch(Exception ex)
            {
                throw ex;
            }            

        }

        public void cadastrarFichaTreino(string insert, Conexao conexao, string nome, int id_aluno, double peso_aluno, double altura_aluno, string sang, int idperna, int idombro, int idbiceps, int idcostas, int idpeito, int idtriceps)
        {
            _stringInsert = insert;
            _nomeUsuario = nome;
            _idUsuario = id_aluno;
            _pesoUsuario = peso_aluno;
            _alturaUsuario = altura_aluno;
            _tipSang = sang;
            _idPerna = idperna;
            _idOmbro = idombro;
            _idCostas = idcostas;
            _idBiceps = idbiceps;
            _idTriceps = idtriceps;
            _idPeito = idpeito;

            try
            {
                _stringInsert = "INSERT INTO ficha_treino(nome, aluno, peso, altura, tipo_sang, t_perna, t_ombro, t_biceps, t_costas, t_peito, t_triceps) VALUES(@nome, @aluno, @peso, @altura, @tipo_sang, @t_perna, @t_ombro, @t_biceps, @t_costas, @t_peito, @t_triceps)";

                NpgsqlCommand inserir = new NpgsqlCommand(_stringInsert, conexao.conn);
                inserir.Parameters.Add(new NpgsqlParameter("@nome", _nomeUsuario));
                inserir.Parameters.Add(new NpgsqlParameter("@aluno", _idUsuario));
                inserir.Parameters.Add(new NpgsqlParameter("@peso", _pesoUsuario));
                inserir.Parameters.Add(new NpgsqlParameter("@altura", _alturaUsuario));
                inserir.Parameters.Add(new NpgsqlParameter("@tipo_sang", _tipSang));
                inserir.Parameters.Add(new NpgsqlParameter("@t_perna", _idPerna));
                inserir.Parameters.Add(new NpgsqlParameter("@t_ombro", _idOmbro));
                inserir.Parameters.Add(new NpgsqlParameter("@t_biceps", _idBiceps));
                inserir.Parameters.Add(new NpgsqlParameter("@t_costas", _idCostas));
                inserir.Parameters.Add(new NpgsqlParameter("@t_peito", _idPeito));
                inserir.Parameters.Add(new NpgsqlParameter("@t_triceps", _idTriceps));
                inserir.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Ficha Cadastrada!");

            }

            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
