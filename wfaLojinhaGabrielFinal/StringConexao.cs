using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaLojinhaGabrielFinal
{
    class StringConexao
    {
        string serverName = "localhost"; // localhost 
        string port = "porta"; // porta default
        string userName = "username"; // nome do administrador
        string password = "password"; // Senha do SGDB
        string dataBaseName = "dbname"; // Nome do Banco de Dados



        public string Conectar()
        {
            var connString = String.Format("Server = {0}; Port = {1}; Username = {2}; Password = {3}; Database = {4};", serverName, port, userName,
                password, dataBaseName);

            return connString;
        }
    }

    
}
