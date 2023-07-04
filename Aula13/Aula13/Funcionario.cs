using System;
using System.Collections.Generic;
using System.Text;

namespace Aula13
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public double Salario { get; set; }
        public abstract double Calcula { get; }

    }
}
