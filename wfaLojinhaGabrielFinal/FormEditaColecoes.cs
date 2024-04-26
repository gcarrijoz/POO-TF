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
    public partial class FormEditaColecoes : Form
    {
        public FormEditaColecoes()
        {
            InitializeComponent();
        }

        public FormEditaColecoes(DataGridViewRow linha)
        {
            InitializeComponent();
            if (linha != null)
            {
                tbIdColecao.Text = linha.Cells[0].Value.ToString();
                tbNomeColecao.Text = linha.Cells[1].Value.ToString();
            }
            
        }

        private void btEditarColecao_Click(object sender, EventArgs e)
        {
            if (ValidaInformacao() == true)
            {
                string idColecao = tbIdColecao.Text;

                Colecao objColecao = new Colecao(tbIdColecao.Text, tbNomeColecao.Text);

                StringConexao objStringConexao = new StringConexao();
                string contemStringConexao = objStringConexao.Conectar();

                NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
                objConnection.Open();

                string stringSql = $"UPDATE colecoes SET nome_colecao = '{objColecao.NomeColecao}' WHERE id_colecao = {idColecao}";

                using (NpgsqlCommand NpgsqlCommand = new NpgsqlCommand(stringSql, objConnection))
                {
                    NpgsqlCommand.ExecuteNonQuery();
                }




                objConnection.Close();

                MessageBox.Show("Coleção Editada com Sucesso! ", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparTextBox();

            }

            else
            {
                MessageBox.Show("Verifique os dados inseridos!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimparTextBox()
        {
            tbIdColecao.Text = String.Empty;
            tbNomeColecao.Text = String.Empty;
        }

        private bool ValidaInformacao()
        {
            bool valida = false;

            if (tbNomeColecao.Text.Trim() != String.Empty)
            {
                valida = true;
            }


            return valida;
        }

        

     
    }
}
