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
        
        Usuario user = new Usuario();
        BancoDeDados banco = new BancoDeDados();
        Conexao conexao = new Conexao();

        public string id_usuario;
        public string max_id;
        public int id_somado;
        public string nome_usuario;
        public string select;
        public string login;
               

        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            frmLogin frmlog = new frmLogin();

            conexao.conectar();

            banco.pegarMaiorID(select, max_id, conexao);

            //id_somado = Convert.ToInt32(max_id) + 1;

            //txbIdUser.Text = id_somado.ToString();

            txbIdUser.Text = max_id;

        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
