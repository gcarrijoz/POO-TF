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
    public partial class FormCadastroColecoes : Form
    {
        public FormCadastroColecoes()
        {
            InitializeComponent();
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

        private void btCadastrarColecao_Click(object sender, EventArgs e)
        {
            if(ValidaInformacao() == true)
            {
                Colecao objColecao = new Colecao(tbIdColecao.Text, tbNomeColecao.Text);

                StringConexao objStringConexao = new StringConexao();
                string contemStringConexao = objStringConexao.Conectar();

                NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
                objConnection.Open();

                string stringSql = "INSERT INTO Colecoes(nome_colecao)" +
                        $"VALUES('{objColecao.NomeColecao}')";

                using (NpgsqlCommand NpgsqlCommand = new NpgsqlCommand(stringSql, objConnection))
                {
                    NpgsqlCommand.ExecuteNonQuery();
                }

                objConnection.Close();

                MessageBox.Show("Coleção Cadastrada com Sucesso!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
