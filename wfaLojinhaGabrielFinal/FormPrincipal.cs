using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace wfaLojinhaGabrielFinal
{
    public partial class FormPrincipal : Form
    {
        
        public FormPrincipal()
        {
            InitializeComponent();
            FormInicio objFormInicio = new FormInicio();    
            MostrarForm(objFormInicio);
            AtivarButton(btHome);
        }

        private void AtivarButton(Button objFormAtivo)
        {
            foreach (Control objCtrl in panelLateral.Controls)
            {
                objCtrl.ForeColor = Color.White;

            }
            foreach (Control objCtrl in panelRelatorio.Controls)
            {
                objCtrl.ForeColor = Color.White;

            }
            objFormAtivo.ForeColor = Color.FromArgb(56, 182, 255);
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            panelRelatorio.Visible = true;
            
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            AtivarButton(btHome);
            panelRelatorio.Visible = false;
            FormInicio objFormInicio = new FormInicio();
            MostrarForm(objFormInicio);

        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            AtivarButton(btClientes);
            panelRelatorio.Visible = false;
            FormClientes objFormClientes = new FormClientes();
            MostrarForm(objFormClientes);

        }

        private void btColecoes_Click(object sender, EventArgs e)
        {
            AtivarButton(btColecoes);
            panelRelatorio.Visible = false;
            FormColecoes objFormColecoes = new FormColecoes();
            MostrarForm(objFormColecoes);
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            AtivarButton(btProdutos);
            panelRelatorio.Visible = false;
            FormProdutos objFormProdutos = new FormProdutos();
            MostrarForm(objFormProdutos);
        }

        private void btVendas_Click(object sender, EventArgs e)
        {
            AtivarButton(btVendas);
            panelRelatorio.Visible = false;
            FormVendas objFormVendas = new FormVendas();
            MostrarForm(objFormVendas);
        }



        private void btRelataEstoque_Click(object sender, EventArgs e)
        {
            AtivarButton(btRelataEstoque);
            FormRelataEstoque objFormRelataEstoque = new FormRelataEstoque();
            MostrarForm(objFormRelataEstoque);
        }

        private void btRelataVendas_Click(object sender, EventArgs e)
        {
            AtivarButton(btRelataVendas);
        }


        private Form objFormAtivo = new Form();

        private void FecharForm()
        {
            if (objFormAtivo != null)
            {
                objFormAtivo.Close();
            }

        }
        private void MostrarForm(Form objForm)
        {
            FecharForm();
            objFormAtivo = objForm;
            objForm.TopLevel = false;
            panelForms.Controls.Add(objForm);
            objForm.BringToFront();
            objForm.Show();

        }



    }
}
