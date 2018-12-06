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
    public partial class frmAdministrador : Form
    {

        public frmAdministrador()
        {
            InitializeComponent();

        }

        BancoDeDados banco = new BancoDeDados();
        Conexao conexao = new Conexao();

        public int id;
        public string nome;
        public string cpf;
        public string data;
        public string login;
        public string senha;
        public int permissao;
       

        public string max_id;
        public int id_somado;
        public string select;
        public string insert;
        public bool encontrou;
        public bool disponivel = false;
        public string comparacao;


        public string usuario { get; set; }        
            

        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            if (!this.usuario.Equals(""))
            {
                lblApresentacao.Text = this.usuario;
            }

            if (txbLogin.Text.Equals(""))
            {
                btnVerificar.Enabled = false;
            }

            frmLogin frmlog = new frmLogin();
            conexao.conectar();

            calendario.Visible = false;
        }

        public void verificarMudanca()
        {
            if (!txbNome.Text.Equals("") && !txbCPF.Text.Equals("") && !txbData.Text.Equals("") && !txbLogin.Text.Equals("") && !txbSenha.Text.Equals("") && lblLoginOk.Visible == true)
            {
                btnCadastrar.Enabled = true;
            }
            else
            {
                btnCadastrar.Enabled = false;
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmlog = new frmLogin();
            frmlog.Show();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (btnVerificar.Text == "Verificar")
            {
                login = txbLogin.Text;

                encontrou = false;

                select = "SELECT senha FROM usuarios where senha = '" + login + "'";

                NpgsqlCommand verificarlogin = new NpgsqlCommand(select, conexao.conn);
                comparacao = Convert.ToString(verificarlogin.ExecuteScalar());

                if (login.Equals(""))
                {
                    MessageBox.Show("Digite um login");
                }

                else if (comparacao == login)
                {
                    disponivel = false;
                    lblLoginOk.Visible = false;
                    MessageBox.Show("Usuario ja existe!");

                }
                else
                {
                    disponivel = true;
                    lblLoginOk.Visible = true;
                    MessageBox.Show("Usuario disponivel!");
                    btnVerificar.Text = "Trocar";
                    txbLogin.Enabled = false;
                }
            }

            else if (btnVerificar.Text == "Trocar")
            {
                lblLoginOk.Visible = false;
                txbLogin.Enabled = true;
                btnVerificar.Text = "Verificar";
            }

            verificarMudanca();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            nome = txbNome.Text;
            cpf = txbCPF.Text;
            data = txbData.Text;
            login = txbLogin.Text;
            senha = txbSenha.Text;

            banco.cadastrarProfessor(select, insert, nome, cpf, data, login, senha, permissao, id, conexao);

            this.Close();
            frmLogin frmlog = new frmLogin();
            frmlog.Show();
        }

        private void txbLogin_TextChanged(object sender, EventArgs e)
        {            

            if (txbLogin.Text.Equals(""))
            {
                btnVerificar.Enabled = false;
                lblLoginOk.Visible = false;
                btnCadastrar.Enabled = false;
            }
            else
            {
                btnVerificar.Enabled = true;
            }

            verificarMudanca();
        }

        private void lblLoginOk_TextChanged(object sender, EventArgs e)
        {
            if (lblLoginOk.Visible == false)
            {
                btnVerificar.Enabled = false;
                lblLoginOk.Visible = false;
                btnCadastrar.Enabled = false;
            }            

            verificarMudanca();
        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {
            if (txbNome.Text.Equals(""))
            {                
                btnCadastrar.Enabled = false;
            }
            else
            {
                btnCadastrar.Enabled = true;
            }

            verificarMudanca();
        }

        private void txbCPF_TextChanged(object sender, EventArgs e)
        {
            if (txbCPF.Text.Equals(""))
            {
                btnCadastrar.Enabled = false; ;
            }
            else
            {
                btnCadastrar.Enabled = true;
            }

            verificarMudanca();
        }

        private void txbData_TextChanged(object sender, EventArgs e)
        {
            if (txbData.Text.Equals(""))
            {
                btnCadastrar.Enabled = false;
            }
            else
            {
                btnCadastrar.Enabled = true;
            }

            verificarMudanca();
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {
            if (txbSenha.Text.Equals(""))
            {
                btnCadastrar.Enabled = false;
            }
            else
            {
                btnCadastrar.Enabled = true;
            }

            verificarMudanca();
        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            txbData.Text = calendario.SelectionStart.Day.ToString() + "/" + calendario.SelectionStart.Month.ToString() + "/" + calendario.SelectionStart.Year.ToString();
        }

        private void frmAdministrador_MouseClick(object sender, MouseEventArgs e)
        {
            if(calendario.Visible == true)
            {
                calendario.Visible = false;
            }
            else
            {
                calendario.Visible = true;
            }
        }

        private void txbData_MouseClick(object sender, MouseEventArgs e)
        {
            if (calendario.Visible == true)
            {
                calendario.Visible = false;
            }
            else
            {
                calendario.Visible = true;
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            calendario.Visible = false;
        }

        private void checkCalendario_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCalendario.Checked == true)
            {
                calendario.Visible = true;
            }
            else
            {
                calendario.Visible = false;
            }
        }
    }
}
