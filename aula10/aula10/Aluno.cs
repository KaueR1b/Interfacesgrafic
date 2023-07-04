using System;
using System.Collections.Generic;
using System.Text;

namespace aula10
{
    class Aluno : Pessoa
    {
        public int Ra { get; set; }
        public string Curso { get; set; }
        public string Turma { get; set; }
        
        public Aluno(string nome, int cpf, string endereco, int telefone, int ra, string curso, string turma) : base (nome, cpf, endereco, telefone)
        {
            this.Ra = ra;
            this.Curso = curso;
            this.Turma = turma;
        }
    }
}
