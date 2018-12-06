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
    public partial class frmAluno : Form
    {
        public frmAluno()
        {
            InitializeComponent();
        }

        Conexao conexao = new Conexao();
        BancoDeDados banco = new BancoDeDados();

        public string usuario { get; set; }

        //usuario
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
        public int id_aluno;
        public int id_user;
        
        public string select;

        public void preencherComboTreino()
        {
            //consulta
            select = "SELECT nome FROM ficha_treino";
            NpgsqlCommand treinos = new NpgsqlCommand(select, conexao.conn);
            NpgsqlDataReader ler;

            try
            {
                ler = treinos.ExecuteReader();

                while (ler.Read())
                {
                    string nomes = ler.GetString(ler.GetOrdinal("nome"));
                    comboTreinos.Items.Add(nomes);
                }

                ler.Close();

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmAluno_Load(object sender, EventArgs e)
        {
            conexao.conectar();

            if (!this.usuario.Equals(""))
            {
                lblApresentacao.Text = this.usuario;
            }

            preencherComboTreino();

            //consultas
            select = "SELECT id_user FROM usuarios WHERE login = '" + usuario + "'";
            NpgsqlCommand pegarid = new NpgsqlCommand(select, conexao.conn);
            id_user = Convert.ToInt32(pegarid.ExecuteScalar());


            select = "SELECT nome FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getnome = new NpgsqlCommand(select, conexao.conn);
            nome = Convert.ToString(getnome.ExecuteScalar());
            lblNomeUsuario.Text = nome;

            select = "SELECT cpf FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getcpf = new NpgsqlCommand(select, conexao.conn);
            cpf = Convert.ToString(getcpf.ExecuteScalar());
            lblCpfUsuario.Text = cpf;

            select = "SELECT rg FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getrg = new NpgsqlCommand(select, conexao.conn);
            rg = Convert.ToString(getrg.ExecuteScalar());
            lblRgUsuario.Text = rg;

            select = "SELECT endereco_rua FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getendrua = new NpgsqlCommand(select, conexao.conn);
            endrua = Convert.ToString(getendrua.ExecuteScalar());
            lblEndUsuario.Text = endrua;

            select = "SELECT endereco_num FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getendnum = new NpgsqlCommand(select, conexao.conn);
            endnum = Convert.ToString(getendnum.ExecuteScalar());
            lblEndNumUsuario.Text = endnum;

            select = "SELECT endereco_comp FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getendcom = new NpgsqlCommand(select, conexao.conn);
            endcomp = Convert.ToString(getendcom.ExecuteScalar());
            lblEndCompUsuario.Text = endcomp;

            select = "SELECT cep FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getcep = new NpgsqlCommand(select, conexao.conn);
            cep = Convert.ToString(getcep.ExecuteScalar());
            lblCepUsuario.Text = cep;

            select = "SELECT bairro FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getbairro = new NpgsqlCommand(select, conexao.conn);
            bairro = Convert.ToString(getbairro.ExecuteScalar());
            lblBairroUsuario.Text = bairro;

            select = "SELECT data_nasc FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getdata = new NpgsqlCommand(select, conexao.conn);
            data = Convert.ToString(getdata.ExecuteScalar());
            lblDataUsuario.Text = data;

            select = "SELECT celular FROM aluno WHERE id_user ='" + id_user + "'";
            NpgsqlCommand getcel = new NpgsqlCommand(select, conexao.conn);
            celular = Convert.ToString(getcel.ExecuteScalar());
            lblCelularUsuario.Text = celular;

        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmlog = new frmLogin();
            frmlog.Show();
        }        
    }
}
