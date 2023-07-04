using System;
using System.Collections.Generic;
using System.Text;

namespace Aula13
{
    class Gerente : Funcionario
    {
        public string Setor { get; set; }
        public override double Calcula => Salario - (Salario * 0.5);
    }
}
