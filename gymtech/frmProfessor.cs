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
        public int save;

        public void transferir()
        {
            frmediAluno editaraluno = new frmediAluno();
            editaraluno.usuario = lblSave.Text;
            editaraluno.Show();

        }

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
            
        }        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            nome = txbBusca.Text;

            select = "SELECT id_user FROM aluno WHERE nome = '" + nome + "'";

            NpgsqlCommand salvador = new NpgsqlCommand(select, conexao.conn);
            save = Convert.ToInt32(salvador.ExecuteScalar());

            lblSave.Text = Convert.ToString(save);


            if (checkNome.Checked == true)
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
            else
            {
                MessageBox.Show("Seleciona o tipo de busca (Nome ou Cpf)");
            }
        }

        private void btnCadastrarTreino_Click(object sender, EventArgs e)
        {
            frmcadTreino frmtreino = new frmcadTreino();
            frmtreino.Show();
        }

        private void linklblRetorno_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            transferir();
        }
    }
}
