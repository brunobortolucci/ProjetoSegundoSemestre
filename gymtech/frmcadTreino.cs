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
    public partial class frmcadTreino : Form
    {
        public frmcadTreino()
        {
            InitializeComponent();
        }

        Conexao conexao = new Conexao();
        BancoDeDados banco = new BancoDeDados();

        //strings
        public string nivel;
        public string exercicio;
        public double peso;
        public double pesoombro;
        public double pesopeito;
        public double pesotriceps;
        public double pesobiceps;
        public double pesocostas;
        public int series;
        public int repeticoes;

        public string insert;
        public string select;

        private void frmcadTreino_Load(object sender, EventArgs e)
        {
            conexao.conectar();
        }

        private void btnMaisPerna_Click(object sender, EventArgs e)
        {
            peso = peso + 10;
            txbPesoPerna.Text = Convert.ToString(peso);                        
        }

        private void btnMenosPerna_Click(object sender, EventArgs e)
        {
            if(peso > 0)
            {
                peso = peso - 10;
                txbPesoPerna.Text = Convert.ToString(peso);                                
            }
            else
            {
                MessageBox.Show("Valor não pode ser menor");
            }
            
        }

        private void btnCadPerna_Click(object sender, EventArgs e)
        {
            nivel = comboPerna.Text;
            exercicio = txbExPerna.Text;
            peso = Convert.ToDouble(txbPesoPerna.Text);
            series = Convert.ToInt32(txbSeriesPerna.Text);
            repeticoes = Convert.ToInt32(txbRepPerna.Text);

            banco.cadastrarTreinoPerna(select, insert, nivel, exercicio, peso, series, repeticoes, conexao);

        }

        private void btnMaisOmbro_Click(object sender, EventArgs e)
        {
            pesoombro = pesoombro + 10;
            txbPesoOmbro.Text = Convert.ToString(pesoombro);
            
        }

        private void btnMenosOmbro_Click(object sender, EventArgs e)
        {
            if (pesoombro > 0)
            {
                pesoombro = pesoombro - 10;
                txbPesoOmbro.Text = Convert.ToString(pesoombro);
                
            }
            else
            {
                MessageBox.Show("Valor não pode ser menor");
            }
        }

        private void btnCadOmbro_Click(object sender, EventArgs e)
        {
            nivel = comboOmbro.Text;
            exercicio = txbExOmbro.Text;
            pesoombro = Convert.ToDouble(txbPesoOmbro.Text);
            series = Convert.ToInt32(txbSeriesOmbro.Text);
            repeticoes = Convert.ToInt32(txbRepOmbro.Text);

            banco.cadastrarTreinoOmbro(select, insert, nivel, exercicio, peso, series, repeticoes, conexao);
        }

        private void btnMaisBiceps_Click(object sender, EventArgs e)
        {
            pesobiceps = pesobiceps + 10;
            txbPesoBiceps.Text = Convert.ToString(pesobiceps);            
        }

        private void btnMenosBiceps_Click(object sender, EventArgs e)
        {
            if (pesobiceps > 0)
            {
                pesobiceps = pesobiceps - 10;
                txbPesoBiceps.Text = Convert.ToString(pesobiceps);                
            }
            else
            {
                MessageBox.Show("Valor não pode ser menor");
            }
        }

        private void btnCadBiceps_Click(object sender, EventArgs e)
        {
            nivel = comboBiceps.Text;
            exercicio = txbExBiceps.Text;
            pesobiceps = Convert.ToDouble(txbPesoBiceps.Text);
            series = Convert.ToInt32(txbSeriesBiceps.Text);
            repeticoes = Convert.ToInt32(txbRepBiceps.Text);

            banco.cadastrarTreinoBiceps(select, insert, nivel, exercicio, peso, series, repeticoes, conexao);
        }

        private void btnMaisCostas_Click(object sender, EventArgs e)
        {
            pesocostas = pesocostas + 10;
            txbPesoCostas.Text = Convert.ToString(pesocostas);            
        }

        private void btnMenosCostas_Click(object sender, EventArgs e)
        {
            if (pesocostas > 0)
            {
                pesocostas = pesocostas - 10;
                txbPesoCostas.Text = Convert.ToString(pesocostas);                
            }
            else
            {
                MessageBox.Show("Valor não pode ser menor");
            }
        }

        private void btnCadCostas_Click(object sender, EventArgs e)
        {
            nivel = comboCostas.Text;
            exercicio = txbExCostas.Text;
            pesocostas = Convert.ToDouble(txbPesoCostas.Text);
            series = Convert.ToInt32(txbSeriesCostas.Text);
            repeticoes = Convert.ToInt32(txbRepCostas.Text);

            banco.cadastrarTreinoCostas(select, insert, nivel, exercicio, peso, series, repeticoes, conexao);
        }

        private void btnMaisPeito_Click(object sender, EventArgs e)
        {
            pesopeito = pesopeito + 10;
            txbPesoPeito.Text = Convert.ToString(pesopeito);            
        }

        private void btnMenosPeito_Click(object sender, EventArgs e)
        {
            if (pesopeito > 0)
            {
                pesopeito = pesopeito - 10;
                txbPesoPeito.Text = Convert.ToString(pesopeito);                
            }
            else
            {
                MessageBox.Show("Valor não pode ser menor");
            }
        }

        private void btnCadPeito_Click(object sender, EventArgs e)
        {
            nivel = comboPeito.Text;
            exercicio = txbExPeito.Text;
            pesopeito = Convert.ToDouble(txbPesoPeito.Text);
            series = Convert.ToInt32(txbSeriesPeito.Text);
            repeticoes = Convert.ToInt32(txbRepPeito.Text);

            banco.cadastrarTreinoPeito(select, insert, nivel, exercicio, peso, series, repeticoes, conexao);
        }

        private void btnMaisTriceps_Click(object sender, EventArgs e)
        {
            pesotriceps = pesotriceps + 10;
            txbPesoTriceps.Text = Convert.ToString(pesotriceps);            
        }

        private void btnMenosTriceps_Click(object sender, EventArgs e)
        {
            if (pesotriceps > 0)
            {
                pesotriceps = pesotriceps - 10;
                txbPesoTriceps.Text = Convert.ToString(pesotriceps);                
            }
            else
            {
                MessageBox.Show("Valor não pode ser menor");
            }
        }

        private void btnCadTriceps_Click(object sender, EventArgs e)
        {
            nivel = comboTriceps.Text;
            exercicio = txbExTriceps.Text;
            pesotriceps = Convert.ToDouble(txbPesoTriceps.Text);
            series = Convert.ToInt32(txbSeriesTriceps.Text);
            repeticoes = Convert.ToInt32(txbRepTriceps.Text);

            banco.cadastrarTreinoTriceps(select, insert, nivel, exercicio, peso, series, repeticoes, conexao);
        }
    }
}
