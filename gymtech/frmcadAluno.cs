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
    public partial class frmcadAluno : Form
    {
        public frmcadAluno()
        {
            InitializeComponent();
        }

        Conexao conexao = new Conexao();
        BancoDeDados banco = new BancoDeDados();

        //strings usuario
        public string nome;
        public string cpf;
        public string rg;
        public string endrua;
        public string endnum;
        public string endcomp;
        public string cep;
        public string bairro;
        public string data;
        public string celular;
        public int id;
        public string login;
        public string senha;

        public string insert;
        public string select;
        public int permissao;
        public string comparacao;

        public void verificar()
        {
            if (!txbNome.Text.Equals("") && !txbCpf.Text.Equals("") && !txbRg.Text.Equals("") && !txbEndereco.Text.Equals("") && !txbNumEnd.Text.Equals("") && !txbCep.Text.Equals("") && !txbBairro.Text.Equals("") && !txbCelular.Text.Equals("") && !txbData.Text.Equals("") && !txbSenha.Text.Equals("") && lblLoginOk.Visible == true)
            {
                btnCadastrar.Enabled = true;
            }
            else
            {
                btnCadastrar.Enabled = false;
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if(btnVerificar.Text == "Verificar")
            {
                login = txbLogin.Text;

                select = "SELECT senha FROM usuarios where senha = '" + login + "'";

                NpgsqlCommand verificarlogin = new NpgsqlCommand(select, conexao.conn);
                comparacao = Convert.ToString(verificarlogin.ExecuteScalar());

                if (login.Equals(""))
                {
                    MessageBox.Show("Digite um login");
                }
                else if (comparacao == login)
                {
                    lblLoginOk.Visible = false;
                    MessageBox.Show("Usuario ja existe!");

                }
                else
                {
                    lblLoginOk.Visible = true;
                    MessageBox.Show("Usuario disponivel!");
                    btnVerificar.Text = "Trocar";
                    txbLogin.Enabled = false;
                    verificar();
                }
            }

            else if (btnVerificar.Text == "Trocar")
            {
                lblLoginOk.Visible = false;
                txbLogin.Enabled = true;
                btnVerificar.Text = "Verificar";
                verificar();
            }
            
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarFoto_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            nome = txbNome.Text;
            cpf = txbCpf.Text;
            rg = txbRg.Text;
            endrua = txbEndereco.Text;
            endnum = txbNumEnd.Text;
            endcomp = txbCompEnd.Text;
            cep = txbCep.Text;
            bairro = txbBairro.Text;
            data = txbData.Text;
            celular = txbCelular.Text;
            login = txbLogin.Text;
            senha = txbSenha.Text;

            banco.cadastrarAluno(select, insert, permissao, nome, cpf, rg, endrua, endnum, endcomp, cep, bairro, data, celular, login, senha, id, conexao);
            this.Close();

        }

        private void frmcadAluno_Load(object sender, EventArgs e)
        {
            conexao.conectar();
            lblLoginOk.Visible = false;
            btnCadastrar.Enabled = false;
        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {
            verificar();
        }

        private void txbCpf_TextChanged(object sender, EventArgs e)
        {
            verificar();
        }

        private void txbRg_TextChanged(object sender, EventArgs e)
        {
            verificar();
        }

        private void txbEndereco_TextChanged(object sender, EventArgs e)
        {
            verificar();
        }

        private void txbNumEnd_TextChanged(object sender, EventArgs e)
        {
            verificar();
        }

        private void txbCep_TextChanged(object sender, EventArgs e)
        {
            verificar();
        }

        private void txbBairro_TextChanged(object sender, EventArgs e)
        {
            verificar();
        }

        private void txbCelular_TextChanged(object sender, EventArgs e)
        {
            verificar();
            
        }

        private void txbData_TextChanged(object sender, EventArgs e)
        {
            verificar();            
        }

        private void txbLogin_TextChanged(object sender, EventArgs e)
        {
            verificar();            
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {
            verificar();            
        }
    }
}
