using System;
using System.Collections.Generic;
using System.Text;

namespace aula10
{
    class Pessoa
    {
       public string Nome { get; set; }
        public int CPF { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }

        public Pessoa (string nome, int cpf, string endereco, int telefone)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Endereco = endereco;
            this.Telefone = telefone;

        }
    }
}
