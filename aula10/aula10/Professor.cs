using System;
using System.Collections.Generic;
using System.Text;

namespace aula10
{
    class Professor : Pessoa
    {
        public string Num_aulas { get; set; }
        public string Graduacao { get; set;  }

        public Professor (string nome, string cpf, string endereco, string telefone, string num_aulas, string graduacao) : base(nome, cpf, endereco, telefone)
        {
            this.Num_aulas = num_aulas;
            this.Graduacao = graduacao;

        }
    }
}
