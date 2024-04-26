using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaLojinhaGabrielFinal
{
    class Colecao
    {
        private string idColecao;
        private string nomeColecao;

        public Colecao(string idColecao, string nomeColecao)
        {
            this.idColecao = idColecao;
            this.nomeColecao = nomeColecao;
        }

        public string IdColecao { get => idColecao; set => idColecao = value; }
        public string NomeColecao { get => nomeColecao; set => nomeColecao = value; }
    }
}
