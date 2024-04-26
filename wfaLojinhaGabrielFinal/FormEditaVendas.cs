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
    public partial class FormEditaVendas : Form
    {
        public FormEditaVendas()
        {
            InitializeComponent();
            PopularComboBoxProduto();
            PopularComboBoxCliente();
            dtpData.CustomFormat = "dd/MM/yyyy";
        }

        public FormEditaVendas(DataGridViewRow linha)
        {
            InitializeComponent();
            PopularComboBoxProduto();
            PopularComboBoxCliente();
            dtpData.CustomFormat = "dd/MM/yyyy";

            if (linha != null)
            {

                StringConexao objStringConexao = new StringConexao();
                string contemStringConexao = objStringConexao.Conectar();

                NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
                objConnection.Open();

                DataTable dtNomeProduto = new DataTable();
                string stringSql = $"SELECT nome_produto FROM produtos WHERE id_produto = '{linha.Cells[2].Value.ToString()}'";

                using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
                {
                    NpgsqlDataAdapter.Fill(dtNomeProduto);
                }


                DataTable dtCliente = new DataTable();
                stringSql = $"SELECT nome_cliente, sobrenome_cliente FROM clientes WHERE id_cliente ={linha.Cells[1].Value.ToString()}";

                using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
                {
                    NpgsqlDataAdapter.Fill(dtCliente);
                }

                






                tbIdVenda.Text = linha.Cells[0].Value.ToString();
                cbCliente.Text = dtCliente.Rows[0]["nome_cliente"].ToString() + " " + dtCliente.Rows[0]["sobrenome_cliente"].ToString();
                cbProduto.Text = dtNomeProduto.Rows[0]["nome_produto"].ToString();
                tbQtd.Text = linha.Cells[3].Value.ToString();
                dtpData.Text = linha.Cells[7].Value.ToString();


            }


        }

        private void btEditarVenda_Click(object sender, EventArgs e)
        {
            if (ValidaInformacao() == true)
            {
                string idVenda = tbIdVenda.Text;

                Pedido objVenda = new Pedido(tbIdVenda.Text, cbCliente.Text, cbProduto.Text, Convert.ToInt32(tbQtd.Text), PegarPrecoVenda(), PegarPrecoCusto(), dtpData.Value.Date.ToString());

                StringConexao objStringConexao = new StringConexao();
                string contemStringConexao = objStringConexao.Conectar();

                NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
                objConnection.Open();

                string stringSql = $"UPDATE pedidos SET id_cliente = '{PegarIdCliente()}', id_produto = '{PegarIdProduto()}', " +
                                   $"qtd = {objVenda.QtdPedido}, faturamento_pedido = {objVenda.CalcularFaturamento()}, custo_pedido = {objVenda.CalcularCusto()}, lucro_pedido = {objVenda.CalcularLucro()}, data_pedido = '{objVenda.DataPedido}' WHERE id_pedido = {idVenda}";

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

        private void PopularComboBoxCliente()
        {
            StringConexao objStringConexao = new StringConexao();
            string contemStringConexao = objStringConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
            objConnection.Open();



            DataTable dtCliente = new DataTable();
            string stringSql = "SELECT nome_cliente, sobrenome_cliente FROM clientes";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dtCliente);
            }

            for (int i = 0; i < dtCliente.Rows.Count; i++)
            {
                string nomeCliente = dtCliente.Rows[i]["nome_cliente"].ToString() + " " + dtCliente.Rows[i]["sobrenome_cliente"].ToString();
                cbCliente.Items.Add(nomeCliente);
            }



            objConnection.Close();
        }
        private void PopularComboBoxProduto()
        {
            StringConexao objStringConexao = new StringConexao();
            string contemStringConexao = objStringConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
            objConnection.Open();



            DataTable dtProduto = new DataTable();
            string stringSql = "SELECT nome_produto FROM produtos";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dtProduto);
            }

            for (int i = 0; i < dtProduto.Rows.Count; i++)
            {
                cbProduto.Items.Add(dtProduto.Rows[i]["nome_produto"].ToString());
            }



            objConnection.Close();
        }

        private bool ValidaInformacao()
        {
            bool valida = false;

            if (tbQtd.Text.Trim() != String.Empty && cbCliente.Text.Trim() != String.Empty && cbProduto.Text.Trim() != String.Empty)
            {
                valida = true;

            }


            return valida;
        }
        private void LimparTextBox()
        {
            tbIdVenda.Text = String.Empty;
            tbQtd.Text = String.Empty;
            cbCliente.Text = String.Empty;
            cbProduto.Text = String.Empty;            
        }

        private double PegarPrecoVenda()
        {
            string strPrecoVenda;
            double precoVenda;

            StringConexao objStringConexao = new StringConexao();
            string contemStringConexao = objStringConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
            objConnection.Open();

            DataTable dtPrecoCusto = new DataTable();
            string stringSql = $"SELECT preco_venda FROM produtos WHERE id_produto = '{PegarIdProduto()}'";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dtPrecoCusto);
            }


            strPrecoVenda = dtPrecoCusto.Rows[0]["preco_venda"].ToString();

            precoVenda = Convert.ToDouble(strPrecoVenda);

            objConnection.Close();

            return precoVenda;
        }

        private double PegarPrecoCusto()
        {
            string strPrecoCusto;
            double precoCusto;

            StringConexao objStringConexao = new StringConexao();
            string contemStringConexao = objStringConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
            objConnection.Open();

            DataTable dtPrecoCusto = new DataTable();
            string stringSql = $"SELECT custo_produto FROM produtos WHERE id_produto = '{PegarIdProduto()}'";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dtPrecoCusto);
            }


            strPrecoCusto = dtPrecoCusto.Rows[0]["custo_produto"].ToString();

            precoCusto = Convert.ToDouble(strPrecoCusto);

            objConnection.Close();

            return precoCusto;
        }

        private string PegarIdCliente()
        {

            string IdCliente;

            StringConexao objStringConexao = new StringConexao();
            string contemStringConexao = objStringConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
            objConnection.Open();

            string[] nomeCompleto = cbCliente.Text.Split(' ');
            string sobrenome = string.Empty;
            string nome = nomeCompleto[0];
            int iMax = nomeCompleto.Length - 1;

            for (int i = 1; i < iMax; i++)
            {
                sobrenome += nomeCompleto[i] + " ";
            }
            sobrenome = sobrenome + nomeCompleto[iMax];

            DataTable dtIdCliente = new DataTable();
            string stringSql = $"SELECT id_cliente FROM clientes WHERE sobrenome_cliente = '{sobrenome}' AND nome_cliente = '{nome}'";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dtIdCliente);
            }


            IdCliente = dtIdCliente.Rows[0]["id_cliente"].ToString();

            objConnection.Close();

            return IdCliente;

        }


        private string PegarIdProduto()
        {
            string idProduto;

            StringConexao objStringConexao = new StringConexao();
            string contemStringConexao = objStringConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
            objConnection.Open();

            DataTable dtIdProduto = new DataTable();
            string stringSql = $"SELECT id_produto FROM produtos WHERE nome_produto = '{cbProduto.Text}'";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dtIdProduto);
            }


            idProduto = dtIdProduto.Rows[0]["id_produto"].ToString();

            objConnection.Close();

            return idProduto;
        }

    }
}
