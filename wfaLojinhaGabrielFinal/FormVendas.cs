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
    public partial class FormVendas : Form
    {
        public FormVendas()
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
            string stringSql = "SELECT * FROM pedidos ORDER BY id_pedido";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dt);
            }

            dgvVendas.DataSource = dt;



            objConnection.Close();
        }
        private void btCadastrarVenda_Click(object sender, EventArgs e)
        {
            FormCadastroVendas objFormCadastroVendas = new FormCadastroVendas();
            objFormCadastroVendas.ShowDialog();
            ExibirTabela();
        }

        private void btAtualizarVenda_Click(object sender, EventArgs e)
        {
            FormEditaVendas objFormEditaVendas = new FormEditaVendas(dgvVendas.CurrentRow);
            objFormEditaVendas.ShowDialog();
            ExibirTabela();
        }

        private void btRemoverVenda_Click(object sender, EventArgs e)
        {
            FormRemoveVendas objFormRemoveVendas = new FormRemoveVendas(dgvVendas.CurrentRow);
            objFormRemoveVendas.ShowDialog();
            ExibirTabela();

        }

        private void dgvVendas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormEditaVendas objFormEditaVendas = new FormEditaVendas(dgvVendas.Rows[e.RowIndex]);
            objFormEditaVendas.ShowDialog();
            ExibirTabela();
        }
    }
}
 