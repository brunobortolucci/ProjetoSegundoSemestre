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
    public partial class frmRecepcao : Form
    {        
        public frmRecepcao()
        {
            InitializeComponent();
        }        

        private void frmRecepcao_Load(object sender, EventArgs e)
        {
            frmLogin formlogin = new frmLogin();
            Conexao conexao = new Conexao();

            conexao.conectar();

            //string nomeusuario;
            string idusuario = formlogin.pegarid();
            int id = Convert.ToInt32(idusuario);
            string loginusuario = formlogin.pegaruser();
            MessageBox.Show("Login: " + loginusuario + " Id: " + idusuario);
            //string verificarid = "SELECT nome FROM recepcao where id_user = '" + id + "'";

            //NpgsqlCommand pegar_nome = new NpgsqlCommand(verificarid, conexao.conn);
            //nomeusuario = pegar_nome.ExecuteScalar().ToString();

            //lblApresentacao.Text = "Olá, " + nomeusuario;
            

        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            frmLogin frmlog = new frmLogin();
            Conexao conexao = new Conexao();

            this.Close();
            conexao.desconectar();
            frmlog.Show();
        }

        private void checkNome_CheckedChanged(object sender, EventArgs e)
        {            
            if (checkNome.Checked == true)
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
            if (checkCpf.Checked == true)
            {
                checkNome.Enabled = false;
            }
            else
            {
                checkNome.Enabled = true;
            }
        }

        private void btnCadAluno_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoverAluno_Click(object sender, EventArgs e)
        {

        }

        private void btnCadProfessor_Click(object sender, EventArgs e)
        {

        }

        private void btnRemProfessor_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
