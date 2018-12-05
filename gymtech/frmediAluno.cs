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
    public partial class frmediAluno : Form
    {
        public frmediAluno()
        {
            InitializeComponent();
        }

        Conexao conexao = new Conexao();
        BancoDeDados banco = new BancoDeDados();

        public string usuario { get; set; }
        public string login;
        public string senha;
        public int id;
        public int id_user;
        public string nome;
        public string cpf;
        public string rg;
        public string endrua;
        public string endnum;
        public string endcomp;
        public string cep;
        public string bairro;
        public string celular;
        public string data;

        public string select;
        public string insert;
        public string update;


        private void frmediAluno_Load(object sender, EventArgs e)
        {
            conexao.conectar();

            if (!this.usuario.Equals("label"))
            {
                lblSave.Text = this.usuario;
            }

            id_user = Convert.ToInt32(lblSave.Text);

            //consultas

            select = "SELECT id_aluno FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getid = new NpgsqlCommand(select, conexao.conn);
            id = Convert.ToInt32(getid.ExecuteScalar());

            select = "SELECT nome FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getnome = new NpgsqlCommand(select, conexao.conn);
            nome = Convert.ToString(getnome.ExecuteScalar());
            txbNome.Text = nome;

            select = "SELECT cpf FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getcpf = new NpgsqlCommand(select, conexao.conn);
            cpf = Convert.ToString(getcpf.ExecuteScalar());
            txbCpf.Text = cpf;

            select = "SELECT rg FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getrg = new NpgsqlCommand(select, conexao.conn);
            rg = Convert.ToString(getrg.ExecuteScalar());
            txbRg.Text = rg;

            select = "SELECT endereco_rua FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getend = new NpgsqlCommand(select, conexao.conn);
            endrua = Convert.ToString(getend.ExecuteScalar());
            txbEndereco.Text = endrua;

            select = "SELECT endereco_num FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getnum = new NpgsqlCommand(select, conexao.conn);
            endnum = Convert.ToString(getnum.ExecuteScalar());
            txbNum.Text = endnum;

            select = "SELECT endereco_comp FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getcomp = new NpgsqlCommand(select, conexao.conn);
            endcomp = Convert.ToString(getcomp.ExecuteScalar());
            txbComplemento.Text = endcomp;

            select = "SELECT cep FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getcep = new NpgsqlCommand(select, conexao.conn);
            cep = Convert.ToString(getcep.ExecuteScalar());
            txbCep.Text = cep;

            select = "SELECT bairro FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getbairro = new NpgsqlCommand(select, conexao.conn);
            bairro = Convert.ToString(getbairro.ExecuteScalar());
            txbBairro.Text = bairro;

            select = "SELECT data_nasc FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getdata = new NpgsqlCommand(select, conexao.conn);
            data = Convert.ToString(getdata.ExecuteScalar());
            txbData.Text = data;

            select = "SELECT celular FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getcel = new NpgsqlCommand(select, conexao.conn);
            celular = Convert.ToString(getcel.ExecuteScalar());
            txbCelular.Text = celular;

            select = "SELECT login FROM usuarios WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getlogin = new NpgsqlCommand(select, conexao.conn);
            login = Convert.ToString(getlogin.ExecuteScalar());
            txbLogin.Text = login;

            select = "SELECT senha FROM usuarios WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getsenha = new NpgsqlCommand(select, conexao.conn);
            senha = Convert.ToString(getsenha.ExecuteScalar());
            txbSenha.Text = senha;

        }

        private void checkCalendario_CheckedChanged(object sender, EventArgs e)
        {
            if(checkCalendario.Checked == true)
            {
                calendario.Visible = true;
            }
            else
            {
                calendario.Visible = false;
            }
        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            txbData.Text = calendario.SelectionStart.Day.ToString() + "/" + calendario.SelectionStart.Month.ToString() + "/" + calendario.SelectionStart.Year.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            nome = txbNome.Text;
            cpf = txbCpf.Text;
            rg = txbRg.Text;
            endrua = txbEndereco.Text;
            endnum = txbNum.Text;
            endcomp = txbComplemento.Text;
            cep = txbCep.Text;
            bairro = txbBairro.Text;
            data = txbData.Text;
            celular = txbCelular.Text;
            login = txbLogin.Text;
            senha = txbSenha.Text;

            banco.atualizarAluno(update, nome, cpf, rg, endrua, endnum, endcomp, cep, bairro, data, celular, login, senha, id, id_user, conexao);

        }
    }
}
