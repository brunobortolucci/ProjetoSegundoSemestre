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
        Conexao conexao = new Conexao();
        Autenticacao aut = new Autenticacao();
        

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conexao.conectar();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool encontrou = false;

            string slcLogin = "SELECT * FROM admin WHERE login = '" + txbUser.Text + "' and senha = '" + txbPassword.Text + "'";

            NpgsqlCommand cmd = new NpgsqlCommand(slcLogin, conexao.conn);
                        
            NpgsqlDataReader dr = cmd.ExecuteReader();            

            if (dr.Read())
            {
                encontrou = true;
                MessageBox.Show("Logado");
            }

            else if(encontrou == false)
            {
                MessageBox.Show("Login e/ou senha incorretos");
                conexao.desconectar();
                conexao.conectar();
            }
        }

        private void btnMostrarSenha_Click(object sender, EventArgs e)
        {
            if(txbPassword.UseSystemPasswordChar == true)
            {
                txbPassword.UseSystemPasswordChar = false;
            }

            else
            {
                txbPassword.UseSystemPasswordChar = true;
            }
        
        }

        private void btnMostrarSenha_MouseHover(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.Show("Mostar Senha", btnMostrarSenha);
        }

        private void lblEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Por favor, contate a recepção!");
        }
    }
}
