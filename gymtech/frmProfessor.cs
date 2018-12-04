using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void frmProfessor_Load(object sender, EventArgs e)
        {
            if (!this.usuario.Equals(""))
            {
                lblApresentacao.Text = this.usuario;
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
