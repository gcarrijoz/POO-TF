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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            ExibirTabela();

        }

        
        private void btCadastrarCliente_Click(object sender, EventArgs e)
        {
            FormCadastroClientes objFormCadastroClientes = new FormCadastroClientes();            
            objFormCadastroClientes.ShowDialog();
            ExibirTabela();

        }

        private void ExibirTabela()
        {
            ConfigurarTabela();
            StringConexao objStringConexao = new StringConexao();
            string contemStringConexao = objStringConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
            objConnection.Open();



            DataTable dt = new DataTable();
            string stringSql = "SELECT * FROM clientes ORDER BY id_cliente";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dt);
            }

            dgvClientes.DataSource = dt;



            objConnection.Close();
        }

        private void ConfigurarTabela()
        {
           
            //dgvClientes.Columns[0].HeaderText = "Código";
            //dgvClientes.Columns[1].HeaderText = "Nome";
            //dgvClientes.Columns[2].HeaderText = "Sobrenome";
            //dgvClientes.Columns[3].HeaderText = "E-mail";
            //dgvClientes.Columns[4].HeaderText = "Celular";

            //dgvClientes.Columns[0].Width = 100;
        }

        private void btAtualizarCliente_Click(object sender, EventArgs e)
        {
            
            FormEditaClientes objFormEditaClientes = new FormEditaClientes(dgvClientes.CurrentRow);
            objFormEditaClientes.ShowDialog();
            ExibirTabela();
        }

        private void dgvClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormEditaClientes objFormEditaClientes = new FormEditaClientes(dgvClientes.Rows[e.RowIndex]);  
            objFormEditaClientes.ShowDialog();
            ExibirTabela();

        }

        private void btRemoverCliente_Click(object sender, EventArgs e)
        {
            FormRemoveClientes objFormRemoveClientes = new FormRemoveClientes(dgvClientes.CurrentRow);
            objFormRemoveClientes.ShowDialog();
            ExibirTabela();

        }

        
    }
}
