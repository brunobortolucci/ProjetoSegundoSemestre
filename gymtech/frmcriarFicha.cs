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
    public partial class frmcriarFicha : Form
    {
        public frmcriarFicha()
        {
            InitializeComponent();
        }

        Conexao conexao = new Conexao();
        BancoDeDados banco = new BancoDeDados();

        public string usuario { get; set; }
        public int id_aluno { get; set; }
        public string login;
        public string senha;
        public int id;
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
        public double peso;
        public int series;
        public int repeticoes;

        public string select;
        public string insert;
        public string update;

        //treinos
        public int id_perna;
        public int id_ombro;
        public int id_costas;
        public int id_biceps;
        public int id_triceps;
        public int id_peito;
        public string tip_sang;
        public double alturaaluno;
        public double pesoaluno;


        public void preencherComboPerna()
        {
            //consulta
            select = "SELECT exercicios FROM treino_perna";
            NpgsqlCommand perna = new NpgsqlCommand(select, conexao.conn);
            NpgsqlDataReader ler;

            try
            {                
                ler = perna.ExecuteReader();

                while (ler.Read())
                {
                    string exercicio = ler.GetString(ler.GetOrdinal("exercicios"));
                    comboPerna.Items.Add(exercicio);
                }

                ler.Close();

            }

            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void preencherComboOmbro()
        {
            //consulta
            select = "SELECT exercicios FROM treino_ombro";
            NpgsqlCommand ombro = new NpgsqlCommand(select, conexao.conn);
            NpgsqlDataReader ler;

            try
            {
                ler = ombro.ExecuteReader();

                while (ler.Read())
                {
                    string exercicio = ler.GetString(ler.GetOrdinal("exercicios"));
                    comboOmbro.Items.Add(exercicio);
                }
                ler.Close();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void preencherComboBiceps()
        {
            //consulta
            select = "SELECT exercicios FROM treino_biceps";
            NpgsqlCommand biceps = new NpgsqlCommand(select, conexao.conn);
            NpgsqlDataReader ler;

            try
            {
                ler = biceps.ExecuteReader();

                while (ler.Read())
                {
                    string exercicio = ler.GetString(ler.GetOrdinal("exercicios"));
                    comboBiceps.Items.Add(exercicio);
                }
                ler.Close();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void preencherComboCostas()
        {
            //consulta
            select = "SELECT exercicios FROM treino_costas";
            NpgsqlCommand costas = new NpgsqlCommand(select, conexao.conn);
            NpgsqlDataReader ler;

            try
            {
                ler = costas.ExecuteReader();

                while (ler.Read())
                {
                    string exercicio = ler.GetString(ler.GetOrdinal("exercicios"));
                    comboCostas.Items.Add(exercicio);
                }
                ler.Close();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void preencherComboPeito()
        {
            //consulta
            select = "SELECT exercicios FROM treino_peito";
            NpgsqlCommand peito = new NpgsqlCommand(select, conexao.conn);
            NpgsqlDataReader ler;

            try
            {
                ler = peito.ExecuteReader();

                while (ler.Read())
                {
                    string exercicio = ler.GetString(ler.GetOrdinal("exercicios"));
                    comboPeito.Items.Add(exercicio);
                }
                ler.Close();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void preencherComboTriceps()
        {
            //consulta
            select = "SELECT exercicios FROM treino_triceps";
            NpgsqlCommand triceps = new NpgsqlCommand(select, conexao.conn);
            NpgsqlDataReader ler;

            try
            {
                ler = triceps.ExecuteReader();

                while (ler.Read())
                {
                    string exercicio = ler.GetString(ler.GetOrdinal("exercicios"));
                    comboTriceps.Items.Add(exercicio);
                }
                ler.Close();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmcriarFicha_Load(object sender, EventArgs e)
        {
            conexao.conectar();
            if (!this.usuario.Equals(""))
            {
                lblNomeAluno.Text = this.usuario;
            }

            if (!this.id_aluno.Equals(""))
            {
                lblSave.Text = Convert.ToString(this.id_aluno);
            }

            preencherComboPerna();
            preencherComboOmbro();
            preencherComboBiceps();
            preencherComboCostas();
            preencherComboPeito();
            preencherComboTriceps();

        }

        private void comboPerna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPerna.Text.Equals(""))
            {

            }
            else
            {

                select = "SELECT id_perna FROM treino_perna WHERE exercicios ='" + comboPerna.Text + "'";
                NpgsqlCommand perna = new NpgsqlCommand(select, conexao.conn);
                id_perna = Convert.ToInt32(perna.ExecuteScalar());

            }
        }

        private void comboOmbro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboOmbro.Text.Equals(""))
            {

            }
            else
            {
                select = "SELECT id_ombro FROM treino_ombro WHERE exercicios ='" + comboOmbro.Text + "'";
                NpgsqlCommand ombro = new NpgsqlCommand(select, conexao.conn);
                id_ombro = Convert.ToInt32(ombro.ExecuteScalar());
            }
        }

        private void comboBiceps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBiceps.Text.Equals(""))
            {

            }
            else
            {
                select = "SELECT id_biceps FROM treino_biceps WHERE exercicios ='" + comboBiceps.Text + "'";
                NpgsqlCommand biceps = new NpgsqlCommand(select, conexao.conn);
                id_biceps = Convert.ToInt32(biceps.ExecuteScalar());
            }
        }

        private void comboCostas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCostas.Text.Equals(""))
            {

            }
            else
            {
                select = "SELECT id_costas FROM treino_costas WHERE exercicios ='" + comboCostas.Text + "'";
                NpgsqlCommand costas = new NpgsqlCommand(select, conexao.conn);
                id_costas = Convert.ToInt32(costas.ExecuteScalar());
            }
        }

        private void comboPeito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPeito.Text.Equals(""))
            {

            }
            else
            {
                select = "SELECT id_peito FROM treino_peito WHERE exercicios ='" + comboPeito.Text + "'";
                NpgsqlCommand peito = new NpgsqlCommand(select, conexao.conn);
                id_peito = Convert.ToInt32(peito.ExecuteScalar());
            }
        }

        private void comboTriceps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTriceps.Text.Equals(""))
            {

            }
            else
            {
                select = "SELECT id_triceps FROM treino_triceps WHERE exercicios ='" + comboTriceps.Text + "'";
                NpgsqlCommand triceps = new NpgsqlCommand(select, conexao.conn);
                id_triceps = Convert.ToInt32(triceps.ExecuteScalar());
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            banco.cadastrarFichaTreino(insert, conexao, txbNomeTreino.Text, id_aluno, Convert.ToDouble(txbPesoAluno.Text), Convert.ToDouble(txbAltura.Text), comboSangue.Text, id_perna, id_ombro, id_biceps, id_costas, id_peito, id_triceps);
        }
    }
}
