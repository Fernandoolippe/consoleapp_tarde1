using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp_tarde
{
    internal class Produto
    {
        private int Id;
        private string Descrição;
        private decimal Valor;

        public Produto(int id, string descricao, decimal valor)
        {
            Id = id;
            Descrição = descricao;
            Valor = valor;
        }

        public int getId()
        {
            return Id;
        }
        public string getDescrição()
        {
            return Descrição;
        }
        public decimal getValor()
        {
            return Valor;
        }
    }
}
