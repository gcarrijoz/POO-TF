using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaLojinhaGabrielFinal
{
    class Produto
    {
        private string idProduto;
        private string nomeProduto;
        private string colecao;
        private int qtdEstoque;
        private double custoProduto;
        private double precoVenda;

        public Produto(string idProduto, string nomeProduto, string colecao, int qtdEstoque, double custoProduto, double precoVenda)
        {
            this.idProduto = idProduto;
            this.nomeProduto = nomeProduto;
            this.colecao = colecao;
            this.qtdEstoque = qtdEstoque;
            this.custoProduto = custoProduto;
            this.precoVenda = precoVenda;
        }

        public string IdProduto { get => idProduto; set => idProduto = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public string Colecao { get => colecao; set => colecao = value; }
        public int QtdEstoque { get => qtdEstoque; set => qtdEstoque = value; }
        public double CustoProduto { get => custoProduto; set => custoProduto = value; }
        public double PrecoVenda { get => precoVenda; set => precoVenda = value; }
    }
}
