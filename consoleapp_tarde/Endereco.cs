using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp_tarde
{
    internal class Endereco
    {
        private int Id;
        private string CEP;
        private string Rua;
        private string Numero;
        private string Bairro;
        private string Cidade;

        public Endereco(int id, string cep, string rua, string numero, string bairro, string cidade)
        {
            Id = id;
            CEP = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;

        }
    }
}
