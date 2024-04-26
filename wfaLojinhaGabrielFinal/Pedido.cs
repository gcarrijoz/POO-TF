using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaLojinhaGabrielFinal
{
    class Pedido
    {
        private string idPedido;
        private string idCliente;
        private string idProduto;
        private int qtdPedido;
        private double precoVenda;
        private double precoCusto;    
        private string dataPedido;     


        public Pedido(string idPedido, string idCliente, string idProduto, int qtdPedido, double precoVenda, double precoCusto, string dataPedido)
        {
            this.idPedido = idPedido;
            this.idCliente = idCliente;
            this.idProduto = idProduto;
            this.qtdPedido = qtdPedido;
            this.precoVenda = precoVenda;
            this.precoCusto = precoCusto;
            this.dataPedido = dataPedido;
        }

        public string IdPedido { get => idPedido; set => idPedido = value; }
        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string IdProduto { get => idProduto; set => idProduto = value; }
        public int QtdPedido { get => qtdPedido; set => qtdPedido = value; }
        public double PrecoVenda { get => precoVenda; set => precoVenda = value; }
        public double PrecoCusto { get => precoCusto; set => precoCusto = value; }
        public string DataPedido { get => dataPedido; set => dataPedido = value; }

        public double CalcularFaturamento()
        {
            double faturamento;

            faturamento = precoVenda * qtdPedido;

            return faturamento;
        }

        public double CalcularCusto()
        {
            double custo;

            custo = precoCusto * qtdPedido;

            return custo;
        }

        public double CalcularLucro()
        {
            double lucro;

            lucro = CalcularFaturamento() - CalcularCusto();

            return lucro;
        }
    }
}
