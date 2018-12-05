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
        Usuario usuario = new Usuario();
        BancoDeDados banco = new BancoDeDados();
               
        
        public string textouser;
        public string textosenha;
        public string stringselect;
        public bool encontrou;
        public string slpermissao;
        public int contator;
        public string control;
        public string id_usuario;
        public int permissao;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conexao.conectar();                      
            
        }

        public int id { get; set; }
        
        public void transferirLogin()
        {
            frmAdministrador frmAdm = new frmAdministrador();
            frmAdm.usuario = txbUser.Text;
            frmAdm.Show();
        }
        
        public void transferirLoginProfessor()
        {
            frmProfessor frmProf = new frmProfessor();
            frmProf.usuario = txbUser.Text;
            frmProf.Show();
        }

        public void transferirLoginAluno()
        {
            frmAluno frmAlu = new frmAluno();
            frmAlu.usuario = txbUser.Text;
            frmAlu.Show();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {            
            //strings de armazenamento de informacoes
            textouser = txbUser.Text;
            textosenha = txbPassword.Text;
            encontrou = false;
                        
            //Metodo de Autenticacao
            banco.autLogin(stringselect, textouser, textosenha, conexao, encontrou, contator, control);

            
            stringselect = "SELECT id_user FROM usuarios WHERE login = '" + textouser + "'";

            NpgsqlCommand pegarid = new NpgsqlCommand(stringselect, conexao.conn);
            id = Convert.ToInt32(pegarid.ExecuteScalar());

            stringselect = "SELECT permissao FROM usuarios where id_user = '" + id + "'";
            NpgsqlCommand pegarpermissao = new NpgsqlCommand(stringselect, conexao.conn);
            permissao = Convert.ToInt32(pegarpermissao.ExecuteScalar());
                                
            if(id != 0 && permissao == 0)
            {
                transferirLogin();
                this.Hide();
            }
            else if(id != 0 && permissao == 1)
            {
                transferirLoginProfessor();
                this.Hide();
            }
            else
            {
                transferirLoginAluno();
                this.Hide();
            }
            
        }        
        
        
        private void lblEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Por favor, entre em contato com o professor!");
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            conexao.desconectar();
            Application.Exit();
        }
    }
}
