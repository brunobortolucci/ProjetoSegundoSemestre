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
    public partial class frmProfessor : Form
    {
        public frmProfessor()
        {
            InitializeComponent();
        }

        Conexao conexao = new Conexao();
        BancoDeDados banco = new BancoDeDados();

        public string usuario { get; set; }
        public string nome;
        public string cpf;
        public string select;
        public string retorno;

        private void frmProfessor_Load(object sender, EventArgs e)
        {
            if (!this.usuario.Equals(""))
            {
                lblApresentacao.Text = this.usuario;
            }

            lblResultado.Visible = false;
            linklblRetorno.Visible = false;
            painelBusca.Visible = false;

            conexao.conectar();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmlog = new frmLogin();
            frmlog.Show();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            frmcadAluno cadaluno = new frmcadAluno();
            cadaluno.Show();
        }

        private void checkNome_CheckedChanged(object sender, EventArgs e)
        {
            if(checkNome.Checked == true)
            {
                checkCpf.Enabled = false;
            }
            else
            {
                checkCpf.Enabled = true;
            }
        }

        private void checkCpf_CheckedChanged(object sender, EventArgs e)
        {
            if(checkCpf.Checked == true)
            {
                checkNome.Enabled = false;
            }
            else
            {
                checkNome.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(checkNome.Checked == true)
            {
                nome = txbBusca.Text;

                select = "SELECT nome FROM aluno WHERE nome = '" + nome + "'";

                NpgsqlCommand buscanome = new NpgsqlCommand(select, conexao.conn);
                retorno = Convert.ToString(buscanome.ExecuteScalar());

                if (retorno.Equals(""))
                {
                    MessageBox.Show("Nome não encontrado");
                    lblResultado.Visible = false;
                    linklblRetorno.Visible = false;
                    painelBusca.Visible = false;
                }

                else
                {
                    linklblRetorno.Text = retorno;
                    lblResultado.Visible = true;
                    linklblRetorno.Visible = true;
                    painelBusca.Visible = true;
                }
                                
            }
            else if(checkCpf.Checked == true)
            {
                cpf = txbBusca.Text;

                select = "SELECT nome FROM aluno WHERE cpf = '" + cpf + "'";
                NpgsqlCommand buscacpf = new NpgsqlCommand(select, conexao.conn);
                retorno = Convert.ToString(buscacpf.ExecuteScalar());

                if (retorno.Equals(""))
                {
                    MessageBox.Show("Nome não encontrado");
                    lblResultado.Visible = false;
                    linklblRetorno.Visible = false;
                    painelBusca.Visible = false;
                }

                else
                {
                    linklblRetorno.Text = retorno;
                    lblResultado.Visible = true;
                    linklblRetorno.Visible = true;
                    painelBusca.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Seleciona o tipo de busca (Nome ou Cpf)");
            }
        }
    }
}
