using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaLojinhaGabrielFinal
{
    class Cliente
    {
        private string idCliente;
        private string nomeCliente;
        private string sobrenomeCliente;
        private string emailCliente;
        private string celularCliente;

        public Cliente(string idCliente, string nomeCliente, string sobrenomeCliente, string emailCliente, string celularCliente)
        {
            this.idCliente = idCliente;
            this.nomeCliente = nomeCliente;
            this.sobrenomeCliente = sobrenomeCliente;            
            this.emailCliente = emailCliente;
            this.celularCliente = celularCliente;
        }

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string SobrenomeCliente { get => sobrenomeCliente; set => sobrenomeCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string CelularCliente { get => celularCliente; set => celularCliente = value; }
    }
}
