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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            MostrarClientes();
            MostrarProdutos();
            MostrarTabelaProdutos();
            MostrarLucro();
            MostrarFaturamento();
            MostrarVendas();
            MostrarTabelaVendas();

        }

        


        private void MostrarClientes()
        {
            StringConexao objStringConexao = new StringConexao();
            string contemStringConexao = objStringConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
            objConnection.Open();



            DataTable dtCliente = new DataTable();
            string stringSql = "SELECT COUNT(id_cliente) FROM clientes";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dtCliente);
            }

            tbClientes.Text = dtCliente.Rows[0]["count"].ToString();



            objConnection.Close();


        }

        private void MostrarProdutos()
        {

            StringConexao objStringConexao = new StringConexao();
            string contemStringConexao = objStringConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
            objConnection.Open();



            DataTable dtProduto = new DataTable();
            string stringSql = "SELECT COUNT(id_produto) FROM produtos";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dtProduto);
            }

            tbProdutos.Text = dtProduto.Rows[0]["count"].ToString();



            objConnection.Close();

        }

        private void MostrarTabelaProdutos()
        {
            
            StringConexao objStringConexao = new StringConexao();
            string contemStringConexao = objStringConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
            objConnection.Open();



            DataTable dtProdutosBaixo = new DataTable();
            string stringSql = "SELECT id_produto, nome_produto, qtd_estoque FROM produtos WHERE qtd_estoque < 10 ORDER BY qtd_estoque ASC";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dtProdutosBaixo);
            }

            dgvProdutosBaixo.DataSource = dtProdutosBaixo;



            objConnection.Close();
        }

        private void MostrarTabelaVendas()
        {
            StringConexao objStringConexao = new StringConexao();
            string contemStringConexao = objStringConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
            objConnection.Open();



            DataTable dtVendasRecentes = new DataTable();
            string stringSql = "SELECT id_pedido, id_produto, lucro_pedido, data_pedido FROM pedidos ORDER BY data_pedido DESC LIMIT 10";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dtVendasRecentes);
            }

            dgvVendasRecentes.DataSource = dtVendasRecentes;



            objConnection.Close();
        }

        private void MostrarLucro()
        {
            string strLucro;
            StringConexao objStringConexao = new StringConexao();
            string contemStringConexao = objStringConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
            objConnection.Open();



            DataTable dtLucro = new DataTable();
            string stringSql = "SELECT SUM(lucro_pedido) FROM pedidos";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dtLucro);
            }

            strLucro = dtLucro.Rows[0]["sum"].ToString();

            tbLucro.Text = "R$ " + strLucro;



            objConnection.Close();

        }

        private void MostrarFaturamento()
        {
            string strFaturamento;
            StringConexao objStringConexao = new StringConexao();
            string contemStringConexao = objStringConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
            objConnection.Open();



            DataTable dtFaturamento = new DataTable();
            string stringSql = "SELECT SUM(faturamento_pedido) FROM pedidos";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dtFaturamento);
            }

            strFaturamento = dtFaturamento.Rows[0]["sum"].ToString();

            tbFaturamento.Text = "R$ " + strFaturamento;



            objConnection.Close();
        }

        private void MostrarVendas()
        {
           
            StringConexao objStringConexao = new StringConexao();
            string contemStringConexao = objStringConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
            objConnection.Open();



            DataTable dtVendas = new DataTable();
            string stringSql = "SELECT count(id_pedido) FROM pedidos";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dtVendas);
            }

            tbVendas.Text = dtVendas.Rows[0]["count"].ToString();            



            objConnection.Close();

        }

       
    }
}
