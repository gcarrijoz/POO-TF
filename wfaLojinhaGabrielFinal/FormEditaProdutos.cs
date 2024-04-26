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
    public partial class FormEditaProdutos : Form
    {
        public FormEditaProdutos()
        {
            InitializeComponent();
            PopularComboBox();
        }

        public FormEditaProdutos(DataGridViewRow linha)
        {
            InitializeComponent();
            PopularComboBox();

            if (linha != null)
            {
                
                StringConexao objStringConexao = new StringConexao();
                string contemStringConexao = objStringConexao.Conectar();

                NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
                objConnection.Open();

                DataTable dtNomeColecao = new DataTable();
                string stringSql = $"SELECT nome_colecao FROM colecoes WHERE id_colecao = '{linha.Cells[2].Value.ToString()}'";

                using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
                {
                    NpgsqlDataAdapter.Fill(dtNomeColecao);
                }

                


                tbIdProduto.Text = linha.Cells[0].Value.ToString();
                tbNomeProduto.Text = linha.Cells[1].Value.ToString();
                cbColecao.Text = dtNomeColecao.Rows[0]["nome_colecao"].ToString();
                tbQtd.Text = linha.Cells[3].Value.ToString();                
                tbPrecoCusto.Text = linha.Cells[4].Value.ToString();
                tbPrecoVenda.Text = linha.Cells[5].Value.ToString();

            }


        }
        private void btEditarProduto_Click(object sender, EventArgs e)
        {
            if (ValidaInformacao() == true)
            {
                string idProduto = tbIdProduto.Text;

                Produto objProduto = new Produto(tbIdProduto.Text, tbNomeProduto.Text, cbColecao.Text, Convert.ToInt32(tbQtd.Text), Convert.ToDouble(tbPrecoCusto.Text),
                    Convert.ToDouble(tbPrecoVenda.Text));

                StringConexao objStringConexao = new StringConexao();
                string contemStringConexao = objStringConexao.Conectar();

                NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
                objConnection.Open();

                string stringSql = $"UPDATE produtos SET nome_produto = '{objProduto.NomeProduto}', id_colecao = '{PegarIdColecao()}', " +
                                   $"qtd_estoque = '{objProduto.QtdEstoque}', custo_produto = '{objProduto.CustoProduto}', preco_venda = '{objProduto.PrecoVenda}' WHERE id_produto = {idProduto}";

                using (NpgsqlCommand NpgsqlCommand = new NpgsqlCommand(stringSql, objConnection))
                {
                    NpgsqlCommand.ExecuteNonQuery();
                }




                objConnection.Close();

                MessageBox.Show("Produto Editado com Sucesso! ", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparTextBox();

            }

            else
            {
                MessageBox.Show("Verifique os dados inseridos!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private bool ValidaInformacao()
        {
            bool valida = false;



            if (tbNomeProduto.Text.Trim() != String.Empty && cbColecao.Text.Trim() != String.Empty && tbQtd.Text.Trim() != String.Empty &&
                tbPrecoCusto.Text.Trim() != String.Empty && tbPrecoVenda.Text.Trim() != String.Empty)
            {
                valida = true;

            }


            return valida;
        }
        private void LimparTextBox()
        {
            tbIdProduto.Text = String.Empty;
            tbNomeProduto.Text = String.Empty;
            cbColecao.Text = String.Empty;
            tbQtd.Text = String.Empty;
            tbPrecoCusto.Text = String.Empty;
            tbPrecoVenda.Text = String.Empty;
        }

        private string PegarIdColecao()
        {

            string IdColecao;

            StringConexao objStringConexao = new StringConexao();
            string contemStringConexao = objStringConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
            objConnection.Open();

            DataTable dtIdColecao = new DataTable();
            string stringSql = $"SELECT id_colecao FROM colecoes WHERE nome_colecao = '{cbColecao.Text}'";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dtIdColecao);
            }


            IdColecao = dtIdColecao.Rows[0]["id_colecao"].ToString();

            objConnection.Close();

            return IdColecao;
        }

        private void PopularComboBox()
        {
            StringConexao objStringConexao = new StringConexao();
            string contemStringConexao = objStringConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
            objConnection.Open();



            DataTable dtColecao = new DataTable();
            string stringSql = "SELECT nome_colecao FROM colecoes";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dtColecao);
            }

            for (int i = 0; i < dtColecao.Rows.Count; i++)
            {
                cbColecao.Items.Add(dtColecao.Rows[i]["nome_colecao"].ToString());
            }



            objConnection.Close();
        }

    }
}
