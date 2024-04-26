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

namespace wfaLojinhaGabrielFinal
{
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
            ExibirTabela();
        }

        private void ExibirTabela()
        {
            
            StringConexao objStringConexao = new StringConexao();
            string contemStringConexao = objStringConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
            objConnection.Open();



            DataTable dt = new DataTable();
            string stringSql = "SELECT * FROM produtos ORDER BY id_produto";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dt);
            }

            dgvProdutos.DataSource = dt;



            objConnection.Close();
        }

       
        private void btCadastrarProduto_Click(object sender, EventArgs e)
        {
            FormCadastroProdutos objFormCadastroProdutos = new FormCadastroProdutos();
            objFormCadastroProdutos.ShowDialog();
            ExibirTabela();
        }

        private void btAtualizarProduto_Click(object sender, EventArgs e)
        {
            FormEditaProdutos objFormEditaProdutos = new FormEditaProdutos(dgvProdutos.CurrentRow);
            objFormEditaProdutos.ShowDialog();
            ExibirTabela();
        }

        private void dgvProdutos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormEditaProdutos objFormEditaProdutos = new FormEditaProdutos(dgvProdutos.Rows[e.RowIndex]);
            objFormEditaProdutos.ShowDialog();
            ExibirTabela();
        }

        private void btRemoverProduto_Click(object sender, EventArgs e)
        {
            FormRemoveProdutos objFormRemoveProdutos = new FormRemoveProdutos(dgvProdutos.CurrentRow);
            objFormRemoveProdutos.ShowDialog();
            ExibirTabela();

        }
    }
}
