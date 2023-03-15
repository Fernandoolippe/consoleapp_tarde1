using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp_tarde
{
    internal class Cliente
    {
        private int Id;
        private string Nome;
        private string Telefone;
        private Endereco Endereco;

        public Cliente(int id, string nome, string telefone, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }

        public string ExibirDados()
        {
            return Nome + " Telefone " + Telefone + Endereco.EnderecoCompleto();
        }

        public Endereco getEndereco()
        {
            return Endereco;
        }
        public void setEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public int getId()
        {
            return Id;
        }

        public string getNome()
        {
            return Nome;
        }

        public string getTelefone()
        {
            return Telefone;
        }

        public void setNome(string nome)
        {
            Nome = nome;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }
    }
}
