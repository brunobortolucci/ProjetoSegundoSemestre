using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace gymtech
{
    public partial class frmLogin : Form
    {       

        public frmLogin()
        {
            InitializeComponent();
        }

        Conexao conexao = new Conexao();
        frmRecepcao frmrec = new frmRecepcao();
        Consultas consulta = new Consultas();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conexao.conectar();                       
            
        }       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool encontrou = false;


            //strings de armazenamento de informacoes
            string textouser = txbUser.Text;
            string textosenha = txbPassword.Text;
            string id_user;

            //string de buscar login
            string slcLogin = "SELECT * FROM usuarios WHERE login = '" + textouser + "' and senha = '" + textosenha + "'";

            NpgsqlCommand cmd = new NpgsqlCommand(slcLogin, conexao.conn);
                        
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                encontrou = true;
                dr.Close();

                string permissao = "SELECT * FROM usuarios WHERE login = '" + textouser + "' and senha = '" + textosenha + "' and permissao = 0";
                string permissaoaluno = "SELECT * FROM usuarios WHERE login = '" + textouser + "' and senha = '" + textosenha + "' and permissao = 1";
                string permissaoprofessor = "SELECT * FROM usuarios WHERE login = '" + textouser + "' and senha = '" + textosenha + "' and permissao = 2";
                string permissaorecepcao = "SELECT * FROM usuarios WHERE login = '" + textouser + "' and senha = '" + textosenha + "' and permissao = 3";
                NpgsqlCommand user_teste = new NpgsqlCommand(permissao, conexao.conn);
                NpgsqlDataReader ler_teste = user_teste.ExecuteReader();

                if (ler_teste.Read())
                {
                    MessageBox.Show("Funcionou - Teste");
                    ler_teste.Close();

                    //armazenar id para identificacao nos proximos forms
                    NpgsqlCommand id = new NpgsqlCommand("SELECT id_user FROM usuarios where login = '" + textouser + "'", conexao.conn);
                    id_user = id.ExecuteScalar().ToString();
                    MessageBox.Show("" + id_user + "");

                }

                else
                {
                    ler_teste.Close();
                }

                //aluno

                NpgsqlCommand user_aluno = new NpgsqlCommand(permissaoaluno, conexao.conn);
                NpgsqlDataReader ler_aluno = user_aluno.ExecuteReader();

                if (ler_aluno.Read())
                {
                    MessageBox.Show("Funcionou - Aluno");
                    ler_aluno.Close();

                    //armazenar id para identificacao nos proximos forms
                    NpgsqlCommand id = new NpgsqlCommand("SELECT id_user FROM usuarios where login = '" + textouser + "'", conexao.conn);
                    id_user = id.ExecuteScalar().ToString();
                    MessageBox.Show("" + id_user + "");
                }

                else
                {
                    ler_aluno.Close();
                }

                //professor

                NpgsqlCommand user_professor = new NpgsqlCommand(permissaoprofessor, conexao.conn);
                NpgsqlDataReader ler_professor = user_professor.ExecuteReader();

                if (ler_professor.Read())
                {
                    MessageBox.Show("Funcionou - Professor");
                    ler_professor.Close();

                    //armazenar id para identificacao nos proximos forms
                    NpgsqlCommand id = new NpgsqlCommand("SELECT id_user FROM usuarios where login = '" + textouser + "'", conexao.conn);
                    id_user = id.ExecuteScalar().ToString();
                    MessageBox.Show("" + id_user + "");
                }

                else
                {
                    ler_professor.Close();
                }

                //recepcao

                NpgsqlCommand user_recepcao = new NpgsqlCommand(permissaorecepcao, conexao.conn);
                NpgsqlDataReader ler_recepcao = user_recepcao.ExecuteReader();

                if (ler_recepcao.Read())
                {
                    MessageBox.Show("Funcionou - Recepção");
                    ler_recepcao.Close();

                    //armazenar id para identificacao nos proximos forms
                    NpgsqlCommand id = new NpgsqlCommand("SELECT id_user FROM usuarios where login = '" + textouser + "'", conexao.conn);
                    id_user = id.ExecuteScalar().ToString();
                    MessageBox.Show("" + id_user + "");

                    this.Hide();
                    frmrec.Show();
                }

                else
                {
                    ler_recepcao.Close();
                }

            }

            else if(encontrou == false)
            {
                MessageBox.Show("Login e/ou senha incorretos");
                conexao.desconectar();
                conexao.conectar();
            }            

        }        
        
        private void lblEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Por favor, contate a recepção!");
        }

        private void checkSenha_CheckedChanged(object sender, EventArgs e)
        {
            if(checkSenha.Checked == true)
            {
                txbPassword.UseSystemPasswordChar = false;
            }

            else
            {
                txbPassword.UseSystemPasswordChar = true;
            }

        }
    }
}
