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
    public partial class FormEditaClientes : Form
    {
        public FormEditaClientes()
        {
            InitializeComponent();
            mtbCelularCliente.Mask = "(00)00000-0000";
        }

        public FormEditaClientes(DataGridViewRow linha)
        {
            InitializeComponent();
            if(linha != null)
            {
                tbIdCliente.Text = linha.Cells[0].Value.ToString();
                tbNomeCliente.Text = linha.Cells[1].Value.ToString();
                tbSobrenomeCliente.Text = linha.Cells[2].Value.ToString();
                tbEmailCliente.Text = linha.Cells[3].Value.ToString();
                mtbCelularCliente.Mask = "(00)00000-0000";
                mtbCelularCliente.Text = linha.Cells[4].Value.ToString();


            }
           

        }



        private void btEditarCliente_Click(object sender, EventArgs e)
        {
            if(ValidaInformacao() == true)
            {
                string idCliente = tbIdCliente.Text;

                Cliente objCliente = new Cliente(tbIdCliente.Text, tbNomeCliente.Text, tbSobrenomeCliente.Text, tbEmailCliente.Text, mtbCelularCliente.Text);

                StringConexao objStringConexao = new StringConexao();
                string contemStringConexao = objStringConexao.Conectar();

                NpgsqlConnection objConnection = new NpgsqlConnection(contemStringConexao);
                objConnection.Open();

                string stringSql = $"UPDATE clientes SET nome_cliente = '{objCliente.NomeCliente}', sobrenome_cliente = '{objCliente.SobrenomeCliente}', " +
                                   $"email_cliente = '{objCliente.EmailCliente}', celular_cliente = '{objCliente.CelularCliente}' WHERE id_cliente = {idCliente}";

                using (NpgsqlCommand NpgsqlCommand = new NpgsqlCommand(stringSql, objConnection))
                {
                    NpgsqlCommand.ExecuteNonQuery();
                }




                objConnection.Close();

                MessageBox.Show("Cliente Editado com Sucesso! ", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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



            if (tbNomeCliente.Text.Trim() != String.Empty && tbSobrenomeCliente.Text.Trim() != String.Empty && tbEmailCliente.Text.Trim() != String.Empty && mtbCelularCliente.Text.Trim() != String.Empty)
            {
                if (mtbCelularCliente.MaskCompleted == true)
                {
                    valida = true;
                }

            }


            return valida;
        }
        private void LimparTextBox()
        {
            tbIdCliente.Text = String.Empty;
            tbNomeCliente.Text = String.Empty;
            tbSobrenomeCliente.Text = String.Empty;
            tbEmailCliente.Text = String.Empty;
            mtbCelularCliente.Text = String.Empty;
        }

       
    }
}
