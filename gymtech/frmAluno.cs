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

        private void comboTreinos_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (comboTreinos.Text.Equals(""))
            {

            }
            else
            {
                painel.Visible = true;
                lblSelecione.Visible = true;
                comboResultado.Visible = true;

                select = "select treino_perna.exercicios as perna, treino_ombro.exercicios as ombro, treino_biceps.exercicios as biceps, treino_costas.exercicios as costas, treino_peito.exercicios as peito, treino_triceps.exercicios as triceps from treino_perna inner join ficha_treino on ficha_treino.t_perna = treino_perna.id_perna inner join treino_ombro on ficha_treino.t_ombro = treino_ombro.id_ombro inner join treino_biceps on ficha_treino.t_biceps = treino_biceps.id_biceps inner join treino_costas on ficha_treino.t_costas = treino_costas.id_costas inner join treino_peito on ficha_treino.t_peito = treino_peito.id_peito inner join treino_triceps on ficha_treino.t_triceps = treino_triceps.id_triceps";
                NpgsqlCommand selectperna = new NpgsqlCommand(select, conexao.conn);
                NpgsqlDataReader ler;

                ler = selectperna.ExecuteReader();

                while (ler.Read())
                {
                    string perna = ler.GetString(ler.GetOrdinal("perna"));
                    string ombro = ler.GetString(ler.GetOrdinal("ombro"));
                    string biceps = ler.GetString(ler.GetOrdinal("biceps"));
                    string costas = ler.GetString(ler.GetOrdinal("costas"));
                    string peito = ler.GetString(ler.GetOrdinal("peito"));
                    string triceps = ler.GetString(ler.GetOrdinal("triceps"));

                    comboResultado.Items.Add(perna);
                    comboResultado.Items.Add(ombro);
                    comboResultado.Items.Add(biceps);
                    comboResultado.Items.Add(costas);
                    comboResultado.Items.Add(peito);
                    comboResultado.Items.Add(triceps);
                }               

                ler.Close();

            }
        }

        private void comboResultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboResultado.Text.Equals(""))
            {

            }
            else
            {
                select = "SELECT id_perna FROM treino_perna WHERE exercicios = '" + comboResultado.Text + "'";
                NpgsqlCommand buscaperna = new NpgsqlCommand(select, conexao.conn);

                int idperna = Convert.ToInt32(buscaperna.ExecuteScalar());

                if(idperna != 0)
                {
                    select = "SELECT nivel, peso, series, repeticoes FROM treino_perna WHERE id_perna ='" + idperna + "'";
                    NpgsqlCommand verificar = new NpgsqlCommand(select, conexao.conn);
                    NpgsqlDataReader leitura = verificar.ExecuteReader();

                    while (leitura.Read())
                    {

                        string nivel = leitura.GetString(leitura.GetOrdinal("nivel"));
                        double peso = leitura.GetDouble(leitura.GetOrdinal("peso"));
                        int series = leitura.GetInt32(leitura.GetOrdinal("series"));
                        int repeticoes = leitura.GetInt32(leitura.GetOrdinal("repeticoes"));

                        txbNivel.Text = nivel;
                        txbPeso.Text = Convert.ToString(peso);
                        txbSeries.Text = Convert.ToString(series);
                        txbRep.Text = Convert.ToString(repeticoes);

                    }

                    leitura.Close();
                }

                else
                {
                    select = "SELECT id_ombro FROM treino_ombro WHERE exercicios = '" + comboResultado.Text + "'";
                    NpgsqlCommand buscaombro = new NpgsqlCommand(select, conexao.conn);

                    int idombro = Convert.ToInt32(buscaombro.ExecuteScalar());

                    if(idombro != 0)
                    {
                        select = "SELECT nivel, peso, series, repeticoes FROM treino_ombro WHERE id_ombro ='" + idombro + "'";
                        NpgsqlCommand verificar = new NpgsqlCommand(select, conexao.conn);
                        NpgsqlDataReader leitura = verificar.ExecuteReader();

                        while (leitura.Read())
                        {

                            string nivel = leitura.GetString(leitura.GetOrdinal("nivel"));
                            double peso = leitura.GetDouble(leitura.GetOrdinal("peso"));
                            int series = leitura.GetInt32(leitura.GetOrdinal("series"));
                            int repeticoes = leitura.GetInt32(leitura.GetOrdinal("repeticoes"));

                            txbNivel.Text = nivel;
                            txbPeso.Text = Convert.ToString(peso);
                            txbSeries.Text = Convert.ToString(series);
                            txbRep.Text = Convert.ToString(repeticoes);

                        }

                        leitura.Close();
                    }

                    else
                    {
                        select = "SELECT id_biceps FROM treino_biceps WHERE exercicios = '" + comboResultado.Text + "'";
                        NpgsqlCommand buscabiceps = new NpgsqlCommand(select, conexao.conn);

                        int idbiceps = Convert.ToInt32(buscabiceps.ExecuteScalar());

                        if(idbiceps != 0)
                        {
                            select = "SELECT nivel, peso, series, repeticoes FROM treino_biceps WHERE id_biceps ='" + idbiceps + "'";
                            NpgsqlCommand verificar = new NpgsqlCommand(select, conexao.conn);
                            NpgsqlDataReader leitura = verificar.ExecuteReader();

                            while (leitura.Read())
                            {

                                string nivel = leitura.GetString(leitura.GetOrdinal("nivel"));
                                double peso = leitura.GetDouble(leitura.GetOrdinal("peso"));
                                int series = leitura.GetInt32(leitura.GetOrdinal("series"));
                                int repeticoes = leitura.GetInt32(leitura.GetOrdinal("repeticoes"));

                                txbNivel.Text = nivel;
                                txbPeso.Text = Convert.ToString(peso);
                                txbSeries.Text = Convert.ToString(series);
                                txbRep.Text = Convert.ToString(repeticoes);

                            }

                            leitura.Close();
                        }

                        else
                        {
                            select = "SELECT id_costas FROM treino_costas WHERE exercicios = '" + comboResultado.Text + "'";
                            NpgsqlCommand buscacostas = new NpgsqlCommand(select, conexao.conn);

                            int idcostas = Convert.ToInt32(buscacostas.ExecuteScalar());

                            if(idcostas != 0)
                            {
                                select = "SELECT nivel, peso, series, repeticoes FROM treino_costas WHERE id_costas ='" + idcostas + "'";
                                NpgsqlCommand verificar = new NpgsqlCommand(select, conexao.conn);
                                NpgsqlDataReader leitura = verificar.ExecuteReader();

                                while (leitura.Read())
                                {

                                    string nivel = leitura.GetString(leitura.GetOrdinal("nivel"));
                                    double peso = leitura.GetDouble(leitura.GetOrdinal("peso"));
                                    int series = leitura.GetInt32(leitura.GetOrdinal("series"));
                                    int repeticoes = leitura.GetInt32(leitura.GetOrdinal("repeticoes"));

                                    txbNivel.Text = nivel;
                                    txbPeso.Text = Convert.ToString(peso);
                                    txbSeries.Text = Convert.ToString(series);
                                    txbRep.Text = Convert.ToString(repeticoes);

                                }

                                leitura.Close();
                            }

                            else
                            {
                                select = "SELECT id_peito FROM treino_peito WHERE exercicios = '" + comboResultado.Text + "'";
                                NpgsqlCommand buscapeito = new NpgsqlCommand(select, conexao.conn);

                                int idpeito = Convert.ToInt32(buscapeito.ExecuteScalar());

                                if (idpeito != 0)
                                {
                                    select = "SELECT nivel, peso, series, repeticoes FROM treino_peito WHERE id_peito ='" + idpeito + "'";
                                    NpgsqlCommand verificar = new NpgsqlCommand(select, conexao.conn);
                                    NpgsqlDataReader leitura = verificar.ExecuteReader();

                                    while (leitura.Read())
                                    {

                                        string nivel = leitura.GetString(leitura.GetOrdinal("nivel"));
                                        double peso = leitura.GetDouble(leitura.GetOrdinal("peso"));
                                        int series = leitura.GetInt32(leitura.GetOrdinal("series"));
                                        int repeticoes = leitura.GetInt32(leitura.GetOrdinal("repeticoes"));

                                        txbNivel.Text = nivel;
                                        txbPeso.Text = Convert.ToString(peso);
                                        txbSeries.Text = Convert.ToString(series);
                                        txbRep.Text = Convert.ToString(repeticoes);

                                    }

                                    leitura.Close();
                                }

                                else
                                {
                                    select = "SELECT id_triceps FROM treino_triceps WHERE exercicios = '" + comboResultado.Text + "'";
                                    NpgsqlCommand buscatriceps = new NpgsqlCommand(select, conexao.conn);

                                    int idtriceps = Convert.ToInt32(buscatriceps.ExecuteScalar());

                                    if(idtriceps != 0)
                                    {

                                        select = "SELECT nivel, peso, series, repeticoes FROM treino_triceps WHERE id_triceps ='" + idtriceps + "'";
                                        NpgsqlCommand verificar = new NpgsqlCommand(select, conexao.conn);
                                        NpgsqlDataReader leitura = verificar.ExecuteReader();

                                        while (leitura.Read())
                                        {

                                            string nivel = leitura.GetString(leitura.GetOrdinal("nivel"));
                                            double peso = leitura.GetDouble(leitura.GetOrdinal("peso"));
                                            int series = leitura.GetInt32(leitura.GetOrdinal("series"));
                                            int repeticoes = leitura.GetInt32(leitura.GetOrdinal("repeticoes"));

                                            txbNivel.Text = nivel;
                                            txbPeso.Text = Convert.ToString(peso);
                                            txbSeries.Text = Convert.ToString(series);
                                            txbRep.Text = Convert.ToString(repeticoes);

                                        }

                                        leitura.Close();
                                    }
                                }
                            }

                        }
                    }

                }

            }
            

        }
    }
}
