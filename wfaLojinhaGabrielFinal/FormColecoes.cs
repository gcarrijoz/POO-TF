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
    public partial class FormColecoes : Form
    {
        public FormColecoes()
        {
            InitializeComponent();
            ExibirTabela();

        }

        private void btCadastrarColecao_Click(object sender, EventArgs e)
        {
            FormCadastroColecoes objFormCadastroColecoes = new FormCadastroColecoes();           
            objFormCadastroColecoes.ShowDialog();
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
            string stringSql = "SELECT * FROM colecoes ORDER BY id_colecao";

            using (NpgsqlDataAdapter NpgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                NpgsqlDataAdapter.Fill(dt);
            }

            dgvColecoes.DataSource = dt;



            objConnection.Close();
        }

       

        private void btAtualizarColecao_Click(object sender, EventArgs e)
        {
            FormEditaColecoes objFormEditaColecoes = new FormEditaColecoes(dgvColecoes.CurrentRow);
            objFormEditaColecoes.ShowDialog();
            ExibirTabela();
        }

        private void dgvColecoes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormEditaColecoes objFormEditaColecoes = new FormEditaColecoes(dgvColecoes.Rows[e.RowIndex]);
            objFormEditaColecoes.ShowDialog();
            ExibirTabela();
        }

        private void btRemoverColecao_Click(object sender, EventArgs e)
        {
            FormRemoveColecoes objFormRemoveColecoes = new FormRemoveColecoes(dgvColecoes.CurrentRow);
            objFormRemoveColecoes.ShowDialog();
            ExibirTabela();
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
    }
}
