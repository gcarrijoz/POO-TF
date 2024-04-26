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
    public partial class FormCadastroProdutos : Form
    {
        public FormCadastroProdutos()
        {
            InitializeComponent();
            PopularComboBox();
        }



        private bool ValidaInformacao()
        {
            bool valida = false;


            if (tbNomeProduto.Text.Trim() != String.Empty && cbColecao.Text.Trim() != String.Empty && tbQtd.Text.Trim() != String.Empty && tbPrecoVenda.Text.Trim() != String.Empty
                && tbPrecoCusto.Text.Trim() != String.Empty)
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

        private void btCadastrarProduto_Click(object sender, EventArgs e)
        {
            {
                if (ValidaInformacao() == true)
                {                   

                    Produto objProduto = new Produto(tbIdProduto.Text, tbNomeProduto.Text, cbColecao.Text, Convert.ToInt32(tbQtd.Text), Convert.ToDouble(tbPrecoCusto.Text), Convert.ToDouble(tbPrecoVenda.Text));

                    StringConexao objStringConexao = new StringConexao();
                    string contemStringConexao = objStringConexao.Conectar();

                    NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
                    objConnection.Open();

                    string stringSql = "INSERT INTO Produtos(nome_produto, id_colecao, qtd_estoque, custo_produto, preco_venda)" +
                            $"VALUES('{objProduto.NomeProduto}', '{PegarIdColecao()}', {objProduto.QtdEstoque}, {objProduto.CustoProduto}, {objProduto.PrecoVenda})";

                    using (NpgsqlCommand NpgsqlCommand = new NpgsqlCommand(stringSql, objConnection))
                    {
                        NpgsqlCommand.ExecuteNonQuery();
                    }

                    objConnection.Close();

                    MessageBox.Show("Produto Cadastrado com Sucesso!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparTextBox();
                }

                else
                {
                    MessageBox.Show("Verifique os dados inseridos!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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



    }
    
}
