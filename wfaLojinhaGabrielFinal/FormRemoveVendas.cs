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
    public partial class FormRemoveVendas : Form
    {
        public FormRemoveVendas()
        {
            InitializeComponent();
            PopularComboBoxProduto();
            PopularComboBoxCliente();
            dtpData.CustomFormat = "dd/MM/yyyy";
        }

        public FormRemoveVendas(DataGridViewRow linha)
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
        private void LimparTextBox()
        {
            tbIdVenda.Text = String.Empty;
            cbCliente.Text = String.Empty;
            cbProduto.Text = String.Empty;
            tbQtd.Text = String.Empty;
            dtpData.Value = DateTime.Now;
            
        }

        private bool ValidaInformacao()
        {
            bool valida = false;



            if (cbCliente.Text.Trim() != String.Empty && cbProduto.Text.Trim() != String.Empty && tbQtd.Text.Trim() != String.Empty)
            {
                valida = true;

            }


            return valida;
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


        private void btExcluirVenda_Click(object sender, EventArgs e)
        {
            if (ValidaInformacao() == true)
            {
                string idVenda = tbIdVenda.Text;               

                StringConexao objStringConexao = new StringConexao();
                string contemStringConexao = objStringConexao.Conectar();

                NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
                objConnection.Open();

                string stringSql = $"DELETE FROM pedidos WHERE id_pedido = '{idVenda}'";

                using (NpgsqlCommand NpgsqlCommand = new NpgsqlCommand(stringSql, objConnection))
                {
                    NpgsqlCommand.ExecuteNonQuery();
                }




                objConnection.Close();

                MessageBox.Show("Venda Excluída com Sucesso! ", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparTextBox();

            }

            else
            {
                MessageBox.Show("Verifique os dados inseridos!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
